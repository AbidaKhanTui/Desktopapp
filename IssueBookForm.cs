using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public partial class IssueBookForm : Form
    {
        private DBConnection db;

        public IssueBookForm()
        {
            InitializeComponent();
            db = new DBConnection();
            LoadUsers();
            LoadBooks();
            LoadIssuedBooks();
        }

        // Loads users into the ComboBox for selection, filtered by type 'Teacher' or 'Student'
        private void LoadUsers()
        {
            // Selects user ID, name, and type from the userdata table.
            // This query is modified to only fetch users whose type is 'Teacher' or 'Student'.
            string query = "SELECT id, name, type FROM userdata WHERE type = 'Teacher' OR type = 'Student'";
            DataTable dt = db.ExecuteQuery(query);
            cmbUser.DataSource = dt;
            cmbUser.DisplayMember = "name"; // Displays user name in the ComboBox
            cmbUser.ValueMember = "id";     // Uses user ID as the actual value when an item is selected
        }

        // Loads available books into the ComboBox for selection
        private void LoadBooks()
        {
            // Only show books that have at least one copy available (bookava > 0)
            string query = "SELECT id, bookname, bookava FROM book WHERE bookava > 0";
            DataTable dt = db.ExecuteQuery(query);
            cmbBook.DataSource = dt;
            cmbBook.DisplayMember = "bookname"; // Displays book name in the ComboBox
            cmbBook.ValueMember = "id";         // Uses book ID as the actual value
        }

        // Loads all currently issued books into the DataGridView
        private void LoadIssuedBooks()
        {
            // Joins issuebook, userdata, and book tables to get comprehensive information
            string query = "SELECT ib.id, u.name as UserName, b.bookname as BookName, ib.issuetype, ib.issuedays, ib.issuedate, ib.issuereturn, ib.fine FROM issuebook ib JOIN userdata u ON ib.userid = u.id JOIN book b ON ib.issuebook = b.bookname";
            DataTable dt = db.ExecuteQuery(query);
            dgvIssuedBooks.DataSource = dt;

            // Customize DataGridView column headers for better readability
            dgvIssuedBooks.Columns["id"].HeaderText = "Issue ID";
            dgvIssuedBooks.Columns["UserName"].HeaderText = "User Name";
            dgvIssuedBooks.Columns["BookName"].HeaderText = "Book Name";
            dgvIssuedBooks.Columns["issuetype"].HeaderText = "User Type"; // This will show "Teacher", "Student", etc. if in DB
            dgvIssuedBooks.Columns["issuedays"].HeaderText = "Days Issued";
            dgvIssuedBooks.Columns["issuedate"].HeaderText = "Issue Date";
            dgvIssuedBooks.Columns["issuereturn"].HeaderText = "Return Date";
            dgvIssuedBooks.Columns["fine"].HeaderText = "Fine";
            dgvIssuedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Handles the click event for the "Issue Book" button
        private void btnIssue_Click(object sender, EventArgs e)
        {
            // Input validation: Check if user, book, and issue days are selected/entered
            if (cmbUser.SelectedValue == null || cmbBook.SelectedValue == null || string.IsNullOrEmpty(txtIssueDays.Text))
            {
                MessageBox.Show("Please select a user, a book, and enter issue days.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Retrieve selected user and book IDs
            int userId = Convert.ToInt32(cmbUser.SelectedValue);
            int bookId = Convert.ToInt32(cmbBook.SelectedValue);
            string issueName = cmbUser.Text; // Get displayed user name from ComboBox
            string issueBookName = cmbBook.Text; // Get displayed book name from ComboBox

            // --- CRITICAL PART FOR USER TYPE ---
            // Fetch the user's type (e.g., Teacher, Student) directly from the userdata table
            // This ensures the correct type associated with the user is used, not manually entered
            string userTypeQuery = "SELECT type FROM userdata WHERE id = @userid";
            MySqlParameter[] userTypeParams = { new MySqlParameter("@userid", userId) };
            object userTypeResult = db.ExecuteScalar(userTypeQuery, userTypeParams);
            string issueType = userTypeResult?.ToString() ?? "Unknown"; // Default to "Unknown" if type is not found

            // Validate issue days input
            if (!int.TryParse(txtIssueDays.Text, out int issuedays) || issuedays <= 0)
            {
                MessageBox.Show("Please enter a valid number of issue days.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calculate issue and return dates
            string issueDate = DateTime.Now.ToString("dd/MM/yyyy");
            string returnDate = DateTime.Now.AddDays(issuedays).ToString("dd/MM/yyyy");

            // Check book availability before proceeding with transaction
            string checkBookQuery = "SELECT bookava, bookquantity, bookrent FROM book WHERE id = @bookid";
            MySqlParameter[] checkBookParams = { new MySqlParameter("@bookid", bookId) };
            DataTable bookData = db.ExecuteQuery(checkBookQuery, checkBookParams);

            if (bookData != null && bookData.Rows.Count > 0)
            {
                int currentAvailable = Convert.ToInt32(bookData.Rows[0]["bookava"]);
                //int currentRented = Convert.ToInt32(bookData.Rows[0]["bookrent"]); // Not directly used here, but good to know

                if (currentAvailable <= 0)
                {
                    MessageBox.Show("This book is currently not available for issue.", "Availability Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // --- TRANSACTION MANAGEMENT (Ensures atomicity of operations) ---
                MySqlTransaction transaction = null;
                try
                {
                    db.OpenConnection(); // Ensure connection is open for transaction
                    transaction = db.Connection.BeginTransaction(); // Begin a new transaction

                    // 1. Update book table: Decrease available quantity, increase rented quantity
                    string updateBookQuery = "UPDATE book SET bookava = bookava - 1, bookrent = bookrent + 1 WHERE id = @bookid";
                    MySqlParameter[] updateBookParams = { new MySqlParameter("@bookid", bookId) };
                    MySqlCommand updateBookCmd = new MySqlCommand(updateBookQuery, db.Connection, transaction);
                    updateBookCmd.Parameters.AddRange(updateBookParams);
                    updateBookCmd.ExecuteNonQuery();


                    // 2. Insert into issuebook table: Record the book issue
                    string issueQuery = "INSERT INTO issuebook (userid, issuename, issuebook, issuetype, issuedays, issuedate, issuereturn, fine) VALUES (@userid, @issuename, @issuebook, @issuetype, @issuedays, @issuedate, @issuereturn, @fine)";
                    MySqlParameter[] issueParams = new MySqlParameter[]
                    {
                        new MySqlParameter("@userid", userId),
                        new MySqlParameter("@issuename", issueName),
                        new MySqlParameter("@issuebook", issueBookName),
                        new MySqlParameter("@issuetype", issueType), // This is where "Teacher" or "Student" will be used
                        new MySqlParameter("@issuedays", issuedays),
                        new MySqlParameter("@issuedate", issueDate),
                        new MySqlParameter("@issuereturn", returnDate),
                        new MySqlParameter("@fine", 0) // No fine at issue time
                    };
                    MySqlCommand issueCmd = new MySqlCommand(issueQuery, db.Connection, transaction);
                    issueCmd.Parameters.AddRange(issueParams);
                    issueCmd.ExecuteNonQuery();

                    transaction.Commit(); // Commit the transaction if all operations are successful
                    MessageBox.Show("Book issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBooks(); // Refresh book list (availability might have changed)
                    LoadIssuedBooks(); // Refresh issued book list
                }
                catch (MySqlException ex)
                {
                    transaction?.Rollback(); // Rollback the transaction on any error
                    MessageBox.Show("Error issuing book: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    db.CloseConnection(); // Ensure connection is always closed
                }
            }
            else
            {
                MessageBox.Show("Book not found or invalid book selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handles text change in the search box for issued books
        private void txtSearchIssued_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchIssued.Text.Trim();
            // Search by user name or book name in the issued books list
            string query = "SELECT ib.id, u.name as UserName, b.bookname as BookName, ib.issuetype, ib.issuedays, ib.issuedate, ib.issuereturn, ib.fine FROM issuebook ib JOIN userdata u ON ib.userid = u.id JOIN book b ON ib.issuebook = b.bookname WHERE u.name LIKE @searchTerm OR b.bookname LIKE @searchTerm";
            MySqlParameter[] parameters = new MySqlParameter[]
            {
                new MySqlParameter("@searchTerm", $"%{searchTerm}%")
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            dgvIssuedBooks.DataSource = dt;
        }

        // Expose the connection from DBConnection for transaction management within this class
        // This property allows IssueBookForm to manage transactions using the underlying MySqlConnection
        public MySqlConnection Connection
        {
            get { return db.Connection; }
        }
    }
}
