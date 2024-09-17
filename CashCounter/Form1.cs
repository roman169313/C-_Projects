using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCounter
{
    public partial class frmHblBzuMultan : Form
    {
        public frmHblBzuMultan()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTwenty_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int amount;
            int fiveth=0, oneth=0, fiveh= 0, oneh = 0, fifty = 0, twenty = 0, ten = 0, five = 0, two = 0, one = 0;
            amount = Convert.ToInt32(txtAmount.Text);
            if(amount>=5000)
            {
                fiveth = Convert.ToInt32(amount / 5000);
                amount = amount - (5000*fiveth);

            }
           
            if (amount >= 1000)
            {
                oneth = Convert.ToInt32(amount / 1000 );
                amount = amount - (1000*oneth);

            }
           
            if (amount >= 500)
            {
                fiveh = Convert.ToInt32(amount / 500);
                amount = amount - (500*fiveh);

            }
            if (amount >= 100)
            {
                oneh = Convert.ToInt32(amount / 100);
                amount = amount - (100*oneh);

            }
            if (amount >= 50)
            {
                fifty = Convert.ToInt32(amount / 50 );
                amount = amount - (50*fifty);

            }
            if (amount >= 20)
            {
                twenty = Convert.ToInt32(amount / 20 );
                amount = amount - (20*twenty);

            }
            if (amount >= 10)
            {
                ten = Convert.ToInt32(amount / 10 );
                amount = amount - (10*ten);

            }
            if (amount >= 5)
            {
                five = Convert.ToInt32(amount / 5 );
                amount = amount - (5*five);

            }
            if (amount >= 2)
            {
                two = Convert.ToInt32(amount / 2 );
                amount = amount - (2*two);

            }
            if (amount >= 1)
            {
                one = Convert.ToInt32(amount / 1 );
                amount = amount - (1*one);

            }
            txtFiveTh.Text = fiveth.ToString();
            txtTenTh.Text =  oneth.ToString();
            txtFiveH.Text = fiveh.ToString();
            txtTenH.Text = oneh.ToString();
            txtFifty.Text = fifty.ToString();
            txtTwenty.Text = twenty.ToString();
            txtTen.Text = ten.ToString();
            txtFive.Text = five.ToString();
            txtTwo.Text = two.ToString();
            txtOne.Text = one.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
