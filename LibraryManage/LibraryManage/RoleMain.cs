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
    public partial class RoleMain : Form
    {
        public RoleMain()
        {
            InitializeComponent();
            init();
        }

        private void RoleMain_Load(object sender, EventArgs e)
        {

        }
        public void init()
        {
            string sql = "select RoleNum as 角色编号,RoleName as 角色名称 from Role";
            DataSet ds = DataBase.Query(sql);
            dataRole.DataSource = ds.Tables[0];
            CreateUnboundButtonColumn();
        }

        private void CreateUnboundButtonColumn()
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.Name = "Operate";
            buttonColumn.HeaderText = "操作";
            buttonColumn.Text = "删除";
            buttonColumn.UseColumnTextForButtonValue = true;
            dataRole.Columns.Insert(2, buttonColumn);
        }

        private void dataRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DialogResult dialog;
                string RoleIndex = dataRole.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (!string.IsNullOrEmpty(RoleIndex))
                {
                    dialog = MessageBox.Show(this, "确认删除?", "温馨提示", MessageBoxButtons.OKCancel);
                    if (dialog == DialogResult.OK)
                    {
                        string sql = "delete * from Role where RoleNum='" + RoleIndex + "'";
                        Boolean flag = DataBase.MyExeQuery(sql);
                        if (flag)
                        {
                            MessageBox.Show("删除成功!");
                            dataRole.Columns.Clear();
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

        private void button1_Click(object sender, EventArgs e)
        {
            AddRole addrole = new AddRole(dataRole);
            addrole.Show();
        }

        private void RoleMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LibraryMain libraryMain = new LibraryMain();
            libraryMain.Show();
        }
    }
}
