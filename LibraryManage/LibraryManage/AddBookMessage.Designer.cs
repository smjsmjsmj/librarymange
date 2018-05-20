namespace LibraryManage
{
    partial class AddBookMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookMessage));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNUM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPublish = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateDATE = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIntro = new System.Windows.Forms.RichTextBox();
            this.btuSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "书籍编号:";
            // 
            // txtNUM
            // 
            this.txtNUM.Location = new System.Drawing.Point(108, 36);
            this.txtNUM.Name = "txtNUM";
            this.txtNUM.Size = new System.Drawing.Size(100, 21);
            this.txtNUM.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "书籍名称:";
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(321, 36);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(100, 21);
            this.txtNAME.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "书籍作者:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(108, 75);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 21);
            this.txtAuthor.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "书籍出版社:";
            // 
            // txtPublish
            // 
            this.txtPublish.Location = new System.Drawing.Point(321, 75);
            this.txtPublish.Name = "txtPublish";
            this.txtPublish.Size = new System.Drawing.Size(100, 21);
            this.txtPublish.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "出版日期:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateDATE
            // 
            this.dateDATE.Location = new System.Drawing.Point(108, 112);
            this.dateDATE.Name = "dateDATE";
            this.dateDATE.Size = new System.Drawing.Size(100, 21);
            this.dateDATE.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "书籍种类:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(321, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 20);
            this.comboBox1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "作品简介:";
            this.label7.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtIntro
            // 
            this.txtIntro.Location = new System.Drawing.Point(45, 177);
            this.txtIntro.Name = "txtIntro";
            this.txtIntro.Size = new System.Drawing.Size(432, 124);
            this.txtIntro.TabIndex = 4;
            this.txtIntro.Text = "";
            // 
            // btuSave
            // 
            this.btuSave.Location = new System.Drawing.Point(211, 327);
            this.btuSave.Name = "btuSave";
            this.btuSave.Size = new System.Drawing.Size(64, 23);
            this.btuSave.TabIndex = 5;
            this.btuSave.Text = "保存";
            this.btuSave.UseVisualStyleBackColor = true;
            this.btuSave.Click += new System.EventHandler(this.btuSave_Click);
            // 
            // AddBookMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(502, 373);
            this.Controls.Add(this.btuSave);
            this.Controls.Add(this.txtIntro);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateDATE);
            this.Controls.Add(this.txtPublish);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtNUM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookMessage";
            this.Text = "新增书籍信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddBookMessage_FormClosed);
            this.Load += new System.EventHandler(this.AddBookMessage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNUM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPublish;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateDATE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtIntro;
        private System.Windows.Forms.Button btuSave;
    }
}