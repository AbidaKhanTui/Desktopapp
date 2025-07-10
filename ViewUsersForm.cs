using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementApp
{
    public partial class ViewUsersForm : Form
    {
        private DBConnection db;

        public ViewUsersForm()
        {
            InitializeComponent();
            db = new DBConnection();
            LoadUsers();
        }

        private void LoadUsers()
        {
            string query = "SELECT id, name, email, type FROM userdata";
            DataTable dt = db.ExecuteQuery(query);
            dgvUsers.DataSource = dt;

            // Optional: Customize DataGridView columns
            dgvUsers.Columns["id"].HeaderText = "User ID";
            dgvUsers.Columns["name"].HeaderText = "Name";
            dgvUsers.Columns["email"].HeaderText = "Email";
            dgvUsers.Columns["type"].HeaderText = "Type";
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            string query = "SELECT id, name, email, type FROM userdata WHERE name LIKE @searchTerm OR email LIKE @searchTerm OR type LIKE @searchTerm";
            MySql.Data.MySqlClient.MySqlParameter[] parameters = new MySql.Data.MySqlClient.MySqlParameter[]
            {
                new MySql.Data.MySqlClient.MySqlParameter("@searchTerm", $"%{searchTerm}%")
            };
            DataTable dt = db.ExecuteQuery(query, parameters);
            dgvUsers.DataSource = dt;
        }
    }
}
