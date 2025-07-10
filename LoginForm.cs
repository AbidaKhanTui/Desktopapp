using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public partial class LoginForm : Form
    {
        private DBConnection db;

        public LoginForm()
        {
            InitializeComponent();
            db = new DBConnection();
            // Set default selected item for cmbUserRole on form load.
            // This ensures that the ComboBox has an item selected from the start.
            if (cmbUserRole.Items.Count > 0 && cmbUserRole.SelectedIndex == -1)
            {
                cmbUserRole.SelectedIndex = 0; // Default to the first item (e.g., "Student")
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            // Safely get the selected role from the ComboBox.
            // If nothing is selected, it will be null, and the validation below will catch it.
            string selectedRole = cmbUserRole.SelectedItem?.ToString();

            // Basic input validation: Check if email, password are entered.
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate if a role has been selected from the ComboBox.
            if (string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please select your role (Student, Admin, or User).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable loginDt = null;
            string query = "";
            MySqlParameter[] parameters = null;
            int userId = -1; // Initialize userId, will be updated if login is successful.

            // Logic to handle Admin login first.
            // If the user selected "Admin" role in the ComboBox:
            if (selectedRole == "Admin")
            {
                // Query the 'admin' table for admin credentials.
                // Assuming 'admin' table has 'id', 'email', 'pass' columns.
                query = "SELECT id, email, pass FROM admin WHERE email = @email AND pass = @pass";
                parameters = new MySqlParameter[] {
                    new MySqlParameter("@email", email),
                    new MySqlParameter("@pass", password) // Parameter name changed to @pass
                };
                loginDt = db.ExecuteQuery(query, parameters); // Execute query to get admin data.

                if (loginDt != null && loginDt.Rows.Count > 0)
                {
                    userId = Convert.ToInt32(loginDt.Rows[0]["id"]); // Get the admin's ID.
                    MessageBox.Show("Admin login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Open the Admin Dashboard.
                    AdminDashboardForm adminDashboard = new AdminDashboardForm();
                    adminDashboard.Show();
                    this.Hide(); // Hide the current login form.
                    return; // Exit the method after successful admin login.
                }
            }
            else // Logic to handle Student or general User login.
            {
                // If the user selected "Student" or "User" role in the ComboBox:
                // Query the 'userdata' table, filtering by email, password, AND selected user type.
                // Assuming 'userdata' table now also uses 'pass' column for password.
                query = "SELECT id, email, pass, type FROM userdata WHERE email = @email AND pass = @pass AND type = @type"; // Column name changed to 'pass'
                parameters = new MySqlParameter[] {
                    new MySqlParameter("@email", email),
                    new MySqlParameter("@pass", password), // Parameter name changed to @pass
                    new MySqlParameter("@type", selectedRole) // Pass the selected role as a parameter to match in DB.
                };
                loginDt = db.ExecuteQuery(query, parameters); // Execute query to get user data.

                if (loginDt != null && loginDt.Rows.Count > 0)
                {
                    userId = Convert.ToInt32(loginDt.Rows[0]["id"]); // Get the user's ID.
                    // The 'type' column from the database row is implicitly checked by the query's WHERE clause,
                    // ensuring the user's actual type matches the selected role.

                    MessageBox.Show($"{selectedRole} login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigate to the appropriate dashboard based on the role successfully logged in with.
                    if (selectedRole == "Student")
                    {
                        // Open the Student Dashboard, passing the logged-in user's ID.
                        StudentDashboardForm studentDashboard = new StudentDashboardForm(userId);
                        studentDashboard.Show();
                    }
                    else // This covers the "User" role
                    {
                        // Open the general User Dashboard, passing the logged-in user's ID.
                        UserDashboardForm userDashboard = new UserDashboardForm(userId);
                        userDashboard.Show();
                    }
                    this.Hide(); // Hide the current login form.
                    return; // Exit the method as login is successful.
                }
            }

            // If execution reaches here, it means neither admin nor user/student login was successful
            MessageBox.Show("Invalid email, password, or selected role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Event handler for the Register button. Placeholder for future implementation.
        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Open the RegistrationForm
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show(); // Show the registration form
            this.Hide();    // Hide the current login form
        }

        // Event handler for the LoginForm_Load event.
        // Can be used for any initial setup when the form loads, e.g., setting focus to a textbox.
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Example: txtEmail.Focus();
        }
    }
}
