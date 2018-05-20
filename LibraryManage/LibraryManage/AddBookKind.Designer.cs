namespace LibraryManage
{
    partial class AddBookKind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookKind));
            this.label1 = new System.Windows.Forms.Label();
            this.txtBookNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKindName = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(53, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型编号:";
            // 
            // txtBookNum
            // 
            this.txtBookNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBookNum.Location = new System.Drawing.Point(141, 76);
            this.txtBookNum.Name = "txtBookNum";
            this.txtBookNum.Size = new System.Drawing.Size(100, 21);
            this.txtBookNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(53, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "类型名称:";
            // 
            // txtKindName
            // 
            this.txtKindName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtKindName.Location = new System.Drawing.Point(141, 148);
            this.txtKindName.Name = "txtKindName";
            this.txtKindName.Size = new System.Drawing.Size(100, 21);
            this.txtKindName.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Khaki;
            this.Save.Location = new System.Drawing.Point(199, 276);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(56, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "保存";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // txtReset
            // 
            this.txtReset.BackColor = System.Drawing.Color.Khaki;
            this.txtReset.Location = new System.Drawing.Point(75, 276);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(50, 23);
            this.txtReset.TabIndex = 3;
            this.txtReset.Text = "重置";
            this.txtReset.UseVisualStyleBackColor = false;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // AddBookKind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(320, 390);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtKindName);
            this.Controls.Add(this.txtBookNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddBookKind";
            this.Text = "新增书籍类型";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddBookKind_FormClosed);
            this.Load += new System.EventHandler(this.AddBookKind_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKindName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button txtReset;
    }
}