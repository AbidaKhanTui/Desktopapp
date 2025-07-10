namespace LibraryManagementApp
{
    partial class IssueBookForm
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
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lblSelectBook = new System.Windows.Forms.Label();
            this.cmbBook = new System.Windows.Forms.ComboBox();
            this.lblIssueDays = new System.Windows.Forms.Label();
            this.txtIssueDays = new System.Windows.Forms.TextBox();
            this.btnIssue = new System.Windows.Forms.Button();
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.lblIssuedBooks = new System.Windows.Forms.Label();
            this.lblSearchIssued = new System.Windows.Forms.Label();
            this.txtSearchIssued = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
            this.SuspendLayout();
            //
            // lblSelectUser
            //
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectUser.Location = new System.Drawing.Point(30, 30);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(76, 17);
            this.lblSelectUser.TabIndex = 0;
            this.lblSelectUser.Text = "Select User:";
            //
            // cmbUser
            //
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(130, 27);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(200, 25);
            this.cmbUser.TabIndex = 1;
            //
            // lblSelectBook
            //
            this.lblSelectBook.AutoSize = true;
            this.lblSelectBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBook.Location = new System.Drawing.Point(30, 70);
            this.lblSelectBook.Name = "lblSelectBook";
            this.lblSelectBook.Size = new System.Drawing.Size(81, 17);
            this.lblSelectBook.TabIndex = 2;
            this.lblSelectBook.Text = "Select Book:";
            //
            // cmbBook
            //
            this.cmbBook.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBook.FormattingEnabled = true;
            this.cmbBook.Location = new System.Drawing.Point(130, 67);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Size = new System.Drawing.Size(200, 25);
            this.cmbBook.TabIndex = 3;
            //
            // lblIssueDays
            //
            this.lblIssueDays.AutoSize = true;
            this.lblIssueDays.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDays.Location = new System.Drawing.Point(30, 110);
            this.lblIssueDays.Name = "lblIssueDays";
            this.lblIssueDays.Size = new System.Drawing.Size(73, 17);
            this.lblIssueDays.TabIndex = 4;
            this.lblIssueDays.Text = "Issue Days:";
            //
            // txtIssueDays
            //
            this.txtIssueDays.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueDays.Location = new System.Drawing.Point(130, 107);
            this.txtIssueDays.Name = "txtIssueDays";
            this.txtIssueDays.Size = new System.Drawing.Size(100, 25);
            this.txtIssueDays.TabIndex = 5;
            //
            // btnIssue
            //
            this.btnIssue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(130, 150);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(100, 35);
            this.btnIssue.TabIndex = 6;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            //
            // dgvIssuedBooks
            //
            this.dgvIssuedBooks.AllowUserToAddRows = false;
            this.dgvIssuedBooks.AllowUserToDeleteRows = false;
            this.dgvIssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssuedBooks.Location = new System.Drawing.Point(30, 250);
            this.dgvIssuedBooks.MultiSelect = false;
            this.dgvIssuedBooks.Name = "dgvIssuedBooks";
            this.dgvIssuedBooks.ReadOnly = true;
            this.dgvIssuedBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvIssuedBooks.Size = new System.Drawing.Size(740, 250);
            this.dgvIssuedBooks.TabIndex = 7;
            //
            // lblIssuedBooks
            //
            this.lblIssuedBooks.AutoSize = true;
            this.lblIssuedBooks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssuedBooks.Location = new System.Drawing.Point(26, 218);
            this.lblIssuedBooks.Name = "lblIssuedBooks";
            this.lblIssuedBooks.Size = new System.Drawing.Size(113, 21);
            this.lblIssuedBooks.TabIndex = 8;
            this.lblIssuedBooks.Text = "Issued Books:";
            //
            // lblSearchIssued
            //
            this.lblSearchIssued.AutoSize = true;
            this.lblSearchIssued.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchIssued.Location = new System.Drawing.Point(540, 222);
            this.lblSearchIssued.Name = "lblSearchIssued";
            this.lblSearchIssued.Size = new System.Drawing.Size(50, 17);
            this.lblSearchIssued.TabIndex = 9;
            this.lblSearchIssued.Text = "Search:";
            //
            // txtSearchIssued
            //
            this.txtSearchIssued.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchIssued.Location = new System.Drawing.Point(596, 218);
            this.txtSearchIssued.Name = "txtSearchIssued";
            this.txtSearchIssued.Size = new System.Drawing.Size(174, 25);
            this.txtSearchIssued.TabIndex = 10;
            this.txtSearchIssued.TextChanged += new System.EventHandler(this.txtSearchIssued_TextChanged);
            //
            // IssueBookForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.txtSearchIssued);
            this.Controls.Add(this.lblSearchIssued);
            this.Controls.Add(this.lblIssuedBooks);
            this.Controls.Add(this.dgvIssuedBooks);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.txtIssueDays);
            this.Controls.Add(this.lblIssueDays);
            this.Controls.Add(this.cmbBook);
            this.Controls.Add(this.lblSelectBook);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.lblSelectUser);
            this.Name = "IssueBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Book";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Label lblSelectBook;
        private System.Windows.Forms.ComboBox cmbBook;
        private System.Windows.Forms.Label lblIssueDays;
        private System.Windows.Forms.TextBox txtIssueDays;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.DataGridView dgvIssuedBooks;
        private System.Windows.Forms.Label lblIssuedBooks;
        private System.Windows.Forms.Label lblSearchIssued;
        private System.Windows.Forms.TextBox txtSearchIssued;
    }
}
