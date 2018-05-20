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
    public partial class MessageBook : Form
    {
        public MessageBook()
        {
            InitializeComponent();
        }

        private void MessageBook_Load(object sender, EventArgs e)
        {
            initData();
        }
        public void initData() 
        {
            try
            {
                string sql = "select BookMessage.Book_Num,Book_Name,Book_Author,Book_Publish,Book_Date,Book_Introduction,BookKind.Book_Category from BookMessage,BookKind where BookMessage.BookKindNum=BookKind.BookKindNum and BookMessage.Book_Num='" + BookMessage.BookNumIndex + "'";
                DataSet ds = DataBase.Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Book_Num.Text = ds.Tables[0].Rows[0][0].ToString();
                    BookName.Text = ds.Tables[0].Rows[0][1].ToString();
                    BookAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
                    Publish.Text = ds.Tables[0].Rows[0][3].ToString();
                    date.Text = ds.Tables[0].Rows[0][4].ToString();
                    richTextBox1.Text = ds.Tables[0].Rows[0][5].ToString();
                    KindNum.Text = ds.Tables[0].Rows[0][6].ToString();
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
