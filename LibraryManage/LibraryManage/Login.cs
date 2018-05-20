using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LibraryManage
{
    public partial class Login : Form
    {
        public static string  LoginName;
        public static string RoleName;
        public static string PWD;
        public Login()
        {
             InitializeComponent();
             UserName.Text = "sm1995";
             PassWord.Text = "123456";
             DirectoryInfo dir = new DirectoryInfo(Application.StartupPath).Parent.Parent;
             string target = dir.FullName;
             axWindowsMediaPlayer1.settings.setMode("loop", true);
             axWindowsMediaPlayer1.URL = target + @"\musics\夜的钢琴曲.mp3";
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = UserName.Text;
                string passWord = PassWord.Text;
                string sql = "select * from Users where UserName='" + userName + "' and PassWord='" + passWord + "'";
                DataSet ds = DataBase.Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    string str = ds.Tables[0].Rows[0]["RoleNum"].ToString();
                    GetRoleName(str);
                    LoginName = userName;
                    PWD = passWord;
                    LibraryMain libraryMain = new LibraryMain(axWindowsMediaPlayer1);
                    this.Hide();
                    libraryMain.Show();
                }
                else
                {
                    if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord))
                    {
                        MessageBox.Show("请输入用户名和密码");
                    }
                    else
                    {
                        MessageBox.Show("输入的用户名或密码错误");

                    }
                }
            }
            catch (Exception x)
            { }
        }
        public void GetRoleName(string RoleNum) 
        {
            try
            {
                string sql = "select RoleName from Role where RoleNum='" + RoleNum + "'";
                DataSet ds = DataBase.Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    RoleName = ds.Tables[0].Rows[0]["RoleName"].ToString();
                }
            }
            catch (Exception x)
            { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
