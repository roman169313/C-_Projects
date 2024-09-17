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
    public partial class frmUpdateCategory : Form
    {
        Category c = new Category();
        public frmUpdateCategory()
        {
            InitializeComponent();
            DisplayCategoryData();
            txtUpdateCategoryId.ReadOnly = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUpdateCategory.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUpdateCategory.SelectedRows[0];
                txtUpdateCategoryId.Text = row.Cells[0].Value.ToString();
                textUpdateCategoryName.Text = row.Cells[1].Value.ToString();
               



            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateCategoryId.Text == "")
            {
                MessageBox.Show("id not entered");
                return;
            }
            if (textUpdateCategoryName.Text == "")
            {
                MessageBox.Show("NAME not enter");
                return;
            }
            
            String id, Name;

            id = (txtUpdateCategoryId.Text);
            Name = textUpdateCategoryName.Text;
            


            if (c.UpdateCategoryRecord(id, Name))
            {
                txtUpdateCategoryId.Text = "";
                textUpdateCategoryName.Text = "";
              
                MessageBox.Show("Data entered");
                DisplayCategoryData();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void DisplayCategoryData()
        {
            dgvUpdateCategory.DataSource = c.showCategoryRecord();
            dgvUpdateCategory.ReadOnly = true;
            dgvUpdateCategory.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
