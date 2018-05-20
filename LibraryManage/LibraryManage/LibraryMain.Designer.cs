namespace LibraryManage
{
    partial class LibraryMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btuReturnBook = new System.Windows.Forms.Button();
            this.BorrowBook = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.BookMessage1 = new System.Windows.Forms.Button();
            this.QueryBook = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.AddBookKind = new System.Windows.Forms.Button();
            this.UpdatePWD = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.AddBook = new System.Windows.Forms.Button();
            this.QueryAuthor = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btuReturnBook);
            this.groupBox1.Controls.Add(this.BorrowBook);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(67, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "借书处理";
            // 
            // btuReturnBook
            // 
            this.btuReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btuReturnBook.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btuReturnBook.Location = new System.Drawing.Point(127, 93);
            this.btuReturnBook.Name = "btuReturnBook";
            this.btuReturnBook.Size = new System.Drawing.Size(76, 23);
            this.btuReturnBook.TabIndex = 1;
            this.btuReturnBook.Text = "还书管理";
            this.btuReturnBook.UseVisualStyleBackColor = false;
            this.btuReturnBook.Click += new System.EventHandler(this.btuReturnBook_Click);
            // 
            // BorrowBook
            // 
            this.BorrowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BorrowBook.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBook.Location = new System.Drawing.Point(127, 46);
            this.BorrowBook.Name = "BorrowBook";
            this.BorrowBook.Size = new System.Drawing.Size(76, 23);
            this.BorrowBook.TabIndex = 1;
            this.BorrowBook.Text = "借书管理";
            this.BorrowBook.UseVisualStyleBackColor = false;
            this.BorrowBook.Click += new System.EventHandler(this.BorrowBook_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryManage.Properties.Resources.maobi1;
            this.pictureBox2.Location = new System.Drawing.Point(6, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 49);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.BookMessage1);
            this.groupBox2.Controls.Add(this.QueryBook);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(536, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "查询";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibraryManage.Properties.Resources.QueryBook;
            this.pictureBox3.Location = new System.Drawing.Point(130, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(70, 49);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // BookMessage1
            // 
            this.BookMessage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BookMessage1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookMessage1.Location = new System.Drawing.Point(22, 94);
            this.BookMessage1.Name = "BookMessage1";
            this.BookMessage1.Size = new System.Drawing.Size(73, 23);
            this.BookMessage1.TabIndex = 1;
            this.BookMessage1.Text = "图书信息";
            this.BookMessage1.UseVisualStyleBackColor = false;
            this.BookMessage1.Click += new System.EventHandler(this.BookMessage1_Click);
            // 
            // QueryBook
            // 
            this.QueryBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.QueryBook.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryBook.Location = new System.Drawing.Point(22, 47);
            this.QueryBook.Name = "QueryBook";
            this.QueryBook.Size = new System.Drawing.Size(73, 23);
            this.QueryBook.TabIndex = 1;
            this.QueryBook.Text = "个人信息";
            this.QueryBook.UseVisualStyleBackColor = false;
            this.QueryBook.Click += new System.EventHandler(this.QueryBook_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.AddUser);
            this.groupBox3.Controls.Add(this.AddBookKind);
            this.groupBox3.Controls.Add(this.UpdatePWD);
            this.groupBox3.Controls.Add(this.exit);
            this.groupBox3.Controls.Add(this.AddBook);
            this.groupBox3.Controls.Add(this.QueryAuthor);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(70, 382);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(689, 100);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "系统/其它";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(477, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "添加用户角色";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUser
            // 
            this.AddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddUser.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddUser.Location = new System.Drawing.Point(315, 71);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(99, 23);
            this.AddUser.TabIndex = 3;
            this.AddUser.Text = "添加用户信息";
            this.AddUser.UseVisualStyleBackColor = false;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // AddBookKind
            // 
            this.AddBookKind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddBookKind.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBookKind.Location = new System.Drawing.Point(315, 22);
            this.AddBookKind.Name = "AddBookKind";
            this.AddBookKind.Size = new System.Drawing.Size(99, 23);
            this.AddBookKind.TabIndex = 3;
            this.AddBookKind.Text = "添加书籍类型";
            this.AddBookKind.UseVisualStyleBackColor = false;
            this.AddBookKind.Click += new System.EventHandler(this.AddBookKind_Click);
            // 
            // UpdatePWD
            // 
            this.UpdatePWD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.UpdatePWD.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpdatePWD.Location = new System.Drawing.Point(477, 22);
            this.UpdatePWD.Name = "UpdatePWD";
            this.UpdatePWD.Size = new System.Drawing.Size(99, 23);
            this.UpdatePWD.TabIndex = 3;
            this.UpdatePWD.Text = "修改个人密码";
            this.UpdatePWD.UseVisualStyleBackColor = false;
            this.UpdatePWD.Click += new System.EventHandler(this.UpdatePWD_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.exit.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.Location = new System.Drawing.Point(613, 22);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(53, 74);
            this.exit.TabIndex = 2;
            this.exit.Text = " 退出";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // AddBook
            // 
            this.AddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AddBook.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBook.Location = new System.Drawing.Point(159, 71);
            this.AddBook.Name = "AddBook";
            this.AddBook.Size = new System.Drawing.Size(99, 23);
            this.AddBook.TabIndex = 1;
            this.AddBook.Text = "添加图书信息";
            this.AddBook.UseVisualStyleBackColor = false;
            this.AddBook.Click += new System.EventHandler(this.AddBook_Click);
            // 
            // QueryAuthor
            // 
            this.QueryAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.QueryAuthor.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.QueryAuthor.Location = new System.Drawing.Point(159, 22);
            this.QueryAuthor.Name = "QueryAuthor";
            this.QueryAuthor.Size = new System.Drawing.Size(99, 23);
            this.QueryAuthor.TabIndex = 1;
            this.QueryAuthor.Text = "读者爱好统计";
            this.QueryAuthor.UseVisualStyleBackColor = false;
            this.QueryAuthor.Click += new System.EventHandler(this.QueryAuthor_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibraryManage.Properties.Resources.ZhuZi;
            this.pictureBox4.Location = new System.Drawing.Point(7, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(72, 88);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("楷体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(308, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "图书管理系统";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryManage.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(689, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // LibraryMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(829, 513);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LibraryMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LibraryMain_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btuReturnBook;
        private System.Windows.Forms.Button BorrowBook;
        private System.Windows.Forms.Button BookMessage1;
        private System.Windows.Forms.Button QueryBook;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button UpdatePWD;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button AddBook;
        private System.Windows.Forms.Button QueryAuthor;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button AddBookKind;
    }
}