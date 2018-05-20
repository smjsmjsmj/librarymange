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
    public partial class BorrowBookMain : Form
    {
        public BorrowBookMain()
        {
            InitializeComponent();
            initData();
        }
        public void initData() 
        {
            txtBookNum.Text = BorrowBook.BookNumIndex;
            txtBookUser.Text = Login.LoginName;
            txtDate.Text = DateTime.Now.ToString();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtDay.Text))
                {
                    int BookDay = int.Parse(txtDay.Text);
                    string sql = "insert into BorrowBook (Book_Num,UserName,BorrowTime,BorrowDay,flag) values('" + txtBookNum.Text + "','" + txtBookUser.Text + "','" + txtDate.Text + "'," + BookDay + ",'1')";
                    Boolean flag = DataBase.MyExeQuery(sql);
                    if (flag)
                    {
                        MessageBox.Show("已完成借书!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("借书失败!");
                    }

                }
                else
                {
                    MessageBox.Show("请填写借书期限!");
                }
            }
            catch (Exception x)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
