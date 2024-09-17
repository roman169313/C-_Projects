using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Store_Assignment
{
    public class Database
    {
        private static SqlConnection connection;

        public static SqlConnection getConnection()
        {
            return connection;
        }
        public static void Connect()
        {
            connection = new SqlConnection("Data Source=DESKTOP-PUNR6UV;Initial Catalog=Store;Integrated Security=True");
            try
            {
                connection.Open();
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void Disconnect()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
