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
    public partial class AddProduct : Form
    {
        Category c = new Category();
        Product p = new Product();
        int CatId = 0;
        bool Starting = true;
        public AddProduct()
        {
            InitializeComponent();
        }
        void DisplayProductData()
        {
            dgvProduct.DataSource = p.showProductRecord();
            dgvProduct.ReadOnly = true;
            dgvProduct.Refresh();
            
        }
        
        void FillCategoryCombo()
        {
            cbCategoryId.DataSource = c.showCategoryRecord();
            cbCategoryId.ValueMember = "CatId";
        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            DisplayProductData();
            FillCategoryCombo();
            Starting = false;
            
        }

        private void cbCategoryId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Starting!=true)
            {
                CatId = Convert.ToInt32(cbCategoryId.SelectedValue.ToString());
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
        }

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtProductId.Text == "")
            {
                MessageBox.Show("id not entered");
                return;
            }
            if (txtDescription.Text == "")
            {
                MessageBox.Show("Description not enter");
                return;
            }
            if (txtUnitPrice.Text == "")
            {
                MessageBox.Show("Unit Price not enter");
                return;
            }
            if (txtQty.Text == "")
            {
                MessageBox.Show("Qty not enter");
                return;
            }
            String pid, description, unitPrice, qty, brand, categoryId;
            pid = (txtProductId.Text);
            description = txtDescription.Text;
            unitPrice = txtUnitPrice.Text;
            qty = txtQty.Text;
            brand = txtBrand.Text;
            categoryId = cbCategoryId.Text;

            if (p.AddProduct(pid, description, unitPrice, qty, brand, categoryId))
            {
                txtProductId.Text = "";
                txtDescription.Text = "";
                txtUnitPrice.Text = "";
                txtQty.Text = "";
                txtBrand.Text = "";
                MessageBox.Show("Data entered");
                DisplayProductData();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
