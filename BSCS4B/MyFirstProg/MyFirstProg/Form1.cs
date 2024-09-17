using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProg
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // add your code here
            MessageBox.Show("Welcome every body in C# Class");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // add your code here
            Application.Exit();
            // this.Close();

        }
    }
}
