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
    public partial class AddBookKind : Form
    {
        public DataGridView datagrid;
        public AddBookKind(DataGridView datagrid)
        {
            InitializeComponent();
            this.datagrid = datagrid;
        }

        private void txtReset_Click(object sender, EventArgs e)
        {
            txtBookNum.Text = "";
            txtKindName.Text = "";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBookNum.Text) || string.IsNullOrEmpty(txtKindName.Text))
                {
                    MessageBox.Show(this, "书籍类型编号或名称不能为空!", "温馨提示");
                    return;
                }
                string sqlstr = "select * from BookKind where BookKindNum='" + txtBookNum.Text + "'";
                DataSet ds = DataBase.Query(sqlstr);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    string sql = "insert into BookKind (BookKindNum,Book_Category) values('" + txtBookNum.Text + "','" + txtKindName.Text + "')";
                    Boolean flag = DataBase.MyExeQuery(sql);
                    if (flag)
                    {
                        datagrid.Columns.Clear();
                        MessageBox.Show(this, "新增成功!", "温馨提示");
                        string sql1 = "select BookKindNum as 书籍类型编号, Book_Category as 书籍类型名称 from BookKind";
                        DataSet ds1 = DataBase.Query(sql1);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            datagrid.DataSource = ds1.Tables[0];
                        }
                        CreateUnboundButtonColumn();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "新增失败!", "温馨提示");
                    }
                }
                else
                {
                    MessageBox.Show(this, "该类型编号已存在!", "温馨提示");
                }
            }
            catch (Exception x)
            { }
        }

        private void CreateUnboundButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Operate";
            buttonColumn.HeaderText = "操作";
            buttonColumn.Text = "删除";
            buttonColumn.UseColumnTextForButtonValue = true;
            datagrid.Columns.Insert(2, buttonColumn);
        }

        private void AddBookKind_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void AddBookKind_Load(object sender, EventArgs e)
        {
            this.txtBookNum.Focus();
        }
    }
}
