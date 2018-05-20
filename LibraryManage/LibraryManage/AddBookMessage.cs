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
    public partial class AddBookMessage : Form
    {
        public AddBookMessage()
        {
            InitializeComponent();
            init();
        }

        private void label5_Click(object sender, EventArgs e)
        {
         
        }
        public void init()
        {
            string sql = "select BookKindNum,Book_Category from BookKind ";
            DataSet ds = DataBase.Query(sql);
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Book_Category";
            comboBox1.ValueMember = "BookKindNum";
            comboBox1.SelectedIndex = 0;
        }
        private void btuSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtNUM.Text))
                {
                    string sql = "insert into BookMessage (Book_num,Book_Name,Book_Author,Book_Publish,Book_Date,BookKindNum,Book_Introduction) values('" + txtNUM.Text + "','" + txtNAME.Text + "','" + txtAuthor.Text + "','" + txtPublish.Text + "','" + dateDATE.Value + "','" + comboBox1.SelectedValue.ToString() + "','" + txtIntro.Text + "')";
                    Boolean flag = DataBase.MyExeQuery(sql);
                    if (flag)
                    {
                        MessageBox.Show(this, "新增书籍成功!", "温馨提示");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "新增书籍失败!", "温馨提示");
                    }
                }
                else
                {
                    MessageBox.Show(this, "请完成填写数据!", "温馨提示");
                }
            }
            catch (Exception x)
            { }
        }

        private void AddBookMessage_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            LibraryMain libraryMain = new LibraryMain();
            libraryMain.Show();
        }

        private void AddBookMessage_Load(object sender, EventArgs e)
        {
            this.txtNUM.Focus();
        }
    }
}
