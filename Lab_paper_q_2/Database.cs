using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Lab_paper_q_2
{
    public class Database
    {
        private static SqlConnection cn;
        public static SqlConnection getConnection()
        {
            return cn;
        }
        public static void Connection()
        {
            cn = new SqlConnection("Data Source=DESKTOP-PUNR6UV;Initial Catalog=Patient;Integrated Security=True");
            try
            {
                if (cn.State == ConnectionState.Closed)
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
