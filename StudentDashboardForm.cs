using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public partial class StudentDashboardForm : Form
    {
        private DBConnection db;
        private int currentUserId; // To store the logged-in student's ID
        private DataTable allAvailableBooksDataTable; // To hold all available book data for filtering
        private DataTable allIssuedBooksDataTable;    // To hold all issued book data for filtering
        private DataTable allPendingRequestsDataTable; // To hold all pending request data for filtering

        // Constructor that accepts the student's ID upon successful login
        public StudentDashboardForm(int userId)
        {
            InitializeComponent();
            db = new DBConnection();
            currentUserId = userId; // Store the logged-in user's ID
            LoadUserDetails(userId); // Load student-specific details (like welcome message)
            LoadAvailableBooks();    // Load books available for all users
            LoadIssuedBooks(userId); // Load books currently issued to the current student
            LoadPendingRequests(userId); // Load pending book requests made by the current student
        }

        // Method to load the welcome message for the logged-in student
        private void LoadUserDetails(int userId)
        {
            string query = "SELECT name FROM userdata WHERE id = @id";
            MySqlParameter[] parameters = { new MySqlParameter("@id", userId) };
            object userName = db.ExecuteScalar(query, parameters);

            if (userName != null)
            {
                lblWelcomeUser.Text = $"Welcome, {userName.ToString()} (Student)!";
            }
            else
            {
                lblWelcomeUser.Text = "Welcome, Student!"; // Fallback if user name not found
            }
        }

        // Method to load all available books into dgvAvailableBooks DataGridView
        private void LoadAvailableBooks()
        {
            // Selects books that have at least one copy available (bookava > 0)
            string query = "SELECT id, bookname, bookdetail, bookaudor, bookpub, branch, bookprice, bookquantity, bookava, bookrent FROM book WHERE bookava > 0";
            allAvailableBooksDataTable = db.ExecuteQuery(query); // Load all data into a DataTable
            dgvAvailableBooks.DataSource = allAvailableBooksDataTable; // Set DataGridView's data source

            // Customize DataGridView column headers for available books
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

        // Method to load books issued to the current student into dgvIssuedBooks DataGridView
        private void LoadIssuedBooks(int userId)
        {
            // Joins issuebook, userdata, and book tables to get comprehensive information
            // Filters results to show only books issued to the current logged-in user
            // It assumes 'issuebook' table has records that haven't been "returned" yet (e.g., fine is 0 or no explicit return status)
            string query = "SELECT ib.id AS IssueID, u.name as UserName, b.bookname as BookName, ib.issuedays, ib.issuedate, ib.issuereturn, ib.fine, b.id AS BookID_FK_Issued " +
                           "FROM issuebook ib JOIN userdata u ON ib.userid = u.id JOIN book b ON ib.issuebook = b.bookname " + // Assuming bookname is stored in issuebook
                           "WHERE ib.userid = @userid AND ib.fine = 0"; // Filter by user ID and assuming fine=0 means not returned

            MySqlParameter[] parameters = { new MySqlParameter("@userid", userId) };
            allIssuedBooksDataTable = db.ExecuteQuery(query, parameters); // Load all data into a DataTable

            // Add a new column for 'Days Left' if it doesn't exist
            if (!allIssuedBooksDataTable.Columns.Contains("DaysLeft"))
            {
                allIssuedBooksDataTable.Columns.Add("DaysLeft", typeof(string));
            }

            // Calculate "Days Left" for each issued book
            foreach (DataRow row in allIssuedBooksDataTable.Rows)
            {
                if (DateTime.TryParseExact(row["issuereturn"].ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime returnDate))
                {
                    TimeSpan timeRemaining = returnDate - DateTime.Now.Date;
                    if (timeRemaining.TotalDays >= 0)
                    {
                        row["DaysLeft"] = $"{(int)timeRemaining.TotalDays} days";
                    }
                    else
                    {
                        row["DaysLeft"] = $"Overdue by {Math.Abs((int)timeRemaining.TotalDays)} days";
                    }
                }
                else
                {
                    row["DaysLeft"] = "N/A"; // Not Available if date parsing fails
                }
            }

            dgvIssuedBooks.DataSource = allIssuedBooksDataTable; // Set DataGridView's data source

            // Customize DataGridView column headers for issued books
            dgvIssuedBooks.Columns["IssueID"].HeaderText = "Issue ID";
            dgvIssuedBooks.Columns["UserName"].HeaderText = "User Name";
            dgvIssuedBooks.Columns["BookName"].HeaderText = "Book Name";
            dgvIssuedBooks.Columns["issuedays"].HeaderText = "Issued Days";
            dgvIssuedBooks.Columns["issuedate"].HeaderText = "Issue Date";
            dgvIssuedBooks.Columns["issuereturn"].HeaderText = "Return Date";
            dgvIssuedBooks.Columns["fine"].HeaderText = "Fine";
            dgvIssuedBooks.Columns["DaysLeft"].HeaderText = "Days Left"; // Header for calculated column
            dgvIssuedBooks.Columns["BookID_FK_Issued"].Visible = false; // Hide FK
            dgvIssuedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Method to load pending book requests made by the current student
        private void LoadPendingRequests(int userId)
        {
            string query = "SELECT rb.id AS RequestID, b.bookname as RequestedBook, rb.requeststatus, rb.requestdate, rb.bookid AS BookID_FK_Pending FROM requestbook rb JOIN book b ON rb.bookid = b.id WHERE rb.userid = @userid";
            MySqlParameter[] parameters = { new MySqlParameter("@userid", userId) };
            allPendingRequestsDataTable = db.ExecuteQuery(query, parameters); // Load all data into a DataTable
            dgvPendingRequests.DataSource = allPendingRequestsDataTable; // Set DataGridView's data source

            // Add null checks for columns before accessing their properties to prevent NullReferenceException.
            if (dgvPendingRequests.Columns.Contains("BookID_FK_Pending"))
            {
                dgvPendingRequests.Columns["BookID_FK_Pending"].Visible = false; // Hide FK
            }

            // Customize DataGridView columns for pending requests
            dgvPendingRequests.Columns["RequestID"].HeaderText = "Request ID";
            dgvPendingRequests.Columns["RequestedBook"].HeaderText = "Book Title";
            dgvPendingRequests.Columns["requeststatus"].HeaderText = "Status";
            dgvPendingRequests.Columns["requestdate"].HeaderText = "Request Date";
            dgvPendingRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // Event handler for Request Selected Book button click
        // This method handles the logic for a student to request a book.
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
                    LoadPendingRequests(currentUserId); // Refresh pending requests list
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

        // Event handler for Reissue Book button click
        private void btnReissueBook_Click(object sender, EventArgs e)
        {
            if (dgvIssuedBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvIssuedBooks.SelectedRows[0];
                int issueID = Convert.ToInt32(selectedRow.Cells["IssueID"].Value);
                string bookName = selectedRow.Cells["BookName"].Value.ToString();
                string currentReturnDateStr = selectedRow.Cells["issuereturn"].Value.ToString();

                // Parse current return date
                if (!DateTime.TryParseExact(currentReturnDateStr, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out DateTime currentReturnDate))
                {
                    MessageBox.Show("Invalid return date format for selected book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the book is already overdue
                if (DateTime.Now.Date > currentReturnDate.Date)
                {
                    MessageBox.Show("This book is overdue. Please return the book first.", "Overdue Book", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmResult = MessageBox.Show($"Are you sure you want to reissue '{bookName}' for another 7 days?", "Confirm Reissue", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // Calculate new return date (e.g., extend by 7 days from current date or current return date)
                    // For simplicity, let's extend from the *current return date*.
                    DateTime newReturnDate = currentReturnDate.AddDays(7);

                    string updateQuery = "UPDATE issuebook SET issuereturn = @newReturnDate, issuedays = issuedays + 7 WHERE id = @issueID";
                    MySqlParameter[] parameters = {
                        new MySqlParameter("@newReturnDate", newReturnDate.ToString("dd/MM/yyyy")),
                        new MySqlParameter("@issueID", issueID)
                    };

                    int rowsAffected = db.ExecuteNonQuery(updateQuery, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Book '{bookName}' reissued successfully! New return date: {newReturnDate.ToString("dd/MM/yyyy")}", "Reissue Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadIssuedBooks(currentUserId); // Refresh issued books list
                    }
                    else
                    {
                        MessageBox.Show("Failed to reissue book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an issued book to reissue.", "No Book Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for Refresh Lists button click
        private void btnRefreshLists_Click(object sender, EventArgs e)
        {
            LoadAvailableBooks();    // Reload available books
            LoadIssuedBooks(currentUserId); // Reload issued books for the current student
            LoadPendingRequests(currentUserId); // Reload pending requests for the current student
            txtSearchAvailableBooks.Clear(); // Clear search boxes
            txtSearchIssuedBooks.Clear();
            txtSearchPendingRequests.Clear();
        }

        // Event handler for Logout button click
        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Close the current dashboard and open the login form
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        // Event handler for searching available books
        private void txtSearchAvailableBooks_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchAvailableBooks.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                dgvAvailableBooks.DataSource = allAvailableBooksDataTable;
            }
            else
            {
                DataView dv = new DataView(allAvailableBooksDataTable);
                dv.RowFilter = $"bookname LIKE '%{searchTerm}%' OR bookaudor LIKE '%{searchTerm}%' OR branch LIKE '%{searchTerm}%'";
                dgvAvailableBooks.DataSource = dv.ToTable();
            }
        }

        // Event handler for searching issued books
        private void txtSearchIssuedBooks_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchIssuedBooks.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                dgvIssuedBooks.DataSource = allIssuedBooksDataTable;
            }
            else
            {
                DataView dv = new DataView(allIssuedBooksDataTable);
                dv.RowFilter = $"BookName LIKE '%{searchTerm}%' OR UserName LIKE '%{searchTerm}%'";
                dgvIssuedBooks.DataSource = dv.ToTable();
            }
        }

        // Event handler for searching pending requests
        private void txtSearchPendingRequests_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchPendingRequests.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                dgvPendingRequests.DataSource = allPendingRequestsDataTable;
            }
            else
            {
                DataView dv = new DataView(allPendingRequestsDataTable);
                dv.RowFilter = $"RequestedBook LIKE '%{searchTerm}%' OR StudentName LIKE '%{searchTerm}%' OR Status LIKE '%{searchTerm}%'";
                dgvPendingRequests.DataSource = dv.ToTable();
            }
        }
    }
}
