namespace LibraryManagementApp
{
    partial class UserDashboardForm
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
            this.lblWelcomeUser = new System.Windows.Forms.Label();
            this.dgvAvailableBooks = new System.Windows.Forms.DataGridView();
            this.lblAvailableBooks = new System.Windows.Forms.Label();
            this.btnRequestBook = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRefreshBooks = new System.Windows.Forms.Button();
            this.lblIssuedBooks = new System.Windows.Forms.Label();
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
            this.SuspendLayout();
            //
            // lblWelcomeUser
            //
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(20, 20);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(155, 30);
            this.lblWelcomeUser.TabIndex = 0;
            this.lblWelcomeUser.Text = "Welcome, User!";
            //
            // dgvAvailableBooks
            //
            this.dgvAvailableBooks.AllowUserToAddRows = false;
            this.dgvAvailableBooks.AllowUserToDeleteRows = false;
            this.dgvAvailableBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableBooks.Location = new System.Drawing.Point(25, 100);
            this.dgvAvailableBooks.MultiSelect = false;
            this.dgvAvailableBooks.Name = "dgvAvailableBooks";
            this.dgvAvailableBooks.ReadOnly = true;
            this.dgvAvailableBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAvailableBooks.Size = new System.Drawing.Size(750, 200);
            this.dgvAvailableBooks.TabIndex = 1;
            //
            // lblAvailableBooks
            //
            this.lblAvailableBooks.AutoSize = true;
            this.lblAvailableBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableBooks.Location = new System.Drawing.Point(25, 70);
            this.lblAvailableBooks.Name = "lblAvailableBooks";
            this.lblAvailableBooks.Size = new System.Drawing.Size(134, 21);
            this.lblAvailableBooks.TabIndex = 2;
            this.lblAvailableBooks.Text = "Available Books:";
            //
            // btnRequestBook
            //
            this.btnRequestBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestBook.Location = new System.Drawing.Point(25, 315);
            this.btnRequestBook.Name = "btnRequestBook";
            this.btnRequestBook.Size = new System.Drawing.Size(150, 40);
            this.btnRequestBook.TabIndex = 3;
            this.btnRequestBook.Text = "Request Selected Book";
            this.btnRequestBook.UseVisualStyleBackColor = true;
            this.btnRequestBook.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnRequestBook.Click += new System.EventHandler(this.btnRequestBook_Click);
            //
            // btnLogout
            //
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(675, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // btnRefreshBooks
            //
            this.btnRefreshBooks.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshBooks.Location = new System.Drawing.Point(190, 315);
            this.btnRefreshBooks.Name = "btnRefreshBooks";
            this.btnRefreshBooks.Size = new System.Drawing.Size(150, 40);
            this.btnRefreshBooks.TabIndex = 5;
            this.btnRefreshBooks.Text = "Refresh Lists";
            this.btnRefreshBooks.UseVisualStyleBackColor = true;
            this.btnRefreshBooks.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnRefreshBooks.Click += new System.EventHandler(this.btnRefreshBooks_Click);
            //
            // lblIssuedBooks
            //
            this.lblIssuedBooks.AutoSize = true;
            this.lblIssuedBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedBooks.Location = new System.Drawing.Point(25, 380);
            this.lblIssuedBooks.Name = "lblIssuedBooks";
            this.lblIssuedBooks.Size = new System.Drawing.Size(155, 21);
            this.lblIssuedBooks.TabIndex = 6;
            this.lblIssuedBooks.Text = "Your Issued Books:";
            //
            // dgvIssuedBooks
            //
            this.dgvIssuedBooks.AllowUserToAddRows = false;
            this.dgvIssuedBooks.AllowUserToDeleteRows = false;
            this.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedBooks.Location = new System.Drawing.Point(25, 410);
            this.dgvIssuedBooks.MultiSelect = false;
            this.dgvIssuedBooks.Name = "dgvIssuedBooks";
            this.dgvIssuedBooks.ReadOnly = true;
            this.dgvIssuedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssuedBooks.Size = new System.Drawing.Size(750, 200);
            this.dgvIssuedBooks.TabIndex = 7;
            //
            // UserDashboardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.dgvIssuedBooks);
            this.Controls.Add(this.lblIssuedBooks);
            this.Controls.Add(this.btnRefreshBooks);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRequestBook);
            this.Controls.Add(this.lblAvailableBooks);
            this.Controls.Add(this.dgvAvailableBooks);
            this.Controls.Add(this.lblWelcomeUser);
            this.BackColor = System.Drawing.Color.Yellow; // Set form background to Yellow
            this.Name = "UserDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard - Library Management";
            // Removed: this.Load += new System.EventHandler(this.UserDashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.DataGridView dgvAvailableBooks;
        private System.Windows.Forms.Label lblAvailableBooks;
        private System.Windows.Forms.Button btnRequestBook;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefreshBooks;
        private System.Windows.Forms.Label lblIssuedBooks;
        private System.Windows.Forms.DataGridView dgvIssuedBooks;
    }
}
