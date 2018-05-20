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
    public partial class BookMessage : Form
    {
        public static string BookNumIndex;
        public BookMessage()
        {
            InitializeComponent();
        }

        private void BookMessage_Load(object sender, EventArgs e)
        {
            initCombox();
            initData();
           
        }

        public void initCombox()
        {
            string sql = "select Book_Category,BookKindNum from BookKind";
            DataSet ds = DataBase.Query(sql);
            comboBoxKind.DataSource = ds.Tables[0];
            comboBoxKind.DisplayMember = "Book_Category";
            comboBoxKind.ValueMember = "BookKindNum";
        }
        public void initData()
        {
            try
            {
                data_Book.Columns.Clear();
                string sqlData = "select Book_Num as 图书编号,Book_Name as 图书名称,Book_Author as 图书作者,Book_Publish as 图书出版社,Book_Category as 图书类别  from BookMessage,BookKind where BookKind.BookKindNum=BookMessage.BookKindNum";
                DataSet ds = DataBase.Query(sqlData);
                data_Book.DataSource = ds.Tables[0];
                CreateUnboundButtonColumn("查看", 5);
                if (Login.RoleName.Contains("管理员"))
                {
                    CreateUnboundButtonColumn("删除", 6);
                }
            }
            catch (Exception x)
            { }
         
        }

        private void IndexBooK_Click(object sender, EventArgs e)
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
        private void CreateUnboundButtonColumn(string text,int num)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Operate";
            buttonColumn.HeaderText = "操作";
            buttonColumn.Text = text;
            buttonColumn.UseColumnTextForButtonValue = true;
            this.data_Book.Columns.Insert(num, buttonColumn);
            
        }

        private void data_Book_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string BookIndex = data_Book.Rows[e.RowIndex].Cells[0].Value.ToString();
                string btuText = data_Book.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if ((!string.IsNullOrEmpty(BookIndex)) && btuText.Equals("查看"))
                {
                    BookNumIndex = BookIndex;
                    MessageBook messbook = new MessageBook();
                    messbook.Show();
                }
                else if (btuText.Equals("删除"))
                {
                    DialogResult dialog;
                    dialog = MessageBox.Show(this, "确认删除？", "温馨提示", MessageBoxButtons.OKCancel);
                    if (dialog == DialogResult.OK)
                    {
                        string sql = "delete * from BookMessage where Book_Num='" + BookIndex + "'";
                        Boolean flag = DataBase.MyExeQuery(sql);
                        if (flag)
                        {
                            MessageBox.Show("删除成功!");
                            BookIndex = "";
                            data_Book.Columns.Clear();
                            initData();

                        }
                        else
                        {
                            MessageBox.Show("删除失败!");
                            BookIndex = "";
                        }
                    }
                }

            }
            catch (Exception x)
            { }
        }

        private void BookMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LibraryMain library = new LibraryMain();
            library.Show();
        }
    }
}
