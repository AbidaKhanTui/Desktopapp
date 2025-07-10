using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

// using System.Data.SqlClient; // This line is removed as it's not needed for MySQL
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public class DBConnection
    {
        private MySqlConnection connection;
        private string connectionString;

        // Public property to allow other classes to access the MySqlConnection object for transactions
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        public DBConnection()
        {
            // IMPORTANT: Replace 'your_database_name', 'your_username', 'your_password' with your actual MySQL credentials.
            // If MySQL is running on a different port, add ;Port=your_port_number;
            // Example for XAMPP/WAMP default: Uid=root;Pwd=;
            connectionString = "Server=localhost;Database=test;Uid=root;Pwd=;";
            connection = new MySqlConnection(connectionString); // Corrected: Removed extra 'new' keyword
        }

        // Method to open the database connection
        public bool OpenConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    Console.WriteLine("Database connection opened."); // For debugging
                }
                return true;
            }
            catch (MySqlException ex)
            {
                // Handle specific MySQL errors
                switch (ex.Number)
                {
                    case 0: // Cannot connect to server
                        MessageBox.Show("Cannot connect to server. Please ensure MySQL server is running and connection details are correct.\n" + ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1045: // Invalid username/password
                        MessageBox.Show("Invalid username or password for database. Please check your credentials.\n" + ex.Message, "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case 1049: // Unknown database
                        MessageBox.Show("Unknown database. Please ensure 'library_managment' database exists.\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        MessageBox.Show("An unexpected database error occurred: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
                return false;
            }
            catch (Exception ex) // Catch any other general exceptions
            {
                MessageBox.Show("An unexpected error occurred while trying to open the database connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to close the database connection
        public bool CloseConnection()
        {
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    Console.WriteLine("Database connection closed."); // For debugging
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error closing database connection: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred while trying to close the database connection: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        // Method to execute a non-query (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string query, MySqlParameter[] parameters = null)
        {
            int rowsAffected = 0;
            // The OpenConnection() call handles error display for connection issues
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    rowsAffected = cmd.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error executing non-query: " + ex.Message, "Database Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during non-query execution: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection(); // Ensure connection is closed after operation
                }
            }
            return rowsAffected;
        }

        // Method to execute a scalar query (e.g., COUNT, SUM, or single value retrieval)
        public object ExecuteScalar(string query, MySqlParameter[] parameters = null)
        {
            object result = null;
            // The OpenConnection() call handles error display for connection issues
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    result = cmd.ExecuteScalar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error executing scalar query: " + ex.Message, "Database Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during scalar query execution: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection(); // Ensure connection is closed after operation
                }
            }
            return result;
        }

        // Method to execute a query and return data in a DataTable
        public DataTable ExecuteQuery(string query, MySqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            // The OpenConnection() call handles error display for connection issues
            if (OpenConnection())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error executing query: " + ex.Message, "Database Query Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An unexpected error occurred during query execution: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    CloseConnection(); // Ensure connection is closed after operation
                }
            }
            return dt;
        }
    }
}
