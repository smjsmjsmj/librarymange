namespace LibraryManage
{
    partial class BorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BorrowBook));
            this.comboBoxKind = new System.Windows.Forms.ComboBox();
            this.IndexBook = new System.Windows.Forms.Button();
            this.data_Book = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxKind
            // 
            this.comboBoxKind.FormattingEnabled = true;
            this.comboBoxKind.Location = new System.Drawing.Point(33, 15);
            this.comboBoxKind.Name = "comboBoxKind";
            this.comboBoxKind.Size = new System.Drawing.Size(105, 20);
            this.comboBoxKind.TabIndex = 0;
            // 
            // IndexBook
            // 
            this.IndexBook.Location = new System.Drawing.Point(192, 12);
            this.IndexBook.Name = "IndexBook";
            this.IndexBook.Size = new System.Drawing.Size(44, 23);
            this.IndexBook.TabIndex = 1;
            this.IndexBook.Text = "检索";
            this.IndexBook.UseVisualStyleBackColor = true;
            this.IndexBook.Click += new System.EventHandler(this.IndexBook_Click);
            // 
            // data_Book
            // 
            this.data_Book.AllowUserToAddRows = false;
            this.data_Book.AllowUserToDeleteRows = false;
            this.data_Book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Book.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data_Book.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.data_Book.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.data_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Book.Location = new System.Drawing.Point(33, 60);
            this.data_Book.Name = "data_Book";
            this.data_Book.ReadOnly = true;
            this.data_Book.RowTemplate.Height = 23;
            this.data_Book.Size = new System.Drawing.Size(743, 348);
            this.data_Book.TabIndex = 2;
            this.data_Book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.buttonColumn_CellContentClick);
            // 
            // BorrowBook
            // 
            this.AcceptButton = this.IndexBook;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(801, 420);
            this.Controls.Add(this.data_Book);
            this.Controls.Add(this.IndexBook);
            this.Controls.Add(this.comboBoxKind);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "借书管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BorrowBook_FormClosed);
            this.Load += new System.EventHandler(this.BorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Book)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxKind;
        private System.Windows.Forms.Button IndexBook;
        private System.Windows.Forms.DataGridView data_Book;
    }
}