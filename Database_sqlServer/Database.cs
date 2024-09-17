using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Database_sqlServer
{
    public class Database
    {
        private static SqlConnection conn;
        private static String connectionString = "Data Source=DESKTOP-PUNR6UV;Initial Catalog=Student;Integrated Security=True";
        public static SqlConnection GetConnection() {
            return conn;
        }
        public static void connection()
        {
            conn = new SqlConnection(connectionString);
            if(conn.State==ConnectionState.Closed)
            {
                try
                {
                    conn.Open();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("error: "+ ex.Message);

                }
                            }
            
        }
        public static void disconnect()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
