using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public partial class ManageBooksForm : Form
    {
        private DBConnection db;

        public ManageBooksForm()
        {
            InitializeComponent();
            db = new DBConnection();
            LoadBooks();
        }

        private void LoadBooks()
        {
            string query = "SELECT id, bookname, bookdetail, bookaudor, bookpub, branch, bookprice, bookquantity, bookava, bookrent FROM book";
            DataTable dt = db.ExecuteQuery(query);
            dgvBooks.DataSource = dt;

            // Optional: Customize DataGridView columns
            dgvBooks.Columns["id"].HeaderText = "Book ID";
            dgvBooks.Columns["bookname"].HeaderText = "Title";
            dgvBooks.Columns["bookdetail"].HeaderText = "Details";
            dgvBooks.Columns["bookaudor"].HeaderText = "Author";
            dgvBooks.Columns["bookpub"].HeaderText = "Publisher";
            dgvBooks.Columns["branch"].HeaderText = "Branch";
            dgvBooks.Columns["bookprice"].HeaderText = "Price";
            dgvBooks.Columns["bookquantity"].HeaderText = "Total Qty";
            dgvBooks.Columns["bookava"].HeaderText = "Available Qty";
            dgvBooks.Columns["bookrent"].HeaderText = "Rented Qty";
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ClearForm()
        {
            txtBookId.Text = "";
            txtBookName.Text = "";
            txtBookDetail.Text = "";
            txtBookAuthor.Text = "";
            txtBookPublisher.Text = "";
            txtBookBranch.Text = "";
            txtBookPrice.Text = "";
            txtBookQuantity.Text = "";
            txtBookAvailable.Text = "";
            txtBookRented.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Note: bookpic is missing in the current form design and not mandatory based on SQL if auto-increment is used for id
            // You might want to add a text box or file dialog for bookpic
            string bookName = txtBookName.Text.Trim();
            string bookDetail = txtBookDetail.Text.Trim();
            string bookAuthor = txtBookAuthor.Text.Trim();
            string bookPub = txtBookPublisher.Text.Trim();
            string branch = txtBookBranch.Text.Trim();
            string bookPrice = txtBookPrice.Text.Trim();
            string bookQuantity = txtBookQuantity.Text.Trim();
            string bookAva = txtBookAvailable.Text.Trim();
            string bookRent = txtBookRented.Text.Trim();


            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(bookAuthor) || string.IsNullOrEmpty(bookQuantity))
            {
                MessageBox.Show("Please fill in required fields: Book Name, Author, and Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simple validation for numbers
            if (!int.TryParse(bookQuantity, out int quantity) || !int.TryParse(bookAva, out int available) || !int.TryParse(bookRent, out int rented))
            {
                MessageBox.Show("Quantity, Available, and Rented must be valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO book (bookname, bookdetail, bookaudor, bookpub, branch, bookprice, bookquantity, bookava, bookrent) VALUES (@bookname, @bookdetail, @bookaudor, @bookpub, @branch, @bookprice, @bookquantity, @bookava, @bookrent)";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@bookname", bookName),
                new MySqlParameter("@bookdetail", bookDetail),
                new MySqlParameter("@bookaudor", bookAuthor),
                new MySqlParameter("@bookpub", bookPub),
                new MySqlParameter("@branch", branch),
                new MySqlParameter("@bookprice", bookPrice),
                new MySqlParameter("@bookquantity", bookQuantity),
                new MySqlParameter("@bookava", bookAva),
                new MySqlParameter("@bookrent", bookRent)
            };

            int rowsAffected = db.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks(); // Refresh data
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to add book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookId.Text))
            {
                MessageBox.Show("Please select a book to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId = Convert.ToInt32(txtBookId.Text);
            string bookName = txtBookName.Text.Trim();
            string bookDetail = txtBookDetail.Text.Trim();
            string bookAuthor = txtBookAuthor.Text.Trim();
            string bookPub = txtBookPublisher.Text.Trim();
            string branch = txtBookBranch.Text.Trim();
            string bookPrice = txtBookPrice.Text.Trim();
            string bookQuantity = txtBookQuantity.Text.Trim();
            string bookAva = txtBookAvailable.Text.Trim();
            string bookRent = txtBookRented.Text.Trim();


            if (string.IsNullOrEmpty(bookName) || string.IsNullOrEmpty(bookAuthor) || string.IsNullOrEmpty(bookQuantity))
            {
                MessageBox.Show("Please fill in required fields: Book Name, Author, and Quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Simple validation for numbers
            if (!int.TryParse(bookQuantity, out int quantity) || !int.TryParse(bookAva, out int available) || !int.TryParse(bookRent, out int rented))
            {
                MessageBox.Show("Quantity, Available, and Rented must be valid numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string query = "UPDATE book SET bookname = @bookname, bookdetail = @bookdetail, bookaudor = @bookaudor, bookpub = @bookpub, branch = @branch, bookprice = @bookprice, bookquantity = @bookquantity, bookava = @bookava, bookrent = @bookrent WHERE id = @id";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@bookname", bookName),
                new MySqlParameter("@bookdetail", bookDetail),
                new MySqlParameter("@bookaudor", bookAuthor),
                new MySqlParameter("@bookpub", bookPub),
                new MySqlParameter("@branch", branch),
                new MySqlParameter("@bookprice", bookPrice),
                new MySqlParameter("@bookquantity", bookQuantity),
                new MySqlParameter("@bookava", bookAva),
                new MySqlParameter("@bookrent", bookRent),
                new MySqlParameter("@id", bookId)
            };

            int rowsAffected = db.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBooks(); // Refresh data
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to update book. Please ensure the book ID exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookId.Text))
            {
                MessageBox.Show("Please select a book to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookId = Convert.ToInt32(txtBookId.Text);

            DialogResult result = MessageBox.Show($"Are you sure you want to delete book ID {bookId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM book WHERE id = @id";
                MySqlParameter[] parameters = new MySqlParameter[]
                {
                    new MySqlParameter("@id", bookId)
                };

                int rowsAffected = db.ExecuteNonQuery(query, parameters);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks(); // Refresh data
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to delete book. Please ensure the book ID exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
                txtBookId.Text = row.Cells["id"].Value.ToString();
                txtBookName.Text = row.Cells["bookname"].Value.ToString();
                txtBookDetail.Text = row.Cells["bookdetail"].Value.ToString();
                txtBookAuthor.Text = row.Cells["bookaudor"].Value.ToString();
                txtBookPublisher.Text = row.Cells["bookpub"].Value.ToString();
                txtBookBranch.Text = row.Cells["branch"].Value.ToString();
                txtBookPrice.Text = row.Cells["bookprice"].Value.ToString();
                txtBookQuantity.Text = row.Cells["bookquantity"].Value.ToString();
                txtBookAvailable.Text = row.Cells["bookava"].Value.ToString();
                txtBookRented.Text = row.Cells["bookrent"].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string query = "SELECT id, bookname, bookdetail, bookaudor, bookpub, branch, bookprice, bookquantity, bookava, bookrent FROM book WHERE bookname LIKE @searchTerm OR bookaudor LIKE @searchTerm OR branch LIKE @searchTerm";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@searchTerm", $"%{searchTerm}%")
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            dgvBooks.DataSource = dt;
        }
    }
}
