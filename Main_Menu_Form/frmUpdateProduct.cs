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
    public partial class frmUpdateProduct : Form
    {
        Category c = new Category();
        Product p = new Product();
        int CatId = 0;
        bool Starting = true;
        public frmUpdateProduct()
        {
            InitializeComponent();
            FillCategoryCombo();
            DisplayProductData();
            txtUpdateProductId.Text = "";
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUpdateProductId.Text == "")
            {
                MessageBox.Show("id not entered");
                return;
            }
            if (txtUpdateDescription.Text == "")
            {
                MessageBox.Show("Description not enter");
                return;
            }
            if (txtUpdateUnitPrice.Text == "")
            {
                MessageBox.Show("Unit Price not enter");
                return;
            }
            if (txtUpdateQty.Text == "")
            {
                MessageBox.Show("Qty not enter");
                return;
            }
            String pid, description, unitPrice, qty, brand, categoryId;
            pid = (txtUpdateProductId.Text);
            description = txtUpdateDescription.Text;
            unitPrice = txtUpdateUnitPrice.Text;
            qty = txtUpdateQty.Text;
            brand = txtUpdateBrand.Text;
            categoryId = cbUpdateCategoryId.Text;

            if (p.UpdateProductRecord(pid, description, unitPrice, qty, brand, categoryId))
            {
                txtUpdateProductId.Text = "";
                txtUpdateDescription.Text = "";
                txtUpdateUnitPrice.Text = "";
                txtUpdateQty.Text = "";
                txtUpdateBrand.Text = "";
                MessageBox.Show("Data entered");
                DisplayProductData();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUpdateProduct.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUpdateProduct.SelectedRows[0];
                txtUpdateProductId.Text = row.Cells[0].Value.ToString();
                txtUpdateDescription.Text = row.Cells[1].Value.ToString();
                txtUpdateUnitPrice.Text = row.Cells[2].Value.ToString();
                txtUpdateQty.Text = row.Cells[3].Value.ToString();
                txtUpdateBrand.Text = row.Cells[4].Value.ToString();
                cbUpdateCategoryId.Text = row.Cells[5].Value.ToString();



            }

        }
        void DisplayProductData()
        {
            dgvUpdateProduct.DataSource = p.showProductRecord();
            dgvUpdateProduct.ReadOnly = true;
            dgvUpdateProduct.Refresh();

        }

        void FillCategoryCombo()
        {
            cbUpdateCategoryId.DataSource = c.showCategoryRecord();
            cbUpdateCategoryId.ValueMember = "CatId";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
