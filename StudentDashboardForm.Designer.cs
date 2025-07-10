namespace LibraryManagementApp
{
    partial class StudentDashboardForm
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRefreshLists = new System.Windows.Forms.Button();
            // Available Books Section
            this.lblAvailableBooks = new System.Windows.Forms.Label();
            this.txtSearchAvailableBooks = new System.Windows.Forms.TextBox();
            this.dgvAvailableBooks = new System.Windows.Forms.DataGridView();
            this.btnRequestBook = new System.Windows.Forms.Button();
            // Issued Books Section
            this.lblIssuedBooks = new System.Windows.Forms.Label();
            this.txtSearchIssuedBooks = new System.Windows.Forms.TextBox();
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.btnReissueBook = new System.Windows.Forms.Button(); // New Reissue Button
            // Pending Requests Section
            this.lblPendingRequests = new System.Windows.Forms.Label();
            this.txtSearchPendingRequests = new System.Windows.Forms.TextBox();
            this.dgvPendingRequests = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingRequests)).BeginInit();
            this.SuspendLayout();
            //
            // lblWelcomeUser
            //
            this.lblWelcomeUser.AutoSize = true;
            this.lblWelcomeUser.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeUser.Location = new System.Drawing.Point(20, 20);
            this.lblWelcomeUser.Name = "lblWelcomeUser";
            this.lblWelcomeUser.Size = new System.Drawing.Size(193, 30);
            this.lblWelcomeUser.TabIndex = 0;
            this.lblWelcomeUser.Text = "Welcome, Student!";
            //
            // btnLogout
            //
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(700, 20);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            //
            // btnRefreshLists
            //
            this.btnRefreshLists.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshLists.Location = new System.Drawing.Point(580, 20);
            this.btnRefreshLists.Name = "btnRefreshLists";
            this.btnRefreshLists.Size = new System.Drawing.Size(100, 35);
            this.btnRefreshLists.TabIndex = 2;
            this.btnRefreshLists.Text = "Refresh Lists";
            this.btnRefreshLists.UseVisualStyleBackColor = true;
            this.btnRefreshLists.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnRefreshLists.Click += new System.EventHandler(this.btnRefreshLists_Click);
            //
            // lblAvailableBooks
            //
            this.lblAvailableBooks.AutoSize = true;
            this.lblAvailableBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableBooks.Location = new System.Drawing.Point(25, 70);
            this.lblAvailableBooks.Name = "lblAvailableBooks";
            this.lblAvailableBooks.Size = new System.Drawing.Size(134, 21);
            this.lblAvailableBooks.TabIndex = 3;
            this.lblAvailableBooks.Text = "Available Books:";
            //
            // txtSearchAvailableBooks
            //
            this.txtSearchAvailableBooks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAvailableBooks.Location = new System.Drawing.Point(165, 68);
            this.txtSearchAvailableBooks.Name = "txtSearchAvailableBooks";
            this.txtSearchAvailableBooks.Size = new System.Drawing.Size(200, 25);
            this.txtSearchAvailableBooks.TabIndex = 4;
            this.txtSearchAvailableBooks.TextChanged += new System.EventHandler(this.txtSearchAvailableBooks_TextChanged);
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
            this.dgvAvailableBooks.Size = new System.Drawing.Size(775, 150);
            this.dgvAvailableBooks.TabIndex = 5;
            //
            // btnRequestBook
            //
            this.btnRequestBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestBook.Location = new System.Drawing.Point(25, 260);
            this.btnRequestBook.Name = "btnRequestBook";
            this.btnRequestBook.Size = new System.Drawing.Size(160, 40);
            this.btnRequestBook.TabIndex = 6;
            this.btnRequestBook.Text = "Request Selected Book";
            this.btnRequestBook.UseVisualStyleBackColor = true;
            this.btnRequestBook.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnRequestBook.Click += new System.EventHandler(this.btnRequestBook_Click);
            //
            // lblIssuedBooks
            //
            this.lblIssuedBooks.AutoSize = true;
            this.lblIssuedBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedBooks.Location = new System.Drawing.Point(25, 315);
            this.lblIssuedBooks.Name = "lblIssuedBooks";
            this.lblIssuedBooks.Size = new System.Drawing.Size(155, 21);
            this.lblIssuedBooks.TabIndex = 7;
            this.lblIssuedBooks.Text = "Your Issued Books:";
            //
            // txtSearchIssuedBooks
            //
            this.txtSearchIssuedBooks.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchIssuedBooks.Location = new System.Drawing.Point(185, 313);
            this.txtSearchIssuedBooks.Name = "txtSearchIssuedBooks";
            this.txtSearchIssuedBooks.Size = new System.Drawing.Size(200, 25);
            this.txtSearchIssuedBooks.TabIndex = 8;
            this.txtSearchIssuedBooks.TextChanged += new System.EventHandler(this.txtSearchIssuedBooks_TextChanged);
            //
            // dgvIssuedBooks
            //
            this.dgvIssuedBooks.AllowUserToAddRows = false;
            this.dgvIssuedBooks.AllowUserToDeleteRows = false;
            this.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedBooks.Location = new System.Drawing.Point(25, 345);
            this.dgvIssuedBooks.MultiSelect = false;
            this.dgvIssuedBooks.Name = "dgvIssuedBooks";
            this.dgvIssuedBooks.ReadOnly = true;
            this.dgvIssuedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssuedBooks.Size = new System.Drawing.Size(775, 150);
            this.dgvIssuedBooks.TabIndex = 9;
            //
            // btnReissueBook
            //
            this.btnReissueBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReissueBook.Location = new System.Drawing.Point(25, 505);
            this.btnReissueBook.Name = "btnReissueBook";
            this.btnReissueBook.Size = new System.Drawing.Size(160, 40);
            this.btnReissueBook.TabIndex = 10;
            this.btnReissueBook.Text = "Reissue Selected Book";
            this.btnReissueBook.UseVisualStyleBackColor = true;
            this.btnReissueBook.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnReissueBook.Click += new System.EventHandler(this.btnReissueBook_Click);
            //
            // lblPendingRequests
            //
            this.lblPendingRequests.AutoSize = true;
            this.lblPendingRequests.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingRequests.Location = new System.Drawing.Point(25, 560);
            this.lblPendingRequests.Name = "lblPendingRequests";
            this.lblPendingRequests.Size = new System.Drawing.Size(147, 21);
            this.lblPendingRequests.TabIndex = 11;
            this.lblPendingRequests.Text = "Pending Requests:";
            //
            // txtSearchPendingRequests
            //
            this.txtSearchPendingRequests.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPendingRequests.Location = new System.Drawing.Point(185, 558);
            this.txtSearchPendingRequests.Name = "txtSearchPendingRequests";
            this.txtSearchPendingRequests.Size = new System.Drawing.Size(200, 25);
            this.txtSearchPendingRequests.TabIndex = 12;
            this.txtSearchPendingRequests.TextChanged += new System.EventHandler(this.txtSearchPendingRequests_TextChanged);
            //
            // dgvPendingRequests
            //
            this.dgvPendingRequests.AllowUserToAddRows = false;
            this.dgvPendingRequests.AllowUserToDeleteRows = false;
            this.dgvPendingRequests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPendingRequests.Location = new System.Drawing.Point(25, 590);
            this.dgvPendingRequests.MultiSelect = false;
            this.dgvPendingRequests.Name = "dgvPendingRequests";
            this.dgvPendingRequests.ReadOnly = true;
            this.dgvPendingRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPendingRequests.Size = new System.Drawing.Size(775, 150);
            this.dgvPendingRequests.TabIndex = 13;
            //
            // StudentDashboardForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 760); // Increased height to accommodate all sections
            this.Controls.Add(this.dgvPendingRequests);
            this.Controls.Add(this.txtSearchPendingRequests);
            this.Controls.Add(this.lblPendingRequests);
            this.Controls.Add(this.btnReissueBook);
            this.Controls.Add(this.dgvIssuedBooks);
            this.Controls.Add(this.txtSearchIssuedBooks);
            this.Controls.Add(this.lblIssuedBooks);
            this.Controls.Add(this.btnRequestBook);
            this.Controls.Add(this.dgvAvailableBooks);
            this.Controls.Add(this.txtSearchAvailableBooks);
            this.Controls.Add(this.lblAvailableBooks);
            this.Controls.Add(this.btnRefreshLists);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcomeUser);
            this.BackColor = System.Drawing.Color.Yellow; // Set form background to Yellow
            this.Name = "StudentDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Dashboard - Library Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPendingRequests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcomeUser;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnRefreshLists;
        // Available Books
        private System.Windows.Forms.Label lblAvailableBooks;
        private System.Windows.Forms.TextBox txtSearchAvailableBooks;
        private System.Windows.Forms.DataGridView dgvAvailableBooks;
        private System.Windows.Forms.Button btnRequestBook;
        // Issued Books
        private System.Windows.Forms.Label lblIssuedBooks;
        private System.Windows.Forms.TextBox txtSearchIssuedBooks;
        private System.Windows.Forms.DataGridView dgvIssuedBooks;
        private System.Windows.Forms.Button btnReissueBook;
        // Pending Requests
        private System.Windows.Forms.Label lblPendingRequests;
        private System.Windows.Forms.TextBox txtSearchPendingRequests;
        private System.Windows.Forms.DataGridView dgvPendingRequests;
    }
}
