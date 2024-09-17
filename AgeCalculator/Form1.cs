using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int  startday=0,endday=0,startmonth=0,endmonth=0,startyear=0,endyear=0,ageday=0,agemonth=0,ageyear=0;
            startday=Convert.ToInt32(txtStartDay.Text);
            startmonth = Convert.ToInt32(txtStartMonth.Text);
            startyear = Convert.ToInt32(txtStartYear.Text);
            endday=Convert.ToInt32(txtEndDay.Text);
            endmonth = Convert.ToInt32(txtEndMonth.Text);
            endyear=Convert.ToInt32(txtEndYear.Text);
            if (endyear < startyear)
            {
                MessageBox.Show("your enter wrong");
            }
            if (endday < startday)
            {
                ageday = 31 - (startday - endday);
                endmonth = endmonth - 1;
            }
            else
            {
                ageday = endday - startday;
            }
            if (endmonth < startmonth)
            {
                agemonth = 12 - (startmonth - endmonth);
                endyear = endyear - 1;
            }
            else
            {
                agemonth = endmonth - startmonth;
            }
            ageyear = endyear - startyear;
            txtAgeDay.Text = (ageday).ToString();
            txtAgeMonth.Text = (agemonth).ToString();
            txtAgeYear.Text = (ageyear).ToString();

        }
    }
}
