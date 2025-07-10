namespace LibraryManagementApp
{
    partial class ReturnBookForm
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
            this.dgvIssuedBooks = new System.Windows.Forms.DataGridView();
            this.lblSearchIssued = new System.Windows.Forms.Label();
            this.txtSearchIssued = new System.Windows.Forms.TextBox();
            this.lblIssueId = new System.Windows.Forms.Label();
            this.txtIssueId = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblFine = new System.Windows.Forms.Label();
            this.lblFineAmount = new System.Windows.Forms.Label();
            this.btnReturnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).BeginInit();
            this.SuspendLayout();
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
            this.dgvIssuedBooks.TabIndex = 0;
            this.dgvIssuedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIssuedBooks_CellClick);
            //
            // lblSearchIssued
            //
            this.lblSearchIssued.AutoSize = true;
            this.lblSearchIssued.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchIssued.Location = new System.Drawing.Point(540, 222);
            this.lblSearchIssued.Name = "lblSearchIssued";
            this.lblSearchIssued.Size = new System.Drawing.Size(50, 17);
            this.lblSearchIssued.TabIndex = 1;
            this.lblSearchIssued.Text = "Search:";
            //
            // txtSearchIssued
            //
            this.txtSearchIssued.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchIssued.Location = new System.Drawing.Point(596, 218);
            this.txtSearchIssued.Name = "txtSearchIssued";
            this.txtSearchIssued.Size = new System.Drawing.Size(174, 25);
            this.txtSearchIssued.TabIndex = 2;
            this.txtSearchIssued.TextChanged += new System.EventHandler(this.txtSearchIssued_TextChanged);
            //
            // lblIssueId
            //
            this.lblIssueId.AutoSize = true;
            this.lblIssueId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueId.Location = new System.Drawing.Point(30, 30);
            this.lblIssueId.Name = "lblIssueId";
            this.lblIssueId.Size = new System.Drawing.Size(59, 17);
            this.lblIssueId.TabIndex = 3;
            this.lblIssueId.Text = "Issue ID:";
            //
            // txtIssueId
            //
            this.txtIssueId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIssueId.Location = new System.Drawing.Point(130, 27);
            this.txtIssueId.Name = "txtIssueId";
            this.txtIssueId.ReadOnly = true;
            this.txtIssueId.Size = new System.Drawing.Size(150, 25);
            this.txtIssueId.TabIndex = 4;
            //
            // lblUserName
            //
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(30, 70);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(77, 17);
            this.lblUserName.TabIndex = 5;
            this.lblUserName.Text = "User Name:";
            //
            // txtUserName
            //
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(130, 67);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ReadOnly = true;
            this.txtUserName.Size = new System.Drawing.Size(200, 25);
            this.txtUserName.TabIndex = 6;
            //
            // lblBookName
            //
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(30, 110);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(80, 17);
            this.lblBookName.TabIndex = 7;
            this.lblBookName.Text = "Book Name:";
            //
            // txtBookName
            //
            this.txtBookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(130, 107);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(200, 25);
            this.txtBookName.TabIndex = 8;
            //
            // lblFine
            //
            this.lblFine.AutoSize = true;
            this.lblFine.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFine.Location = new System.Drawing.Point(30, 150);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(40, 17);
            this.lblFine.TabIndex = 9;
            this.lblFine.Text = "Fine:";
            //
            // lblFineAmount
            //
            this.lblFineAmount.AutoSize = true;
            this.lblFineAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineAmount.Location = new System.Drawing.Point(70, 150);
            this.lblFineAmount.Name = "lblFineAmount";
            this.lblFineAmount.Size = new System.Drawing.Size(49, 17);
            this.lblFineAmount.TabIndex = 10;
            this.lblFineAmount.Text = "Fine: 0";
            //
            // btnReturnBook
            //
            this.btnReturnBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.Location = new System.Drawing.Point(130, 180);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(120, 35);
            this.btnReturnBook.TabIndex = 11;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.BackColor = System.Drawing.Color.FloralWhite; // Set button color to Off-white
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            //
            // ReturnBookForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.lblFineAmount);
            this.Controls.Add(this.lblFine);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtIssueId);
            this.Controls.Add(this.lblIssueId);
            this.Controls.Add(this.txtSearchIssued);
            this.Controls.Add(this.lblSearchIssued);
            this.Controls.Add(this.dgvIssuedBooks);
            this.BackColor = System.Drawing.Color.Yellow; // Set form background to Yellow
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssuedBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIssuedBooks;
        private System.Windows.Forms.Label lblSearchIssued;
        private System.Windows.Forms.TextBox txtSearchIssued;
        private System.Windows.Forms.Label lblIssueId;
        private System.Windows.Forms.TextBox txtIssueId;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Label lblFineAmount;
        private System.Windows.Forms.Button btnReturnBook;
    }
}
