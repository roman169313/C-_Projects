using Main_Menu_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StoreUser su = new StoreUser();
            if (txtUserId.Text == "")
            {
                MessageBox.Show("user id is not entered");
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Password Not Entered");
                return;
            }
            String userId, Password;
            userId = txtUserId.Text;
            Password = txtPassword.Text;
            if (su.loginCheck(userId, Password))
            {
                MessageBox.Show("Login Successfull");
                frmMain f = new frmMain();
                this.Hide();
                f.Show();
            }
            else
            {
                MessageBox.Show("Data entered Is Unmatched");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            database.Disconnect();
            Application.Exit();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            database.Connect();

        }
    }
}
