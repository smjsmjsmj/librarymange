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
    public partial class BookKind : Form
    {
        public BookKind()
        {
            InitializeComponent();
            init();
        }

        private void BookKind_Load(object sender, EventArgs e)
        {
           
        }
        public void init()
        {

            string sql = "select BookKindNum as 书籍类型编号, Book_Category as 书籍类型名称 from BookKind";
            DataSet ds = DataBase.Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                dataKind.DataSource = ds.Tables[0];
            }
            CreateUnboundButtonColumn();
        }

        private void CreateUnboundButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Operate";
            buttonColumn.HeaderText = "操作";
            buttonColumn.Text = "删除";
            buttonColumn.UseColumnTextForButtonValue = true;
            this.dataKind.Columns.Insert(2, buttonColumn);
        }

        private void dataKind_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult dialog;
                string BookIndex = dataKind.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(BookIndex) && BookIndex != "删除")
                {
                    dialog = MessageBox.Show(this, "确认删除?", "温馨提示", MessageBoxButtons.OKCancel);
                    if (dialog == DialogResult.OK)
                    {
                        string sql = "delete * from BookKind where BookKindNum='" + BookIndex + "'";
                        Boolean flag = DataBase.MyExeQuery(sql);
                        if (flag)
                        {
                            MessageBox.Show("删除成功!");
                            dataKind.Columns.Clear();
                            init();
                        }
                        else
                        {
                            MessageBox.Show("删除失败!");
                        }
                    }

                }
                else
                {
                    dataKind.Columns.Clear();
                    init();
                }
            }
            catch (Exception x)
            { }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            AddBookKind addKind = new AddBookKind(dataKind);
            addKind.Show();
        }

        private void BookKind_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LibraryMain libraryMain = new LibraryMain();
            libraryMain.Show();
        }

    }
}
