using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryBookIssue
{
    public class Student
    {
        public  DataTable showStudent()
        {
            DataTable dt = new DataTable();
            String sql = "SELECT * FROM Student";
            SqlDataAdapter da = new SqlDataAdapter(sql, Database.getConnection());
            try
            {
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;


        }
    }
}
