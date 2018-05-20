using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManage
{
    public partial class UserMessage : Form
    {
        public UserMessage()
        {
            InitializeComponent();
            this.OldPWD.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(OldPWD.Text) || string.IsNullOrEmpty(NewPWD.Text) || string.IsNullOrEmpty(RPWD.Text))
                {
                    MessageBox.Show(this, "请完整填写信息!", "温馨提示");
                }
                else if (!NewPWD.Text.Equals(RPWD.Text))
                {
                    MessageBox.Show(this, "新密码与确认密码不一致!", "温馨提示");

                }
                else if (!OldPWD.Text.Equals(Login.PWD))
                {
                    MessageBox.Show(this, "原密码错误!", "温馨提示");

                }
                else
                {

                    string sql = "update Users set Users.PassWord='" + RPWD.Text + "'";
                    Boolean flag = DataBase.MyExeQuery(sql);
                    if (flag)
                    {
                        MessageBox.Show(this, "修改密码成功!", "温馨提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "修改密码失败!", "温馨提示");

                    }
                }
            }
            catch (Exception xx)
            { }
        }

        private void UserMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LibraryMain libraryMain = new LibraryMain();
            libraryMain.Show();
        }

        private void UserMessage_Load(object sender, EventArgs e)
        {
            this.OldPWD.Focus();
        }
    }
}
