using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.Entity;

namespace SQLite_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQLiteConnection con=new SQLiteConnection("Data Source= database.db; Version = 3; New = True; Compress = True; ");
            //@(C:\Users\Roman Ahmad\Desktop\project c#\SQLite_database\bin\Debug)


            try
            { con.Open();
                MessageBox.Show("connection established;");
            }
            catch  {
                MessageBox.Show("db con can not open");
            }
            
            SQLiteCommand sqlitecommand1 = con.CreateCommand();
            sqlitecommand1.CommandText = "INSERT INTO Brand(rollno,name) VALUES(1,'roman');";
            sqlitecommand1.ExecuteNonQuery();
            SQLiteDataReader sqliteDataReader;
            SQLiteCommand sqliteCommand2 = con.CreateCommand();
            sqliteCommand2.CommandText = "SELECT rollno FROM Brand;";
            sqliteDataReader = sqliteCommand2.ExecuteReader();
            while (sqliteDataReader.Read())
            {
                MessageBox.Show( sqliteDataReader.GetString(1) );

            }
            con.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
