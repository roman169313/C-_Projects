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
using System.Data;

namespace Database_sqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database.disconnect();
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database.connection();
            DispData();
        }
        public void DispData()
        {
            grdStudent.DataSource=student.GetData();
            grdStudent.ReadOnly=true;
            grdStudent.Refresh();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int rollno, marks;
            String name;
            if (txtRoll.Text == "")
            {
                MessageBox.Show("Roll no Not entered");
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Name is not entered");
                return;
            }
            if (txtMarks.Text == "")
            {
                MessageBox.Show("Marks not entered");
                return;
            }
            rollno = Convert.ToInt32(txtRoll.Text);
            name = txtName.Text;
            marks = Convert.ToInt32(txtMarks.Text);
            if(student.addData(rollno, name, marks))
            {
                txtMarks.Text = "";
                txtRoll.Text = "";
                txtName.Text = "";
                DispData();
                MessageBox.Show("data added successfully");
            }
            else
            {
                MessageBox.Show("Data not entered ");
            }
            
        }
    }
}
