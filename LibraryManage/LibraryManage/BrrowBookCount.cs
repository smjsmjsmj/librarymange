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
    public partial class BrrowBookCount : Form
    {
        public BrrowBookCount()
        {

            InitializeComponent();
            init();
        }

        private void BrrowBookCount_Load(object sender, EventArgs e)
        {
        }
        public void init()
        {
            try
            {
                string sql = "select count(*) as 数量,BookKind.Book_Category as 书籍类型名称 from BorrowBook,BookKind,BookMessage where BookMessage.BookKindNum=BookKind.BookKindNum and BorrowBook.Book_num=BookMessage.Book_num group by BookKind.Book_Category";
                DataSet ds = DataBase.Query(sql);
                chart1.DataSource = ds.Tables[0];
                chart1.DataBind();
                chart1.Series["Series1"].XValueMember = "书籍类型名称";
                chart1.Series["Series1"].YValueMembers = "数量";
                chart1.Series["Series1"].LegendText = "书籍类型数量";
            }
            catch (Exception x)
            { }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void BrrowBookCount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LibraryMain libraryMain = new LibraryMain();
            libraryMain.Show();
        }
    }
}
