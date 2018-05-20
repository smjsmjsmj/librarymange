namespace LibraryManage
{
    partial class ReturnBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBook));
            this.dataReturnBook = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxReturnBook = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataReturnBook)).BeginInit();
            this.SuspendLayout();
            // 
            // dataReturnBook
            // 
            this.dataReturnBook.AllowUserToAddRows = false;
            this.dataReturnBook.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataReturnBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataReturnBook.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataReturnBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataReturnBook.Location = new System.Drawing.Point(12, 98);
            this.dataReturnBook.Name = "dataReturnBook";
            this.dataReturnBook.RowTemplate.Height = 23;
            this.dataReturnBook.Size = new System.Drawing.Size(777, 295);
            this.dataReturnBook.TabIndex = 0;
            this.dataReturnBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataReturnBook_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "检索";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxReturnBook
            // 
            this.comboBoxReturnBook.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxReturnBook.FormattingEnabled = true;
            this.comboBoxReturnBook.Items.AddRange(new object[] {
            "未还书籍",
            "已还书籍"});
            this.comboBoxReturnBook.Location = new System.Drawing.Point(47, 24);
            this.comboBoxReturnBook.Name = "comboBoxReturnBook";
            this.comboBoxReturnBook.Size = new System.Drawing.Size(102, 20);
            this.comboBoxReturnBook.TabIndex = 2;
            // 
            // ReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(801, 414);
            this.Controls.Add(this.comboBoxReturnBook);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataReturnBook);
            this.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBook";
            this.Text = "还书管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReturnBook_FormClosed);
            this.Load += new System.EventHandler(this.ReturnBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataReturnBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataReturnBook;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxReturnBook;
    }
}