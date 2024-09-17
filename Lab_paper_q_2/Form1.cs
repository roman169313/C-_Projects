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

namespace Lab_paper_q_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.patientDataSet.Patient);
            Database.Connection();
        }
        Patient p = new Patient();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("enter id");
                return;
            }
            if (txtName.Text=="")
            {
                MessageBox.Show("enter Name");
                return;
            }
            if (txtDisease.Text == "")
            {
                MessageBox.Show("enter Disease");
                return;
            }
            if (txtHospitalName.Text == "")
            {
                MessageBox.Show("enter hospital Name");
                return;
            }
            if (txtRoomNo.Text == "")
            {
                MessageBox.Show("enter Room no");
                return;
            }
            if (txtAge.Text == "")
            {
                MessageBox.Show("enter Age");
                return;
            }
            int age,id;
            String Name, Disease, HospitalName, RoomNo;
            age = Convert.ToInt32(txtAge.Text);
            id = Convert.ToInt32(txtId.Text);
            Disease = txtDisease.Text;
            Name = txtName.Text;
            HospitalName = txtHospitalName.Text;
            RoomNo = txtRoomNo.Text;
            try
            {
                if (p.AddRecord(id,Name, Disease, HospitalName, RoomNo, age))
                {

                    txtId.Text = "";
                    txtAge.Text = "";
                    txtDisease.Text = "";
                    txtHospitalName.Text = "";
                    txtName.Text = "";
                    txtRoomNo.Text = "";
                    dgvPatient.Refresh();
                    
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            dgvPatient.DataSource = p.ShowAllRecord();
            dgvPatient.ReadOnly = true;
            dgvPatient.Refresh();
        }

        private void btnDisplayConditional_Click(object sender, EventArgs e)
        {
            dgvPatient.DataSource = p.ShowSomeRecord();
            dgvPatient.ReadOnly = true;
            dgvPatient.Refresh();

        }
    }
}
