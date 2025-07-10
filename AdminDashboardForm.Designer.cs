namespace LibraryManagementApp
{
    partial class AdminDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcomeAdmin = new System.Windows.Forms.Label();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnViewUsers = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewRequests = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // lblWelcomeAdmin
            //
            this.lblWelcomeAdmin.AutoSize = true;
            this.lblWelcomeAdmin.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeAdmin.Location = new System.Drawing.Point(120, 30);
            this.lblWelcomeAdmin.Name = "lblWelcomeAdmin";
            this.lblWelcomeAdmin.Size = new System.Drawing.Size(232, 30);
            this.lblWelcomeAdmin.TabIndex = 0;
            this.lblWelcomeAdmin.Text = "Welcome, Administrator!";
            //
            // btnManageBooks
            //
            this.btnManageBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBooks.Location = new System.Drawing.Point(50, 90);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(180, 50);
            this.btnManageBooks.TabIndex = 1;
            this.btnManageBooks.Text = "Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.BackColor = System.Drawing.Color.FloralWhite; // Set button color to Off-white
            this.btnManageBooks.Click += new System.EventHandler(this.btnManageBooks_Click);
            //
            // btnViewUsers
            //
            this.btnViewUsers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewUsers.Location = new System.Drawing.Point(260, 90);
            this.btnViewUsers.Name = "btnViewUsers";
            this.btnViewUsers.Size = new System.Drawing.Size(180, 50);
            this.btnViewUsers.TabIndex = 2;
            this.btnViewUsers.Text = "View Users";
            this.btnViewUsers.UseVisualStyleBackColor = true;
            this.btnViewUsers.BackColor = System.Drawing.Color.FloralWhite; // Set button color to Off-white
            this.btnViewUsers.Click += new System.EventHandler(this.btnViewUsers_Click);
            //
            // btnIssueBook
            //
            this.btnIssueBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.Location = new System.Drawing.Point(50, 160);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(180, 50);
            this.btnIssueBook.TabIndex = 3;
            this.btnIssueBook.Text = "Issue Book";
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.BackColor = System.Drawing.Color.FloralWhite; // Set button color to Off-white
            this.btnIssueBook.Click += new System.EventHandler(this.btnIssueBook_Click);
            //
            // btnReturnBook
            //
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Location = new System.Drawing.Point(260, 160);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(180, 50);
            this.btnReturnBook.TabIndex = 4;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.BackColor = System.Drawing.Color.FloralWhite; // Set button color to Off-white
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            //
            // btnLogout
            //
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(160, 300);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(170, 45);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.BackColor = System.Drawing.Color.FloralWhite; // Set button color to Off-white
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // btnViewRequests
            //
            this.btnViewRequests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewRequests.Location = new System.Drawing.Point(160, 230);
            this.btnViewRequests.Name = "btnViewRequests";
            this.btnViewRequests.Size = new System.Drawing.Size(180, 50);
            this.btnViewRequests.TabIndex = 6;
            this.btnViewRequests.Text = "View Book Requests";
            this.btnViewRequests.UseVisualStyleBackColor = true;
            this.btnViewRequests.BackColor = System.Drawing.Color.FloralWhite; // Set button color to Off-white
            this.btnViewRequests.Click += new System.EventHandler(this.btnViewRequests_Click);
            //
            // AdminDashboardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.btnViewRequests);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnIssueBook);
            this.Controls.Add(this.btnViewUsers);
            this.Controls.Add(this.btnManageBooks);
            this.Controls.Add(this.lblWelcomeAdmin);
            this.BackColor = System.Drawing.Color.Yellow; // Set form background to Yellow
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard - Library Management";
            this.Load += new System.EventHandler(this.AdminDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeAdmin;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnViewUsers;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewRequests;
    }
}
