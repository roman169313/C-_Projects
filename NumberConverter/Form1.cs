using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtWord.Text = " ";
            txtNum.Text = " ";
        }
        
            string[] tenMap = {"zero","ten","twenty","thirty","forty","fifty"
            ,"sixty","seventy","eighty","ninty"};
            string[] unitMap = {"zero","one","two","Three","Four"
            ,"Five","Six","seven","Eight","Nine","ten","Eleven"
            ,"twelve","Thirteen","Fourteen"
            ,"Fifteen","Sixteen","seventeen","Eighteen","Nineteen"};
         public String wordReturn(int a)
        {
            if(a<20)
            {
                String y= unitMap[a]; 
                return y;
            }
            else
            {
                int b;
                b = a;
                a = a / 10;
                b=b%10;
                return tenMap[a] + " " + unitMap[b]; 
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String word = " ";
            int part;
            Int64 Number;
            Number= Convert.ToInt64( txtNum.Text);
            if (Number > 10000000) {
               part=Convert.ToInt32( Number / 10000000);
                word = word + wordReturn(part) + " Crore ";
                Number %= 10000000;
            }
            if (Number > 100000)
            {
                part = Convert.ToInt32(Number / 100000);
                word = word + wordReturn(part) + " lac ";
                Number %= 100000;
            }
            if (Number > 1000)
            {
                part = Convert.ToInt32(Number / 1000);
                word = word + wordReturn(part) + " Thousand ";
                Number %= 1000;
            }
            if (Number > 100)
            {
                part = Convert.ToInt32(Number / 100);
                word = word + wordReturn(part) + " Hundred ";
                Number %= 100;
            }
            if (Number > 20)
            {
                part = Convert.ToInt32(Number);
                word = word + wordReturn(part);
            }
            if (Number < 20)
            {
                part = Convert.ToInt32(Number);
                word = word + wordReturn(part);
               
            }
            txtWord.Text = word;
        }
    }
}
