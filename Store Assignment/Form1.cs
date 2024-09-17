using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store_Assignment
{
    public partial class Form1 : Form
    {
        Store st = new Store();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void DisplayRecord()
        {
            dgvStore.DataSource = st.showRecord();
         //   dgvStore.ReadOnly=true;
            dgvStore.Refresh();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Database.Connect();
            DisplayRecord();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Description not entered");
                return;
            }
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Brand not enter");
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("qUanttity not enter");
                return;
            }
            if (txtSIze.Text == "")
            {
                MessageBox.Show("Size not enter");
                return;
            }
            String desc, brand, quantity, size,price;
            int id;
            id = Convert.ToInt32(txtId.Text);
            desc = txtDesc.Text;
            brand = txtBrand.Text;
            quantity = txtQuantity.Text;
            size = txtSIze.Text;
            price = (txtPrice.Text);
            
                if (st.AddRecord(id,desc,brand,quantity,size,price))
                {
                txtId.Text = "";
                txtDesc.Text = "";
                txtBrand.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
                txtSIze.Text = "";
                DisplayRecord();
                    MessageBox.Show("Data entered");
                }
                else
                {
                MessageBox.Show("error");
                }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("ROll no not entered");
                return;
            }
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Description not entered");
                return;
            }
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Brand not enter");
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("qUanttity not enter");
                return;
            }
            if (txtSIze.Text == "")
            {
                MessageBox.Show("Size not enter");
                return;
            }
            String desc, brand, quantity, size, price;
            int id;
            id = Convert.ToInt32(txtId.Text);
            desc = txtDesc.Text;
            brand = txtBrand.Text;
            quantity = txtQuantity.Text;
            size = txtSIze.Text;
            price = (txtPrice.Text);

            if (st.UpdateRecord(id, desc, brand, quantity, size, price))
            {
                txtId.Text = "";
                txtDesc.Text = "";
                txtBrand.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
                txtSIze.Text = "";
                DisplayRecord();
                MessageBox.Show("Data updated");
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Database.Disconnect();
            Application.Exit();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dgvStore.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvStore.SelectedRows[0];
                txtId.Text = row.Cells[0].Value.ToString();
                txtDesc.Text = row.Cells[1].Value.ToString();
                txtBrand.Text = row.Cells[2].Value.ToString();
                txtSIze.Text = row.Cells[3].Value.ToString();
                txtQuantity.Text = row.Cells[4].Value.ToString();
                txtPrice.Text = row.Cells[5].Value.ToString();


            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtDesc.Text = "";
            txtBrand.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtSIze.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("ROll no not entered");
                return;
            }
            if (txtDesc.Text == "")
            {
                MessageBox.Show("Description not entered");
                return;
            }
            if (txtBrand.Text == "")
            {
                MessageBox.Show("Brand not enter");
                return;
            }
            if (txtQuantity.Text == "")
            {
                MessageBox.Show("qUanttity not enter");
                return;
            }
            if (txtSIze.Text == "")
            {
                MessageBox.Show("Size not enter");
                return;
            }
            
            int id;
            id = Convert.ToInt32(txtId.Text);
            
            if (st.DeleteRecord(id))
            {
                txtId.Text = "";
                txtDesc.Text = "";
                txtBrand.Text = "";
                txtPrice.Text = "";
                txtQuantity.Text = "";
                txtSIze.Text = "";
                DisplayRecord();
                MessageBox.Show("Data deleted");
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}

