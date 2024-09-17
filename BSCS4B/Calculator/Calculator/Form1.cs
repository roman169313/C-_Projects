using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCal : Form
    {
        public frmCal()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add your code here

            double first, second, result;

            try
            {
                first = Convert.ToDouble(txtFirstNum.Text);
                second = Convert.ToDouble(txtSecondNum.Text);

                result = first + second;
                txtResult.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double first, second, result;

            try
            {
                first = Convert.ToDouble(txtFirstNum.Text);
                second = Convert.ToDouble(txtSecondNum.Text);

                result = first - second;
                txtResult.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double first, second, result;

            try
            {
                first = Convert.ToDouble(txtFirstNum.Text);
                second = Convert.ToDouble(txtSecondNum.Text);

                result = first * second;
                txtResult.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double first, second, result;

            try
            {
                first = Convert.ToDouble(txtFirstNum.Text);
                second = Convert.ToDouble(txtSecondNum.Text);

                result = first / second;
                txtResult.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstNum.Clear();  
            //txtFirstNum.Text ="";
            txtSecondNum.Clear();
            txtResult.Clear();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        //    this.Close();

        }
    }
}
