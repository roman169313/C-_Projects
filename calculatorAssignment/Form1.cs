using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculatorAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double FirstNumber;
        char op;

        private void button4_Click(object sender, EventArgs e)
        {
            txtScreen.Text = txtScreen.Text + "0";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if(txtScreen.Text=="0") {
                txtScreen.Text = "1";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "1";
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = "2";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "2";
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = "3";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "3";
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = "4";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "4";
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = "5";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = "6";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "6";
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = "7";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "7";
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = "8";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "8";
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = "9";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + "9";
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtScreen.Text == "0" && txtScreen.Text != null)
            {
                txtScreen.Text = ".";
            }
            else
            {
                txtScreen.Text = txtScreen.Text + ".";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                FirstNumber = Convert.ToDouble(txtScreen.Text);
                op = '+';
                txtScreen.Text = "0";
            
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {

            FirstNumber = Convert.ToDouble(txtScreen.Text);
            op = '-';
            txtScreen.Text = "0";

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {

            FirstNumber = Convert.ToDouble(txtScreen.Text);
            op = '*';
            txtScreen.Text = "0";

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {

            FirstNumber = Convert.ToDouble(txtScreen.Text);
            op = '/';
            txtScreen.Text = "0";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtScreen.Text = null;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double Result;
            if (op == '+')
            {
                Result = FirstNumber + Convert.ToDouble(txtScreen.Text);
                txtScreen.Text = Result.ToString();
            }
            if (op == '-')
            {
                Result = FirstNumber - Convert.ToDouble(txtScreen.Text);
                txtScreen.Text = Result.ToString();
            }
            if (op == '*')
            {
                Result = FirstNumber * Convert.ToDouble(txtScreen.Text);
                txtScreen.Text = Result.ToString();
            }
            if (op == '/')
            {
                if (txtScreen.Text == "0")
                {
                    txtScreen.Text = "Error";

                }
                else
                {
                    Result = FirstNumber / Convert.ToDouble(txtScreen.Text);
                    txtScreen.Text = Result.ToString();
                }
              
            }

        }
    }
}
