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
    public class book
    {
        public bool updateBook(String id)
        {
            String sql = "update Book set Status=\'N\' Where BookId=@id";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText= sql;
            cmd.CommandType=CommandType.Text;
            cmd.Connection = Database.getConnection();
            cmd.Parameters.AddWithValue("@id", id);
            int n=cmd.ExecuteNonQuery();
            bool success = true;
            if (n > 0)
            {
                success = true;
            }
            else success = false;
            return success;
        }
        public DataTable showBook()
        {
            DataTable dt = new DataTable();
            String sql = "SELECT * FROM Book WHERE Status = \'A\'";
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
