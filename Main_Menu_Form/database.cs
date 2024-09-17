using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Menu_Form
{
    public class database
    {
        private static SqlConnection cn;
        public static SqlConnection GetConnection()
        {
            return cn;
        }
        public static void Connect()
        {
            cn = new SqlConnection("Data Source=DESKTOP-9HU6DH7;Initial Catalog=Store;Integrated Security=True");
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static void Disconnect()
        {
            cn.Close();
        }
    }
}
