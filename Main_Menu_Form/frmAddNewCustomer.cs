using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Main_Menu_Form
{
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }
        private NewCustomer nc = new NewCustomer();
        public void DisplayCustomerData()
        {
            dgvCustomer.DataSource= nc.showCustomerRecord();
            dgvCustomer.ReadOnly = true;
            dgvCustomer.Refresh();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCustomerId.Text == "")
            {
                MessageBox.Show("id not entered");
                return;
            }
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("NAME not enter");
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Address not enter");
                return;
            }
            if (txtMobileNo.Text == "")
            {
                MessageBox.Show("Mobile No not enter");
                return;
            }
            String id, Name, Address, MobileNo;
            id = (txtCustomerId.Text);
            Name = txtCustomerName.Text;
            Address= txtAddress.Text;
            MobileNo = txtMobileNo.Text;
           

            if (nc.AddCustomerRecord(id, Name, Address, MobileNo))
            {
                txtCustomerId.Text = "";
                txtCustomerName.Text = "";
                txtAddress.Text = "";
                txtMobileNo.Text = "";
                MessageBox.Show("Data entered");
                DisplayCustomerData();
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {
            DisplayCustomerData();

        }
    }
}
