using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_2
{
    public partial class frmQuiz_2 : Form
    {
        public frmQuiz_2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            double  mid,final,session,p_marks,t_marks,s_marks;
            mid=final=session=p_marks=t_marks=s_marks=0;
            mid=Convert.ToDouble(txtMid.Text);
            final=Convert.ToDouble(txtFinal.Text);
            session = Convert.ToDouble(txtSessional.Text);
            t_marks = mid + final + session;
            s_marks = (p_marks * 0.3 + t_marks * 0.7);
            s_marks= Math.Ceiling(s_marks);
            t_marks= Math.Ceiling(t_marks);
            txtTheoryMarks.Text=t_marks.ToString();
            if (chkPractical.Checked) {
                p_marks = Convert.ToDouble(txtPracticalMarks.Text);
                
                txtSubjectTotal.Text = s_marks.ToString();
            }
            else
            {
                txtSubjectTotal.Text = null;
            }
            
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtFinal.Clear();
            txtMid.Clear();
            txtGp.Clear();
            txtPracticalMarks.Clear();
            txtSubjectTotal.Clear();
            txtSessional.Clear();
            txtTheoryMarks.Clear();
            txtSubjectTitle.Clear();
            txtSubjectId.Clear();
            chkPractical.Checked= false;
        }
    }
}
