using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace loginForm
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
            cn = new SqlConnection("Data Source=DESKTOP-PUNR6UV;Initial Catalog=Store;Integrated Security=True");
            try
            {
                if (cn.State==ConnectionState.Closed)
                {
                    cn.Open();
                }
            }catch(SqlException e)
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
