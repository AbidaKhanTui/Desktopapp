using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public partial class ViewRequestedBooksForm : Form
    {
        private DBConnection db;
        private DataTable allRequestsDataTable; // To hold all requested data for filtering

        public ViewRequestedBooksForm()
        {
            InitializeComponent();
            db = new DBConnection();
            LoadPendingRequests(); // Load pending requests when the form loads
        }

        // Method to load all pending book requests into the DataGridView
        private void LoadPendingRequests()
        {
            string query = @"SELECT 
                        rb.id AS RequestID,
                        u.name AS StudentName,
                        b.bookname AS BookTitle,
                        b.bookava AS AvailableCopies,
                        rb.requestdate AS RequestDate,
                        rb.requeststatus AS Status,
                        rb.bookid AS BookID_FK,
                        rb.userid AS UserID_FK
                     FROM requestbook rb
                     JOIN userdata u ON rb.userid = u.id
                     JOIN book b ON rb.bookid = b.id
                     WHERE rb.requeststatus = 'Pending'"; // Only show pending requests

            allRequestsDataTable = db.ExecuteQuery(query); // Load all data into a DataTable
            dgvRequestedBooks.DataSource = allRequestsDataTable; // Set data source initially

            // Hide foreign key columns if present
            if (dgvRequestedBooks.Columns.Contains("BookID_FK"))
            {
                dgvRequestedBooks.Columns["BookID_FK"].Visible = false;
            }
            if (dgvRequestedBooks.Columns.Contains("UserID_FK"))
            {
                dgvRequestedBooks.Columns["UserID_FK"].Visible = false;
            }

            // Safe header text update with null checks
            string[] columns = { "RequestID", "StudentName", "BookTitle", "AvailableCopies", "RequestDate", "Status" };
            string[] headers = { "Req. ID", "Student Name", "Book Title", "Available", "Request Date", "Status" };

            for (int i = 0; i < columns.Length; i++)
            {
                if (dgvRequestedBooks.Columns.Contains(columns[i]))
                    dgvRequestedBooks.Columns[columns[i]].HeaderText = headers[i];
            }

            dgvRequestedBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        // Event handler for the Approve Request button
        private void btnApproveRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequestedBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRequestedBooks.SelectedRows[0];
                int requestID = Convert.ToInt32(selectedRow.Cells["RequestID"].Value);
                int bookID = Convert.ToInt32(selectedRow.Cells["BookID_FK"].Value);
                int userID = Convert.ToInt32(selectedRow.Cells["UserID_FK"].Value);
                string bookName = selectedRow.Cells["BookTitle"].Value.ToString();
                int availableCopies = Convert.ToInt32(selectedRow.Cells["AvailableCopies"].Value);

                if (availableCopies <= 0)
                {
                    MessageBox.Show("This book is currently out of stock. Cannot approve request.", "Out of Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmResult = MessageBox.Show("Are you sure you want to approve this book request?", "Confirm Approval", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    // Start a transaction for atomicity
                    MySqlTransaction transaction = null;
                    try
                    {
                        if (db.OpenConnection())
                        {
                            transaction = db.Connection.BeginTransaction();

                            // 1. Update request status to 'Approved'
                            string updateRequestQuery = "UPDATE requestbook SET requeststatus = 'Approved' WHERE id = @requestID";
                            MySqlCommand updateRequestCmd = new MySqlCommand(updateRequestQuery, db.Connection, transaction);
                            updateRequestCmd.Parameters.AddWithValue("@requestID", requestID);
                            updateRequestCmd.ExecuteNonQuery();

                            // 2. Decrement available quantity and increment rented quantity in 'book' table
                            string updateBookQuery = "UPDATE book SET bookava = bookava - 1, bookrent = bookrent + 1 WHERE id = @bookID";
                            MySqlCommand updateBookCmd = new MySqlCommand(updateBookQuery, db.Connection, transaction);
                            updateBookCmd.Parameters.AddWithValue("@bookID", bookID);
                            updateBookCmd.ExecuteNonQuery();

                            // 3. Insert into 'issuebook' table
                            string issueBookQuery = "INSERT INTO issuebook (userid, issuebook, issuedays, issuedate, issuereturn, fine) VALUES (@userid, @bookname, @issuedays, @issuedate, @issuereturn, @fine)";
                            MySqlCommand issueBookCmd = new MySqlCommand(issueBookQuery, db.Connection, transaction);
                            issueBookCmd.Parameters.AddWithValue("@userid", userID);
                            issueBookCmd.Parameters.AddWithValue("@bookname", bookName); // Store book name for simplicity
                            issueBookCmd.Parameters.AddWithValue("@issuedays", 7); // Default to 7 days issue period
                            issueBookCmd.Parameters.AddWithValue("@issuedate", DateTime.Now.ToString("dd/MM/yyyy"));
                            issueBookCmd.Parameters.AddWithValue("@issuereturn", DateTime.Now.AddDays(7).ToString("dd/MM/yyyy")); // Return date 7 days from now
                            issueBookCmd.Parameters.AddWithValue("@fine", 0); // Initial fine is 0
                            issueBookCmd.ExecuteNonQuery();

                            transaction.Commit(); // Commit all changes if no errors
                            MessageBox.Show("Book request approved and book issued successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadPendingRequests(); // Refresh the list
                        }
                    }
                    catch (MySqlException ex)
                    {
                        transaction?.Rollback(); // Rollback on error
                        MessageBox.Show("Database error during approval: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        transaction?.Rollback(); // Rollback on error
                        MessageBox.Show("An unexpected error occurred during approval: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        db.CloseConnection(); // Ensure connection is closed
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a request to approve.", "No Request Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for the Reject Request button
        private void btnRejectRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequestedBooks.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRequestedBooks.SelectedRows[0];
                int requestID = Convert.ToInt32(selectedRow.Cells["RequestID"].Value);

                DialogResult confirmResult = MessageBox.Show("Are you sure you want to reject this book request?", "Confirm Rejection", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    string updateQuery = "UPDATE requestbook SET requeststatus = 'Rejected' WHERE id = @requestID";
                    MySqlParameter[] parameters = { new MySqlParameter("@requestID", requestID) };

                    int rowsAffected = db.ExecuteNonQuery(updateQuery, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book request rejected successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPendingRequests(); // Refresh the list
                    }
                    else
                    {
                        MessageBox.Show("Failed to reject book request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a request to reject.", "No Request Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Event handler for the Refresh List button
        private void btnRefreshList_Click(object sender, EventArgs e)
        {
            LoadPendingRequests(); // Reload pending requests
            txtSearchRequests.Clear(); // Clear search box when refreshing
        }

        // Event handler for the Back to Admin Dashboard button
        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            this.Close(); // Close this form
            // Optionally, you might explicitly show AdminDashboardForm if your application flow requires it.
            // Example: new AdminDashboardForm().Show();
        }

        // New: Event handler for the Search Requests textbox TextChanged event
        private void txtSearchRequests_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearchRequests.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                dgvRequestedBooks.DataSource = allRequestsDataTable; // Show all data if search box is empty
            }
            else
            {
                // Filter the DataTable based on Student Name or Book Title
                DataView dv = new DataView(allRequestsDataTable);
                // The filter string uses LIKE operator for partial matches
                dv.RowFilter = $"StudentName LIKE '%{searchTerm}%' OR BookTitle LIKE '%{searchTerm}%'";
                dgvRequestedBooks.DataSource = dv.ToTable();
            }
        }
    }
}
