namespace LibraryManagementApp
{
    partial class ViewRequestedBooksForm
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
            this.lblTitle = new System.Windows.Forms.Label(); // Declared lblTitle
            this.dgvRequestedBooks = new System.Windows.Forms.DataGridView();
            this.lblSearchRequests = new System.Windows.Forms.Label();
            this.txtSearchRequests = new System.Windows.Forms.TextBox();
            this.btnApproveRequest = new System.Windows.Forms.Button();
            this.btnRejectRequest = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button(); // Declared btnRefreshList
            this.btnBackToDashboard = new System.Windows.Forms.Button(); // Declared btnBackToDashboard
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedBooks)).BeginInit();
            this.SuspendLayout();
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(325, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Book Requests";
            //
            // dgvRequestedBooks
            //
            this.dgvRequestedBooks.AllowUserToAddRows = false;
            this.dgvRequestedBooks.AllowUserToDeleteRows = false;
            this.dgvRequestedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestedBooks.Location = new System.Drawing.Point(25, 80); // Adjusted position
            this.dgvRequestedBooks.MultiSelect = false;
            this.dgvRequestedBooks.Name = "dgvRequestedBooks";
            this.dgvRequestedBooks.ReadOnly = true;
            this.dgvRequestedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequestedBooks.Size = new System.Drawing.Size(750, 300);
            this.dgvRequestedBooks.TabIndex = 1; // Changed from 0 to 1 as lblTitle and search controls are now first
            //
            // lblSearchRequests
            //
            this.lblSearchRequests.AutoSize = true;
            this.lblSearchRequests.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchRequests.Location = new System.Drawing.Point(25, 50); // Adjusted position
            this.lblSearchRequests.Name = "lblSearchRequests";
            this.lblSearchRequests.Size = new System.Drawing.Size(103, 17);
            this.lblSearchRequests.TabIndex = 2; // Changed from 1 to 2
            this.lblSearchRequests.Text = "Search Requests:";
            //
            // txtSearchRequests
            //
            this.txtSearchRequests.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchRequests.Location = new System.Drawing.Point(134, 47); // Adjusted position
            this.txtSearchRequests.Name = "txtSearchRequests";
            this.txtSearchRequests.Size = new System.Drawing.Size(200, 25);
            this.txtSearchRequests.TabIndex = 3; // Changed from 2 to 3
            this.txtSearchRequests.TextChanged += new System.EventHandler(this.txtSearchRequests_TextChanged);
            //
            // btnApproveRequest
            //
            this.btnApproveRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApproveRequest.Location = new System.Drawing.Point(25, 400);
            this.btnApproveRequest.Name = "btnApproveRequest";
            this.btnApproveRequest.Size = new System.Drawing.Size(150, 40);
            this.btnApproveRequest.TabIndex = 4; // Changed from 3 to 4
            this.btnApproveRequest.Text = "Approve Selected";
            this.btnApproveRequest.UseVisualStyleBackColor = true;
            this.btnApproveRequest.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnApproveRequest.Click += new System.EventHandler(this.btnApproveRequest_Click);
            //
            // btnRejectRequest
            //
            this.btnRejectRequest.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRejectRequest.Location = new System.Drawing.Point(190, 400);
            this.btnRejectRequest.Name = "btnRejectRequest";
            this.btnRejectRequest.Size = new System.Drawing.Size(150, 40);
            this.btnRejectRequest.TabIndex = 5; // Changed from 4 to 5
            this.btnRejectRequest.Text = "Reject Selected";
            this.btnRejectRequest.UseVisualStyleBackColor = true;
            this.btnRejectRequest.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnRejectRequest.Click += new System.EventHandler(this.btnRejectRequest_Click);
            //
            // btnRefreshList
            //
            this.btnRefreshList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshList.Location = new System.Drawing.Point(355, 400);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(150, 40);
            this.btnRefreshList.TabIndex = 6; // New tab index
            this.btnRefreshList.Text = "Refresh List";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnRefreshList.Click += new System.EventHandler(this.btnRefreshList_Click);
            //
            // btnBackToDashboard
            //
            this.btnBackToDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToDashboard.Location = new System.Drawing.Point(600, 20);
            this.btnBackToDashboard.Name = "btnBackToDashboard";
            this.btnBackToDashboard.Size = new System.Drawing.Size(175, 37);
            this.btnBackToDashboard.TabIndex = 7; // New tab index
            this.btnBackToDashboard.Text = "Back to Admin Dashboard";
            this.btnBackToDashboard.UseVisualStyleBackColor = true;
            this.btnBackToDashboard.BackColor = System.Drawing.Color.FloralWhite; // Off-white color
            this.btnBackToDashboard.Click += new System.EventHandler(this.btnBackToDashboard_Click);
            //
            // ViewRequestedBooksForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.btnBackToDashboard);
            this.Controls.Add(this.btnRefreshList);
            this.Controls.Add(this.btnRejectRequest);
            this.Controls.Add(this.btnApproveRequest);
            this.Controls.Add(this.txtSearchRequests);
            this.Controls.Add(this.lblSearchRequests);
            this.Controls.Add(this.dgvRequestedBooks);
            this.Controls.Add(this.lblTitle); // Added back lblTitle to Controls
            this.BackColor = System.Drawing.Color.Yellow; // Set form background to Yellow
            this.Name = "ViewRequestedBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Book Requests";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle; // Declaration for lblTitle
        private System.Windows.Forms.DataGridView dgvRequestedBooks;
        private System.Windows.Forms.Label lblSearchRequests;
        private System.Windows.Forms.TextBox txtSearchRequests;
        private System.Windows.Forms.Button btnApproveRequest;
        private System.Windows.Forms.Button btnRejectRequest;
        private System.Windows.Forms.Button btnRefreshList; // Declaration for btnRefreshList
        private System.Windows.Forms.Button btnBackToDashboard; // Declaration for btnBackToDashboard
    }
}
