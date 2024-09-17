using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LibraryBookIssue
{

    public class Database
    {
        private static SqlConnection cn;
        public static SqlConnection getConnection()
        {
            return cn;
        }
        public static void connection()
        {
            cn = new SqlConnection("Data Source=DESKTOP-9HU6DH7;Initial Catalog=bookIssue;Integrated Security=True");
            try
            {
                if (cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void disconnection()
        {
            cn.Close();
        }

    }
}
