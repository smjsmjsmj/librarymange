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
    public partial class ReturnBook : Form
    {
        public static string BookNumIndex;
        public static string BookNumName;
        public static string BookNum;
        public ReturnBook()
        {
            InitializeComponent();
        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            init();
            comboBoxReturnBook.SelectedIndex = 0;
        }
        public void init() 
        {
            try
            {
                string sql = "";
                if (Login.RoleName.Contains("管理员"))
                {
                    sql = "select BorrowBook.Book_Num as 图书编号,Book_Name as 图书名称,Book_Author as 作者,BorrowTime as 借书时间,BorrowDay as 借书期限,Name as 借书人 from BorrowBook,BookMessage,Users where BorrowBook.Book_Num=BookMessage.Book_Num and BorrowBook.UserName=Users.UserName and flag='1' ";
                }
                else
                {
                    sql = "select BorrowBook.Book_Num as 图书编号,Book_Name as 图书名称,Book_Author as 作者,BorrowTime as 借书时间,BorrowDay as 借书期限,Name as 借书人 from BorrowBook,BookMessage,Users where BorrowBook.Book_Num=BookMessage.Book_Num and BorrowBook.UserName=Users.UserName and flag='1' and BorrowBook.UserName='" + Login.LoginName + "'";
                }
                DataSet ds = DataBase.Query(sql);
                dataReturnBook.DataSource = ds.Tables[0];
                CreateUnboundButtonColumn(ds.Tables[0].Columns.Count, "未还");
            }
            catch (Exception x)
            { }
        }
        public void initBook() 
        {
            try
            {
                string sql = "";
                if (Login.RoleName.Contains("管理员"))
                {
                    sql = "select ReturnBook.Book_Num as 图书编号,Book_Name as 图书名称,Book_Author as 作者,BorrowTime as 借书时间,BorrowDay as 借书期限,ReturnTime as 还书时间,Name as 借书人 from BorrowBook,BookMessage,Users,ReturnBook where ReturnBook.Book_Num=BookMessage.Book_Num and BorrowBook.UserName=Users.UserName and ReturnBook.Book_Num=BorrowBook.Book_Num and flag='0'";
                }
                else
                {
                    sql = "select ReturnBook.Book_Num as 图书编号,Book_Name as 图书名称,Book_Author as 作者,BorrowTime as 借书时间,BorrowDay as 借书期限,ReturnTime as 还书时间,Name as 借书人 from BorrowBook,BookMessage,Users,ReturnBook where ReturnBook.Book_Num=BookMessage.Book_Num and BorrowBook.UserName=Users.UserName and ReturnBook.Book_Num=BorrowBook.Book_Num and flag='0' and ReturnBook.UserName='" + Login.LoginName + "'";
                }
                DataSet ds = DataBase.Query(sql);
                dataReturnBook.DataSource = ds.Tables[0];
                CreateUnboundButtonColumn(ds.Tables[0].Columns.Count, "已还");
            }
            catch (Exception xx)
            { }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBoxReturnBook.Text)) 
            {
                if (comboBoxReturnBook.Text == "已还书籍")
                {
                    dataReturnBook.Columns.Clear();
                    initBook();
                }
                else 
                {
                    dataReturnBook.Columns.Clear();
                    init();
                }
            }
        }

        private void CreateUnboundButtonColumn(int count,string text)
        {
            
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Operate";
            buttonColumn.HeaderText = "状态";
            buttonColumn.Text = text;
            buttonColumn.UseColumnTextForButtonValue = true;
            this.dataReturnBook.Columns.Insert(count, buttonColumn);
        }

        private void ReturnBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LibraryMain main = new LibraryMain();
            main.Show();
        }

        private void dataReturnBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string num = dataReturnBook.Rows[e.RowIndex].Cells[3].Value.ToString();
                string BookIndex = this.dataReturnBook.Rows[e.RowIndex].Cells[0].Value.ToString();
                string btuText = dataReturnBook.Rows[e.RowIndex].Cells[6].Value.ToString();
                if ((!string.IsNullOrEmpty(BookIndex)) && btuText.Equals("未还"))
                {
                    BookNumIndex = BookIndex;
                    BookNumName = dataReturnBook.Rows[e.RowIndex].Cells[1].Value.ToString();
                    BookNum = num;
                    ReturnBookMain returnmian = new ReturnBookMain(dataReturnBook);
                    returnmian.Show();
                }
            }
            catch (Exception x)
            { 
            
            }
          
        }

       
    }
}
