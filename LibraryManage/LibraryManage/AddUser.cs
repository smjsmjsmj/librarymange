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
    public partial class AddUser : Form
    {
        public static string sex = "男";
        public  DataGridView datagrid;
        public AddUser()
        {
            InitializeComponent();
            btuQurey.Visible = true;
            reset.Visible = false;
            Save.Visible = false;
            this.Text = "查看个人信息";
            initQurey();
        }

        public AddUser(DataGridView datagrid)
        {
            InitializeComponent();
            btuQurey.Visible = false;
            reset.Visible = true;
            Save.Visible = true;
            this.datagrid = datagrid;
            initRole();
        }
        public void initQurey()
        {
            try
            {
                string sql = "select UserName as 登入名,Name as 姓名,Sex as 性别,Class as 班级,Profeession as 专业,Grade as 年级,RoleName as 角色名称  from Users,Role where Users.RoleNum=Role.RoleNum and UserName='" + Login.LoginName + "'";
                DataSet ds = DataBase.Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.txtLoginName.Text = ds.Tables[0].Rows[0][0].ToString();
                    this.txtLoginName.Enabled = false;
                    this.txtName.Text = ds.Tables[0].Rows[0][1].ToString();
                    this.txtName.Enabled = true;
                    if (ds.Tables[0].Rows[0][2].ToString() == "男")
                    {
                        radioButton1.Checked = true;
                        radioButton2.Checked = false;
                    }
                    else
                    {
                        radioButton2.Checked = true;
                        radioButton1.Checked = false;
                    }
                    this.radioButton2.Enabled = true;
                    this.radioButton1.Enabled = true;
                    this.txtClass.Text = ds.Tables[0].Rows[0][3].ToString();
                    this.txtClass.Enabled = true;
                    this.txtPro.Text = ds.Tables[0].Rows[0][4].ToString();
                    this.txtPro.Enabled = true;
                    this.txtGra.Text = ds.Tables[0].Rows[0][5].ToString();
                    this.txtGra.Enabled = true;
                    this.RoleNum.Text = ds.Tables[0].Rows[0][6].ToString();
                    this.RoleNum.Enabled = true;
                }
            }
            catch (Exception x)
            { }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RoleNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void initRole()
        {
            string sql = "select RoleName,RoleNum from Role";
            DataSet ds = DataBase.Query(sql);
            RoleNum.DataSource = ds.Tables[0];
            RoleNum.DisplayMember = "RoleName";
            RoleNum.ValueMember = "RoleNum";
            RoleNum.SelectedIndex = 0;
        }

        private void AddUser_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                sex = "男";
            }
            else 
            {
                sex = "女";
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            txtLoginName.Text = "";
            txtName.Text = "";
            txtPro.Text = "";
            txtGra.Text = "";
            txtClass.Text = "";
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            RoleNum.SelectedIndex = 0;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLoginName.Text))
                {
                    MessageBox.Show(this, "请输入登入名!", "温馨提示");
                    return;
                }
                string sql = "select * from Users where UserName='" + txtLoginName.Text + "'";
                DataSet ds = DataBase.Query(sql);
                if (ds.Tables[0].Rows.Count <= 0)
                {
                    string str = "insert into Users (UserName,Name,Sex,Class,Profeession,Grade,RoleNum) values ('" + txtLoginName.Text + "','" + txtName.Text + "','" + sex + "','" + txtClass.Text + "','" + txtPro.Text + "','" + txtGra.Text + "','" + RoleNum.SelectedValue.ToString() + "');";
                    Boolean flag = DataBase.MyExeQuery(str);
                    if (flag)
                    {
                        MessageBox.Show(this, "新增用户成功!", "温馨提示");
                        this.Close();
                        init();
                    }
                    else
                    {
                        MessageBox.Show(this, "新增用户失败!", "温馨提示");
                    }
                }
                else
                {
                    MessageBox.Show(this, "已存在该用户!", "温馨提示");

                }
            }
            catch (Exception x)
            { }
        }

        public void init()
        {
            try
            {
                datagrid.Columns.Clear();
                string sql = "select UserName as 登入名,Name as 姓名,Sex as 性别,Class as 班级,Profeession as 专业,Grade as 年级,RoleName as 角色名称  from Users,Role where Users.RoleNum=Role.RoleNum ";
                DataSet ds = DataBase.Query(sql);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    datagrid.DataSource = ds.Tables[0];
                }
                CreateUnboundButtonColumn();
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
            datagrid.Columns.Insert(7, buttonColumn);
        }

        private void AddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btuQurey_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
