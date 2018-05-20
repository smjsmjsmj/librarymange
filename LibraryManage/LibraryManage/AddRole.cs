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
    public partial class AddRole : Form
    {
        public DataGridView datagrid;
        public AddRole(DataGridView datagrid)
        {
            InitializeComponent();
            this.datagrid = datagrid;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtRole.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtRole.Text))
                {
                    MessageBox.Show(this, "角色编号或名称不能为空!", "温馨提示");
                    return;
                }
                string sql = "select * from Role where RoleNum='" + txtRole.Text + "'";
                DataSet ds = DataBase.Query(sql);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    string sqlstr = "insert into Role (RoleNum,RoleName) values('" + txtRole.Text + "','" + txtName.Text + "')";
                    Boolean flag = DataBase.MyExeQuery(sqlstr);
                    if (flag)
                    {
                        MessageBox.Show(this, "新增成功!", "温馨提示");
                        this.Close();
                        datagrid.Columns.Clear();
                        init();
                    }
                    else
                    {
                        MessageBox.Show(this, "新增失败!", "温馨提示");
                    }
                }
                else
                {
                    MessageBox.Show(this, "该角色编号已存在!", "温馨提示");
                }
            }
            catch (Exception x)
            { }
        }

        public void init()
        {
            string sql = "select RoleNum as 角色编号,RoleName as 角色名称 from Role";
            DataSet ds = DataBase.Query(sql);
            datagrid.DataSource = ds.Tables[0];
            CreateUnboundButtonColumn();
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

        private void AddRole_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

    }
}
