using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public partial class UserDashboardForm : Form
    {
        private DBConnection db;
        private int currentUserId; // To store the logged-in user's ID

        // Constructor that accepts the user's ID upon login
        public UserDashboardForm(int userId)
        {
            InitializeComponent();
            db = new DBConnection();
            currentUserId = userId; // Store the user ID
            LoadUserDetails(userId); // Load user specific details (like welcome message)
            LoadAvailableBooks(); // Load books available for all users
            LoadIssuedBooks(userId); // Load books issued to the current user
        }

        // Method to load welcome message for the logged-in user
        private void LoadUserDetails(int userId)
        {
            string query = "SELECT name FROM userdata WHERE id = @id";
            MySqlParameter[] parameters = { new MySqlParameter("@id", userId) };
            object userName = db.ExecuteScalar(query, parameters);

            if (userName != null)
            {
                lblWelcomeUser.Text = $"Welcome, {userName.ToString()}!";
            }
            else
            {
                lblWelcomeUser.Text = "Welcome, User!"; // Fallback if user name not found
            }
        }

        // Method to load all available books into dgvAvailableBooks
        private void LoadAvailableBooks()
        {
            // Selects books that have at least one copy available (bookava > 0)
            string query = "SELECT id, bookname, bookdetail, bookaudor, bookpub, branch, bookprice, bookquantity, bookava, bookrent FROM book WHERE bookava > 0";
            DataTable dt = db.ExecuteQuery(query);
            dgvAvailableBooks.DataSource = dt;

            // Customize DataGridView columns for available books
            dgvAvailableBooks.Columns["id"].HeaderText = "Book ID";
            dgvAvailableBooks.Columns["bookname"].HeaderText = "Title";
            dgvAvailableBooks.Columns["bookaudor"].HeaderText = "Author";
            dgvAvailableBooks.Columns["bookpub"].HeaderText = "Publisher";
            dgvAvailableBooks.Columns["branch"].HeaderText = "Branch";
            dgvAvailableBooks.Columns["bookprice"].HeaderText = "Price";
            dgvAvailableBooks.Columns["bookquantity"].HeaderText = "Total Qty";
            dgvAvailableBooks.Columns["bookava"].HeaderText = "Available";
            dgvAvailableBooks.Columns["bookrent"].HeaderText = "Rented";
            dgvAvailableBooks.Columns["bookdetail"].Visible = false; // Hide details by default for brevity
            dgvAvailableBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Method to load books issued to the current user into dgvIssuedBooks
        private void LoadIssuedBooks(int userId)
        {
            // Joins issuebook, userdata, and book tables to get comprehensive information
            // Filters results to show only books issued to the current logged-in user
            string query = "SELECT ib.id, u.name as UserName, b.bookname as BookName, ib.issuetype, ib.issuedays, ib.issuedate, ib.issuereturn, ib.fine FROM issuebook ib JOIN userdata u ON ib.userid = u.id JOIN book b ON ib.issuebook = b.bookname WHERE ib.userid = @userid";
            MySqlParameter[] parameters = { new MySqlParameter("@userid", userId) };
            DataTable dtIssued = db.ExecuteQuery(query, parameters); // This is likely line 81 or near it
            dgvIssuedBooks.DataSource = dtIssued;

            // Customize DataGridView column headers for issued books
            dgvIssuedBooks.Columns["id"].HeaderText = "Issue ID";
            dgvIssuedBooks.Columns["UserName"].HeaderText = "User Name";
            dgvIssuedBooks.Columns["BookName"].HeaderText = "Book Name";
            dgvIssuedBooks.Columns["issuetype"].HeaderText = "User Type";
            dgvIssuedBooks.Columns["issuedays"].HeaderText = "Days Issued";
            dgvIssuedBooks.Columns["issuedate"].HeaderText = "Issue Date";
            dgvIssuedBooks.Columns["issuereturn"].HeaderText = "Return Date";
            dgvIssuedBooks.Columns["fine"].HeaderText = "Fine";
            dgvIssuedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Event handler for Request Selected Book button click
        private void btnRequestBook_Click(object sender, EventArgs e)
        {
            if (dgvAvailableBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvAvailableBooks.SelectedRows[0];
                int bookId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                string bookName = selectedRow.Cells["bookname"].Value.ToString();

                // Check if the user has already requested this book and it's pending
                string checkQuery = "SELECT COUNT(*) FROM requestbook WHERE userid = @userid AND bookid = @bookid AND requeststatus = 'Pending'";
                MySqlParameter[] checkParams = {
                    new MySqlParameter("@userid", currentUserId),
                    new MySqlParameter("@bookid", bookId)
                };
                long existingRequests = (long)db.ExecuteScalar(checkQuery, checkParams);

                if (existingRequests > 0)
                {
                    MessageBox.Show("You have already requested this book and it's pending approval.", "Already Requested", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Insert the request into the requestbook table
                string requestQuery = "INSERT INTO requestbook (bookid, bookname, userid, requeststatus, requestdate) VALUES (@bookid, @bookname, @userid, @requeststatus, @requestdate)";
                MySqlParameter[] requestParams = {
                    new MySqlParameter("@bookid", bookId),
                    new MySqlParameter("@bookname", bookName),
                    new MySqlParameter("@userid", currentUserId),
                    new MySqlParameter("@requeststatus", "Pending"), // Initial status
                    new MySqlParameter("@requestdate", DateTime.Now.ToString("dd/MM/yyyy"))
                };

                int rowsAffected = db.ExecuteNonQuery(requestQuery, requestParams);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book request sent successfully! Please wait for admin approval.", "Request Sent", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to send book request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to request.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for Logout button click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close the current dashboard and open the login form
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        // Event handler for Refresh Books button click
        private void btnRefreshBooks_Click(object sender, EventArgs e)
        {
            LoadAvailableBooks(); // Reload available books
            LoadIssuedBooks(currentUserId); // Reload issued books for the current user
        }
    }
}
