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
    public partial class frmAddCategory : Form
    {
        Category c = new Category();
        public frmAddCategory()
        {
            InitializeComponent();
            DisplayCategoryData();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryId.Text == "")
            {
                MessageBox.Show("id not entered");
                return;
            }
            if (textCategoryName.Text == "")
            {
                MessageBox.Show("Name not enter");
                return;
            }
            
            String catId, catName;
            catId = (txtCategoryId.Text);
            catName=textCategoryName.Text;
            

            if (c.AddCategoryRecord(catId, catName))
            {
                txtCategoryId.Text = "";
                textCategoryName.Text = "";
                DisplayCategoryData();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void DisplayCategoryData()
        {
            dgvCategory.DataSource = c.showCategoryRecord();
            dgvCategory.ReadOnly = true;
            dgvCategory.Refresh();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
