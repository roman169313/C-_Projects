using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_basic1
{
    public partial class frmwindow : Form
    {
        public frmwindow()
        {
            InitializeComponent();
        }



        private void btnDisplay_Click(object sender, EventArgs e)
        {
            double Gross, Discount, Total;
            Gross = 0;
            Discount = 0;
            Total = 0;
            int Pqty, Bqty, Sqty;
            Pqty = 0;
            Bqty = 0;
            Sqty = 0;
            try
            {
                if (chkPizza.Checked)
                {
                    Pqty = Convert.ToInt32(txtPQty.Text);
                    Gross = Gross + 1000 * Pqty;
                }
                if (chkBurger.Checked)
                {
                    Bqty = Convert.ToInt32(txtBQty.Text);
                    Gross = Gross + 600 * Bqty;
                }
                if (chkSoup.Checked)
                {
                    Sqty = Convert.ToInt32(txtSQty.Text);
                    Gross = Gross + 300 * Sqty;
                }
                if (chkMember.Checked){
                    Discount = Gross * 0.05;
                    Total = Gross - Discount;

                }
                else
                {
                    Discount = 0;
                    Total = Gross - Discount;
                }
                txtGross.Text = Gross.ToString();
                txtDiscount.Text=Discount.ToString();
                txtTotal.Text = Total.ToString();
            }
            catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkBurger.Checked= false;
            chkPizza.Checked = false;
            chkSoup.Checked = false;
            chkMember.Checked = false;
            txtBQty.Clear();
            txtPQty.Clear();
            txtSQty.Clear();
            txtDiscount.Clear();
            txtTotal.Clear();
            txtGross.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmwindow_Load(object sender, EventArgs e)
        {

        }
    }
}
