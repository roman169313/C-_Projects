using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookIssue
{
    public partial class Form1 : Form
    {

        String RollNo = "";
        String BookId = "";
        book b = new book();
        Student s = new Student();
        BookIssue bi = new BookIssue();
        bool starting = true;
        public void combobox()
        {
            cbRollNo.DataSource = s.showStudent();
            cbRollNo.ValueMember = "RollNo";
            cbBookId.DataSource = b.showBook();
            cbBookId.ValueMember = "BookId";
        }
        
        public void display()
        {
            dgvBookIssue.DataSource = bi.showBookIssue();
            dgvBookIssue.ReadOnly = true;
            dgvBookIssue.Refresh();
        }
        public Form1()
        {
            InitializeComponent();
            Database.connection();

        }

        

        

        private void cbRollNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (starting != true)
            {
                RollNo = cbRollNo.SelectedValue.ToString();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            display();
            combobox();
            txtBookIssueId.Text=bi.getNextIssueId();
            starting = false;
        }

        private void cbBookId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (starting != true)
            {
                BookId = cbBookId.SelectedValue.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Database.disconnection();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtBookIssueId.Text == "")
            {
                MessageBox.Show("id not entered");
                return;
            }
            if (cbRollNo.Text == "")
            {
                MessageBox.Show("Roll no not enter");
                return;
            }
            if (cbBookId.Text == "")
            {
                MessageBox.Show("book id not enter");
                return;
            }
            if (dtpIssueDate.Text == "")
            {
                MessageBox.Show("date not enter");
                return;
            }
            String id, rollno, bid, date;
            id = (txtBookIssueId.Text);
            rollno = cbRollNo.Text;
            bid = cbBookId.Text;
            date = dtpIssueDate.Text;


            if (bi.AddBookIssue(id, rollno, bid, date) && (b.updateBook(bid)))
            {
                txtBookIssueId.Text = "";
                cbRollNo.Text = "";
                cbBookId.Text = "";
                dtpIssueDate.Text = "";
                MessageBox.Show("Data entered");
                display();
                combobox();
                txtBookIssueId.Text = bi.getNextIssueId();
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
