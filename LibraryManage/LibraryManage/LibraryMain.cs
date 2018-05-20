using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using AxWMPLib;

namespace LibraryManage
{
    public partial class LibraryMain : Form
    {
        public AxWindowsMediaPlayer windowsmedia;
        public LibraryMain(AxWindowsMediaPlayer windows)
        {
            InitializeComponent();
            string Rolename=Login.RoleName;
            this.windowsmedia = windows;
            if (!Rolename.Contains("管理员"))
            {
                this.AddUser.Visible = false;
                this.AddBookKind.Visible = false;
                this.AddBook.Visible = false;
                this.button1.Visible = false;
            }
        }
        public LibraryMain()
        {
            InitializeComponent();
            string Rolename = Login.RoleName;
            if (!Rolename.Contains("管理员"))
            {
                this.AddUser.Visible = false;
                this.AddBookKind.Visible = false;
                this.AddBook.Visible = false;
                this.button1.Visible = false;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            try
            {
                windowsmedia.Ctlcontrols.pause();
                System.Environment.Exit(0);
            }
            catch (Exception x)
            {
                Close();
            }

        }

        private void BorrowBook_Click(object sender, EventArgs e)
        {
            BorrowBook borrowBook = new BorrowBook();
            this.Close();
            borrowBook.Show();
        }

        private void btuReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBook returnBook = new ReturnBook();
            this.Hide();
            returnBook.Show();
        }

        private void BookMessage1_Click(object sender, EventArgs e)
        {
            BookMessage bookmessage = new BookMessage();
            bookmessage.Show();
            this.Hide();
        }

        private void AddBookKind_Click(object sender, EventArgs e)
        {
            BookKind Kind = new BookKind();
            Kind.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RoleMain addrole = new RoleMain();
            addrole.Show();
            this.Hide();
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            Users user = new Users();
            user.Show();
            this.Hide();
        }

        private void UpdatePWD_Click(object sender, EventArgs e)
        {
            UserMessage usemes = new UserMessage();
            usemes.Show();
            this.Hide();
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBookMessage addMess = new AddBookMessage();
            addMess.Show();
            this.Hide();
        }

        private void QueryAuthor_Click(object sender, EventArgs e)
        {
            BrrowBookCount brro = new BrrowBookCount();
            brro.Show();
            this.Hide();
        }

        private void LibraryMain_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();
        }

        private void QueryBook_Click(object sender, EventArgs e)
        {
            AddUser adduser = new AddUser();
            adduser.Show();
        }

        

       

      
    }
}
