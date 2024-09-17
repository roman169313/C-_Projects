using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shopping
{
    public partial class frmShopping : Form
    {
        public frmShopping()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            double GrossAmt, Discount, NetAmt;
            GrossAmt = 0;
            Discount = 0;
            NetAmt = 0;

            if (chkPizza.Checked)
                GrossAmt = GrossAmt + 1000;
            if (chkLays.Checked)
                GrossAmt = GrossAmt + 60;
            if (chkTea.Checked)
                GrossAmt = GrossAmt + 40;
            if (chkMembership.Checked)
                Discount = GrossAmt * 0.05;
            else
                Discount = 0;
            NetAmt = GrossAmt - Discount;

            txtGrossAmount.Text = GrossAmt.ToString();
            txtDiscount.Text = Discount.ToString();
            txtNetAmount.Text = NetAmt.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkPizza.Checked = false;
            chkLays.Checked = false;
            chkTea.Checked = false;
            chkMembership.Checked = false;

            txtGrossAmount.Clear();
            txtDiscount.Clear();
            txtNetAmount.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
