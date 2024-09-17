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
    public class BookIssue
    {
        public bool AddBookIssue(String id,String rollno,String Bid,String date)
        {
            String sql = "INSERT INTO BookIssue(BookIssueId,RollNo,BookId,IssueDate) VALUES(@id,@rollno,@Bid,@date)";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Database.getConnection();
            cmd.CommandText = sql;
            cmd.CommandType= CommandType.Text;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@rollno", rollno);
            cmd.Parameters.AddWithValue("@Bid", Bid);
            cmd.Parameters.AddWithValue("@date", date);
            int n = cmd.ExecuteNonQuery();
            bool success = true;
            if (n > 0)
            {
                success=true;
            }
            else success= false;
            return success;
        }
        public DataTable showBookIssue()
        {
            DataTable dt = new DataTable();
            String sql = "SELECT * FROM BookIssue";
            SqlDataAdapter da = new SqlDataAdapter(sql,Database.getConnection());
            try
            {
                da.Fill(dt);
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;


        }
        public String getNextIssueId()

        {
            String sql = "SELECT ISNULL(MAX(BookIssueId),0) +1 FROM BookIssue";
            SqlDataAdapter da = new SqlDataAdapter(sql, Database.getConnection());
            DataTable dt = new DataTable();
            da.Fill(dt);
            String issueId = (dt.Rows[0][0].ToString());
            return issueId;
        }
    }
}
// fOR INCREMENT...
//SELECT MAX(BookIssueId) +1 FROM BookIssue;
//ghcsbzu@gmail.com