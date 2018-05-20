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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            init();
        }
        public void init() 
        {
            try
            {
                dataUser.Columns.Clear();
                string sql = "select UserName as 登入名,Name as 姓名,Sex as 性别,Class as 班级,Profeession as 专业,Grade as 年级,RoleName as 角色名称  from Users,Role where Users.RoleNum=Role.RoleNum ";
                DataSet ds = DataBase.Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    dataUser.DataSource = ds.Tables[0];
                }
                CreateUnboundButtonColumn();
            }
            catch (Exception x)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtLGName.Text))
                {
                    string sql = "select UserName as 登入名,Name as 姓名,Sex as 性别,Class as 班级,Profeession as 专业,Grade as 年级,RoleName as 角色名称  from Users,Role where Users.RoleNum=Role.RoleNum and UserName='" + txtLGName.Text + "'";
                    DataSet ds = DataBase.Query(sql);
                    dataUser.DataSource = ds.Tables[0];
                }
                else
                {
                    init();
                }
            }
            catch (Exception xx)
            { }
        }
        private void CreateUnboundButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Operate";
            buttonColumn.HeaderText = "操作";
            buttonColumn.Text = "删除";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataUser.Columns.Insert(7, buttonColumn);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser(dataUser);
            adduser.Show();
        }

        private void dataUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult dialog;
                string RoleIndex = dataUser.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(RoleIndex))
                {
                    dialog = MessageBox.Show(this, "确认删除?", "温馨提示", MessageBoxButtons.OKCancel);
                    if (dialog == DialogResult.OK)
                    {
                        string sql = "delete * from Users where UserName='" + RoleIndex + "'";
                        Boolean flag = DataBase.MyExeQuery(sql);
                        if (flag)
                        {
                            MessageBox.Show("删除成功!");
                            dataUser.Columns.Clear();
                            init();
                        }
                        else
                        {
                            MessageBox.Show("删除失败!");
                        }
                    }

                }
            }
            catch (Exception x)
            { }
        }

        private void Users_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LibraryMain libraryMain = new LibraryMain();
            libraryMain.Show();
        }
    }
}
