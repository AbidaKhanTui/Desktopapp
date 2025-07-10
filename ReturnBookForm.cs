using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public partial class ReturnBookForm : Form
    {
        private DBConnection db;

        public ReturnBookForm()
        {
            InitializeComponent();
            db = new DBConnection();
            LoadIssuedBooks();
        }

        private void LoadIssuedBooks()
        {
            // Only show books that are currently issued and not yet returned (or fine is 0, assuming 0 fine means not returned yet)
            string query = "SELECT ib.id, u.name as UserName, b.bookname as BookName, ib.issuedate, ib.issuereturn, ib.fine FROM issuebook ib JOIN userdata u ON ib.userid = u.id JOIN book b ON ib.issuebook = b.bookname WHERE ib.fine = 0";
            DataTable dt = db.ExecuteQuery(query);
            dgvIssuedBooks.DataSource = dt;

            dgvIssuedBooks.Columns["id"].HeaderText = "Issue ID";
            dgvIssuedBooks.Columns["UserName"].HeaderText = "User Name";
            dgvIssuedBooks.Columns["BookName"].HeaderText = "Book Name";
            dgvIssuedBooks.Columns["issuedate"].HeaderText = "Issue Date";
            dgvIssuedBooks.Columns["issuereturn"].HeaderText = "Expected Return Date";
            dgvIssuedBooks.Columns["fine"].HeaderText = "Current Fine";
            dgvIssuedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvIssuedBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvIssuedBooks.Rows[e.RowIndex];
                txtIssueId.Text = row.Cells["id"].Value.ToString();
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
                txtBookName.Text = row.Cells["BookName"].Value.ToString();
                lblFineAmount.Text = "Fine: 0"; // Reset fine display

                // Calculate fine if overdue
                string expectedReturnDateStr = row.Cells["issuereturn"].Value.ToString();
                DateTime expectedReturnDate;

                if (DateTime.TryParseExact(expectedReturnDateStr, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out expectedReturnDate))
                {
                    DateTime today = DateTime.Now.Date;
                    if (today > expectedReturnDate)
                    {
                        TimeSpan overdueDays = today - expectedReturnDate;
                        int finePerDay = 10; // Example: 10 units per day fine
                        int calculatedFine = (int)overdueDays.TotalDays * finePerDay;
                        lblFineAmount.Text = $"Fine: {calculatedFine}";
                    }
                }
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIssueId.Text))
            {
                MessageBox.Show("Please select an issued book to return.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int issueId = Convert.ToInt32(txtIssueId.Text);
            string bookName = txtBookName.Text.Trim(); // Get book name to update book table
            int fine = 0;
            if (lblFineAmount.Text.Contains("Fine: "))
            {
                int.TryParse(lblFineAmount.Text.Replace("Fine: ", ""), out fine);
            }

            DialogResult result = MessageBox.Show($"Confirm return of book '{bookName}' (Issue ID: {issueId}) with a fine of {fine}?", "Confirm Return", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Begin transaction for atomicity
                MySqlTransaction transaction = null;
                try
                {
                    db.OpenConnection();
                    transaction = db.Connection.BeginTransaction();

                    // Update issuebook table: Set current date as return date and fine
                    string updateIssueQuery = "UPDATE issuebook SET issuereturn = @actualreturn, fine = @fine WHERE id = @issueid";
                    MySqlParameter[] updateIssueParams = new MySqlParameter[]
                    {
                        new MySqlParameter("@actualreturn", DateTime.Now.ToString("dd/MM/yyyy")),
                        new MySqlParameter("@fine", fine),
                        new MySqlParameter("@issueid", issueId)
                    };
                    MySqlCommand updateIssueCmd = new MySqlCommand(updateIssueQuery, db.Connection, transaction);
                    updateIssueCmd.Parameters.AddRange(updateIssueParams);
                    updateIssueCmd.ExecuteNonQuery();

                    // Update book table: Increase available quantity, decrease rented quantity
                    string updateBookQuery = "UPDATE book SET bookava = bookava + 1, bookrent = bookrent - 1 WHERE bookname = @bookname";
                    MySqlParameter[] updateBookParams = new MySqlParameter[]
                    {
                        new MySqlParameter("@bookname", bookName)
                    };
                    MySqlCommand updateBookCmd = new MySqlCommand(updateBookQuery, db.Connection, transaction);
                    updateBookCmd.Parameters.AddRange(updateBookParams);
                    updateBookCmd.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Book returned successfully! Fine applied: " + fine, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadIssuedBooks(); // Refresh issued book list
                    ClearForm();
                }
                catch (MySqlException ex)
                {
                    transaction?.Rollback(); // Rollback on error
                    MessageBox.Show("Error returning book: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection();
                }
            }
        }

        private void txtSearchIssued_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchIssued.Text.Trim();
            string query = "SELECT ib.id, u.name as UserName, b.bookname as BookName, ib.issuedate, ib.issuereturn, ib.fine FROM issuebook ib JOIN userdata u ON ib.userid = u.id JOIN book b ON ib.issuebook = b.bookname WHERE ib.fine = 0 AND (u.name LIKE @searchTerm OR b.bookname LIKE @searchTerm)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@searchTerm", $"%{searchTerm}%")
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            dgvIssuedBooks.DataSource = dt;
        }

        private void ClearForm()
        {
            txtIssueId.Text = "";
            txtUserName.Text = "";
            txtBookName.Text = "";
            lblFineAmount.Text = "Fine: 0";
        }
    }
}
