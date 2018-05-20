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
    public partial class BorrowBook : Form
    {
        public static string BookNumIndex;
        public BorrowBook()
        {
            InitializeComponent();
            initCombox();
            initData();
            CreateUnboundButtonColumn();
        }
        public void initData()
        {
            try
            {
                string sqlData = "select Book_Num as 图书编号,Book_Name as 图书名称,Book_Author as 图书作者,Book_Publish as 图书出版社,Book_Category as 图书类别  from BookMessage,BookKind where BookKind.BookKindNum=BookMessage.BookKindNum";
                DataSet ds = DataBase.Query(sqlData);
                data_Book.DataSource = ds.Tables[0];
            }
            catch (Exception x)
            { }
        }
        public void initCombox()
        {
            try
            {
                string sql = "select Book_Category,BookKindNum from BookKind";
                DataSet ds = DataBase.Query(sql);
                comboBoxKind.DataSource = ds.Tables[0];
                comboBoxKind.DisplayMember = "Book_Category";
                comboBoxKind.ValueMember = "BookKindNum";
            }
            catch (Exception x)
            { }
        }

        private void IndexBook_Click(object sender, EventArgs e)
        {
            try
            {
                string str = "";
                if (!string.IsNullOrEmpty(comboBoxKind.Text))
                {
                    str = comboBoxKind.SelectedValue.ToString();
                }
                if (!string.IsNullOrEmpty(str))
                {
                    string sqlstr = "select Book_Num as 图书编号,Book_Name as 图书名称,Book_Author as 图书作者,Book_Publish as 图书出版社,Book_Category as 图书类别  from BookMessage,BookKind where BookKind.BookKindNum=BookMessage.BookKindNum and BookMessage.BookKindNum='" + str + "'";
                    DataSet ds = DataBase.Query(sqlstr);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        data_Book.DataSource = ds.Tables[0];
                    }
                }
                else
                {
                    initData();
                }
            }
            catch (Exception x)
            { }

        }


        private void CreateUnboundButtonColumn()
        {
            try
            {
                DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.Name = "Operate";
                buttonColumn.HeaderText = "操作";
                buttonColumn.Text = "借书";
                buttonColumn.UseColumnTextForButtonValue = true;
                this.data_Book.Columns.Insert(5, buttonColumn);
            }
            catch (Exception xx)
            { }
        }

        private void buttonColumn_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
                 string BookIndex = data_Book.Rows[e.RowIndex].Cells[1].Value.ToString();
                 string btuText = data_Book.Rows[e.RowIndex].Cells[0].Value.ToString();
                 if ((!string.IsNullOrEmpty(BookIndex)) && btuText.Equals("借书"))
                 {
                     BookNumIndex = BookIndex;
                     BorrowBookMain borrowMain = new BorrowBookMain();
                     borrowMain.Show();
                 }
            }
            catch (Exception xx)
                {
                
                }
            }

                   

        

        private void BorrowBook_Load(object sender, EventArgs e)
        {

        }

        private void BorrowBook_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Dispose();
            LibraryMain main = new LibraryMain();
            main.Show();
        }

      
    }
}
