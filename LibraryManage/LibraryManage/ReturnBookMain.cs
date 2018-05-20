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
    public partial class ReturnBookMain : Form
    {
        public DataGridView datagrid;
        public ReturnBookMain(DataGridView datagrid)
        {
            InitializeComponent();
            this.datagrid = datagrid;
            init();
        }
        public void init()
        {
            txtBookNum.Text = ReturnBook.BookNumIndex;
            txtBook.Text = ReturnBook.BookNumName;
            txtReturnTime.Text = DateTime.Now.ToString();
            
        }
        private void btuAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into ReturnBook (Book_Num,UserName,ReturnTime) values('" + txtBookNum.Text + "','" + Login.LoginName + "','" + txtReturnTime.Text + "')";
                string sql1 = "update BorrowBook set flag='0' where Book_Num='" + txtBookNum.Text + "' and UserName='" + Login.LoginName + "'";
                Boolean flag1 = DataBase.MyExeQuery(sql1);
                Boolean flag = DataBase.MyExeQuery(sql);
                if (flag && flag1)
                {
                    MessageBox.Show("已完成还书!");
                    datagrid.Columns.Clear();
                    string sql2 = "";
                    if (Login.RoleName.Contains("管理员"))
                    {
                        sql2 = "select BorrowBook.Book_Num as 图书编号,Book_Name as 图书名称,Book_Author as 作者,BorrowTime as 借书时间,BorrowDay as 借书期限,Name as 借书人 from BorrowBook,BookMessage,Users where BorrowBook.Book_Num=BookMessage.Book_Num and BorrowBook.UserName=Users.UserName and flag='1' ";
                    }
                    else
                    {
                        sql2 = "select BorrowBook.Book_Num as 图书编号,Book_Name as 图书名称,Book_Author as 作者,BorrowTime as 借书时间,BorrowDay as 借书期限,Name as 借书人 from BorrowBook,BookMessage,Users where BorrowBook.Book_Num=BookMessage.Book_Num and BorrowBook.UserName=Users.UserName and flag='1' and BorrowBook.UserName='" + Login.LoginName + "'";
                    }
                    DataSet ds = DataBase.Query(sql2);
                    datagrid.DataSource = ds.Tables[0];
                    CreateUnboundButtonColumn(ds.Tables[0].Columns.Count, "未还");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("还书失败!");
                }
            }
            catch (Exception x)
            { }
        }
        private void CreateUnboundButtonColumn(int count, string text)
        {

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Operate";
            buttonColumn.HeaderText = "状态";
            buttonColumn.Text = text;
            buttonColumn.UseColumnTextForButtonValue = true;
            datagrid.Columns.Insert(count, buttonColumn);
        }
        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
