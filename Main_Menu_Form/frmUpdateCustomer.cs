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
namespace Main_Menu_Form
{
    
    public partial class frmUpdateCustomer : Form
    {
        private NewCustomer nc = new NewCustomer();
        public frmUpdateCustomer()
        {
            InitializeComponent();
            txtUpdateCustomerId.ReadOnly = true;
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            DisplayCustomerData();

        }
        public void DisplayCustomerData()
        {
            dgvUpdateCustomer.DataSource = nc.showCustomerRecord();
            dgvUpdateCustomer.ReadOnly = true;
            dgvUpdateCustomer.Refresh();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateCustomerId.Text == "")
            {
                MessageBox.Show("id not entered");
                return;
            }
            if (txtUpdateCustomerName.Text == "")
            {
                MessageBox.Show("NAME not enter");
                return;
            }
            if (txtUpdateAddress.Text == "")
            {
                MessageBox.Show("Address not enter");
                return;
            }
            if (txtUpdateMobileNo.Text == "")
            {
                MessageBox.Show("Mobile No not enter");
                return;
            }
            String id, Name, Address, MobileNo;
            
            id = (txtUpdateCustomerId.Text);
            Name = txtUpdateCustomerName.Text;
            Address = txtUpdateAddress.Text;
            MobileNo = txtUpdateMobileNo.Text;


            if (nc.UpdateCustomerRecord(id, Name, Address, MobileNo))
            {
                txtUpdateCustomerId.Text = "";
                txtUpdateCustomerName.Text = "";
                txtUpdateAddress.Text = "";
                txtUpdateMobileNo.Text = "";
                MessageBox.Show("Data entered");
                DisplayCustomerData();
            }
            else
            {
                MessageBox.Show("error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvUpdateCustomer.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUpdateCustomer.SelectedRows[0];
                txtUpdateCustomerId.Text = row.Cells[0].Value.ToString();
                txtUpdateCustomerName.Text = row.Cells[1].Value.ToString();
                txtUpdateAddress.Text = row.Cells[2].Value.ToString();
                txtUpdateMobileNo.Text = row.Cells[3].Value.ToString();
                


            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
