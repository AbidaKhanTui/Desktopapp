namespace LibraryManagementApp
{
    partial class ManageBooksForm
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
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookDetail = new System.Windows.Forms.Label();
            this.txtBookDetail = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookPublisher = new System.Windows.Forms.Label();
            this.txtBookPublisher = new System.Windows.Forms.TextBox();
            this.lblBookBranch = new System.Windows.Forms.Label();
            this.txtBookBranch = new System.Windows.Forms.TextBox();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.lblBookQuantity = new System.Windows.Forms.Label();
            this.txtBookQuantity = new System.Windows.Forms.TextBox();
            this.lblBookAvailable = new System.Windows.Forms.Label();
            this.txtBookAvailable = new System.Windows.Forms.TextBox();
            this.lblBookRented = new System.Windows.Forms.Label();
            this.txtBookRented = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            //
            // lblBookId
            //
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(30, 30);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(56, 17);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.Text = "Book ID:";
            //
            // txtBookId
            //
            this.txtBookId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookId.Location = new System.Drawing.Point(130, 27);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true; // ID is auto-incremented, not set by user
            this.txtBookId.Size = new System.Drawing.Size(150, 25);
            this.txtBookId.TabIndex = 1;
            //
            // lblBookName
            //
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(30, 60);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(80, 17);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Book Name:";
            //
            // txtBookName
            //
            this.txtBookName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookName.Location = new System.Drawing.Point(130, 57);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(250, 25);
            this.txtBookName.TabIndex = 3;
            //
            // lblBookDetail
            //
            this.lblBookDetail.AutoSize = true;
            this.lblBookDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookDetail.Location = new System.Drawing.Point(30, 90);
            this.lblBookDetail.Name = "lblBookDetail";
            this.lblBookDetail.Size = new System.Drawing.Size(76, 17);
            this.lblBookDetail.TabIndex = 4;
            this.lblBookDetail.Text = "Book Detail:";
            //
            // txtBookDetail
            //
            this.txtBookDetail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookDetail.Location = new System.Drawing.Point(130, 87);
            this.txtBookDetail.Multiline = true;
            this.txtBookDetail.Name = "txtBookDetail";
            this.txtBookDetail.Size = new System.Drawing.Size(250, 50);
            this.txtBookDetail.TabIndex = 5;
            //
            // lblBookAuthor
            //
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.Location = new System.Drawing.Point(30, 150);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(81, 17);
            this.lblBookAuthor.TabIndex = 6;
            this.lblBookAuthor.Text = "Book Author:";
            //
            // txtBookAuthor
            //
            this.txtBookAuthor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAuthor.Location = new System.Drawing.Point(130, 147);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(250, 25);
            this.txtBookAuthor.TabIndex = 7;
            //
            // lblBookPublisher
            //
            this.lblBookPublisher.AutoSize = true;
            this.lblBookPublisher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPublisher.Location = new System.Drawing.Point(30, 180);
            this.lblBookPublisher.Name = "lblBookPublisher";
            this.lblBookPublisher.Size = new System.Drawing.Size(95, 17);
            this.lblBookPublisher.TabIndex = 8;
            this.lblBookPublisher.Text = "Book Publisher:";
            //
            // txtBookPublisher
            //
            this.txtBookPublisher.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPublisher.Location = new System.Drawing.Point(130, 177);
            this.txtBookPublisher.Name = "txtBookPublisher";
            this.txtBookPublisher.Size = new System.Drawing.Size(250, 25);
            this.txtBookPublisher.TabIndex = 9;
            //
            // lblBookBranch
            //
            this.lblBookBranch.AutoSize = true;
            this.lblBookBranch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookBranch.Location = new System.Drawing.Point(30, 210);
            this.lblBookBranch.Name = "lblBookBranch";
            this.lblBookBranch.Size = new System.Drawing.Size(49, 17);
            this.lblBookBranch.TabIndex = 10;
            this.lblBookBranch.Text = "Branch:";
            //
            // txtBookBranch
            //
            this.txtBookBranch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookBranch.Location = new System.Drawing.Point(130, 207);
            this.txtBookBranch.Name = "txtBookBranch";
            this.txtBookBranch.Size = new System.Drawing.Size(250, 25);
            this.txtBookBranch.TabIndex = 11;
            //
            // lblBookPrice
            //
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookPrice.Location = new System.Drawing.Point(30, 240);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(71, 17);
            this.lblBookPrice.TabIndex = 12;
            this.lblBookPrice.Text = "Book Price:";
            //
            // txtBookPrice
            //
            this.txtBookPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookPrice.Location = new System.Drawing.Point(130, 237);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(150, 25);
            this.txtBookPrice.TabIndex = 13;
            //
            // lblBookQuantity
            //
            this.lblBookQuantity.AutoSize = true;
            this.lblBookQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookQuantity.Location = new System.Drawing.Point(30, 270);
            this.lblBookQuantity.Name = "lblBookQuantity";
            this.lblBookQuantity.Size = new System.Drawing.Size(61, 17);
            this.lblBookQuantity.TabIndex = 14;
            this.lblBookQuantity.Text = "Quantity:";
            //
            // txtBookQuantity
            //
            this.txtBookQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookQuantity.Location = new System.Drawing.Point(130, 267);
            this.txtBookQuantity.Name = "txtBookQuantity";
            this.txtBookQuantity.Size = new System.Drawing.Size(150, 25);
            this.txtBookQuantity.TabIndex = 15;
            //
            // lblBookAvailable
            //
            this.lblBookAvailable.AutoSize = true;
            this.lblBookAvailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAvailable.Location = new System.Drawing.Point(30, 300);
            this.lblBookAvailable.Name = "lblBookAvailable";
            this.lblBookAvailable.Size = new System.Drawing.Size(64, 17);
            this.lblBookAvailable.TabIndex = 16;
            this.lblBookAvailable.Text = "Available:";
            //
            // txtBookAvailable
            //
            this.txtBookAvailable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookAvailable.Location = new System.Drawing.Point(130, 297);
            this.txtBookAvailable.Name = "txtBookAvailable";
            this.txtBookAvailable.Size = new System.Drawing.Size(150, 25);
            this.txtBookAvailable.TabIndex = 17;
            //
            // lblBookRented
            //
            this.lblBookRented.AutoSize = true;
            this.lblBookRented.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookRented.Location = new System.Drawing.Point(30, 330);
            this.lblBookRented.Name = "lblBookRented";
            this.lblBookRented.Size = new System.Drawing.Size(54, 17);
            this.lblBookRented.TabIndex = 18;
            this.lblBookRented.Text = "Rented:";
            //
            // txtBookRented
            //
            this.txtBookRented.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookRented.Location = new System.Drawing.Point(130, 327);
            this.txtBookRented.Name = "txtBookRented";
            this.txtBookRented.Size = new System.Drawing.Size(150, 25);
            this.txtBookRented.TabIndex = 19;
            //
            // btnAdd
            //
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(30, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 35);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            //
            // btnUpdate
            //
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(120, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 35);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(210, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 35);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(300, 370);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 35);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // dgvBooks
            //
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(400, 60);
            this.dgvBooks.MultiSelect = false;
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(700, 350);
            this.dgvBooks.TabIndex = 24;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            //
            // lblSearch
            //
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(400, 30);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 17);
            this.lblSearch.TabIndex = 25;
            this.lblSearch.Text = "Search:";
            //
            // txtSearch
            //
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(460, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 25);
            this.txtSearch.TabIndex = 26;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            //
            // ManageBooksForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 450);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBookRented);
            this.Controls.Add(this.lblBookRented);
            this.Controls.Add(this.txtBookAvailable);
            this.Controls.Add(this.lblBookAvailable);
            this.Controls.Add(this.txtBookQuantity);
            this.Controls.Add(this.lblBookQuantity);
            this.Controls.Add(this.txtBookPrice);
            this.Controls.Add(this.lblBookPrice);
            this.Controls.Add(this.txtBookBranch);
            this.Controls.Add(this.lblBookBranch);
            this.Controls.Add(this.txtBookPublisher);
            this.Controls.Add(this.lblBookPublisher);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.txtBookDetail);
            this.Controls.Add(this.lblBookDetail);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lblBookId);
            this.Name = "ManageBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Books";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookDetail;
        private System.Windows.Forms.TextBox txtBookDetail;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookPublisher;
        private System.Windows.Forms.TextBox txtBookPublisher;
        private System.Windows.Forms.Label lblBookBranch;
        private System.Windows.Forms.TextBox txtBookBranch;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label lblBookQuantity;
        private System.Windows.Forms.TextBox txtBookQuantity;
        private System.Windows.Forms.Label lblBookAvailable;
        private System.Windows.Forms.TextBox txtBookAvailable;
        private System.Windows.Forms.Label lblBookRented;
        private System.Windows.Forms.TextBox txtBookRented;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
    }
}

