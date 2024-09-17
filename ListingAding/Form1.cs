using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListingAding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String text = null;
        
        private void lba_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            text = txtAdd.Text;

            if (text!=null)
            {
                lstAdd.Items.Add(text);
                txtAdd.Text= null;
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            int i;
            text = txtAdd.Text;
            bool find = false;
            for(i=0;i<lstAdd.Items.Count;i++)
            {
                if (text == lstAdd.Items[i].ToString())
                {
                    find = true;
                  
                    break;
                }
                else
                {
                    find = false;
                }
            }
            if (find == true)
            {
                lstMatch.Items.Add(text);
                txtAdd.Text = null;
            }
            else
            {
                lstUnmatch.Items.Add(text);
                txtAdd.Text = null;
            }
            
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string str;
            for(int i=0;i<lstUnmatch.Items.Count;i++)
            {
                 str = lstUnmatch.Items[i].ToString();
                lstAdd.Items.Add(str);
                
            }
            lstUnmatch.Items.Clear();
        }
    }
}
