namespace LibraryManage
{
    partial class BookMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookMessage));
            this.IndexBooK = new System.Windows.Forms.Button();
            this.comboBoxKind = new System.Windows.Forms.ComboBox();
            this.data_Book = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_Book)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IndexBooK
            // 
            this.IndexBooK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.IndexBooK.Location = new System.Drawing.Point(177, 33);
            this.IndexBooK.Name = "IndexBooK";
            this.IndexBooK.Size = new System.Drawing.Size(57, 24);
            this.IndexBooK.TabIndex = 0;
            this.IndexBooK.Text = "检索";
            this.IndexBooK.UseVisualStyleBackColor = true;
            this.IndexBooK.Click += new System.EventHandler(this.IndexBooK_Click);
            // 
            // comboBoxKind
            // 
            this.comboBoxKind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxKind.FormattingEnabled = true;
            this.comboBoxKind.Location = new System.Drawing.Point(32, 36);
            this.comboBoxKind.Name = "comboBoxKind";
            this.comboBoxKind.Size = new System.Drawing.Size(113, 20);
            this.comboBoxKind.TabIndex = 1;
            // 
            // data_Book
            // 
            this.data_Book.AllowUserToAddRows = false;
            this.data_Book.AllowUserToDeleteRows = false;
            this.data_Book.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.data_Book.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_Book.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.data_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Book.Location = new System.Drawing.Point(32, 89);
            this.data_Book.Name = "data_Book";
            this.data_Book.RowTemplate.Height = 23;
            this.data_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.data_Book.Size = new System.Drawing.Size(570, 217);
            this.data_Book.TabIndex = 2;
            this.data_Book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Book_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(467, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BookMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(630, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.data_Book);
            this.Controls.Add(this.comboBoxKind);
            this.Controls.Add(this.IndexBooK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookMessage";
            this.Text = "图书信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookMessage_FormClosed);
            this.Load += new System.EventHandler(this.BookMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_Book)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IndexBooK;
        private System.Windows.Forms.ComboBox comboBoxKind;
        private System.Windows.Forms.DataGridView data_Book;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}