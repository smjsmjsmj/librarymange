namespace LibraryManage
{
    partial class ReturnBookMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnBookMain));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReturnTime = new System.Windows.Forms.TextBox();
            this.btuAdd = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "图书编号:";
            // 
            // txtBookNum
            // 
            this.txtBookNum.Location = new System.Drawing.Point(142, 47);
            this.txtBookNum.Name = "txtBookNum";
            this.txtBookNum.ReadOnly = true;
            this.txtBookNum.Size = new System.Drawing.Size(116, 23);
            this.txtBookNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "图书名称:";
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(142, 110);
            this.txtBook.Name = "txtBook";
            this.txtBook.ReadOnly = true;
            this.txtBook.Size = new System.Drawing.Size(116, 23);
            this.txtBook.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 14);
            this.label3.TabIndex = 0;
            this.label3.Text = "还书时间:";
            // 
            // txtReturnTime
            // 
            this.txtReturnTime.Location = new System.Drawing.Point(142, 177);
            this.txtReturnTime.Name = "txtReturnTime";
            this.txtReturnTime.ReadOnly = true;
            this.txtReturnTime.Size = new System.Drawing.Size(116, 23);
            this.txtReturnTime.TabIndex = 1;
            // 
            // btuAdd
            // 
            this.btuAdd.Location = new System.Drawing.Point(194, 251);
            this.btuAdd.Name = "btuAdd";
            this.btuAdd.Size = new System.Drawing.Size(76, 27);
            this.btuAdd.TabIndex = 2;
            this.btuAdd.Text = "提交";
            this.btuAdd.UseVisualStyleBackColor = true;
            this.btuAdd.Click += new System.EventHandler(this.btuAdd_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(61, 251);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(64, 23);
            this.exit.TabIndex = 3;
            this.exit.Text = "返回";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ReturnBookMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(320, 390);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btuAdd);
            this.Controls.Add(this.txtReturnTime);
            this.Controls.Add(this.txtBook);
            this.Controls.Add(this.txtBookNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBookMain";
            this.Text = " 我要还书";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReturnTime;
        private System.Windows.Forms.Button btuAdd;
        private System.Windows.Forms.Button exit;
    }
}