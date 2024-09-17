using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Menu_Form
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void updateAllCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer f = new frmAddNewCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateCustomer f = new frmUpdateCustomer();
            f.MdiParent = this;
            f.Show();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddProduct f = new AddProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateProduct f = new frmUpdateProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void addNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCategory f = new frmAddCategory();
            f.MdiParent = this;
            f.Show();
        }

        private void updateCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateCategory frm = new frmUpdateCategory();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
