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
    public class student
    {
        
        private static SqlDataAdapter adapter;
        public static bool addData(int rollno,String name,int marks)
        {
            String sql = "INSERT INTO Student(rollno,name,marks) VALUES(@rollno,@name,@marks);";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = Database.GetConnection();
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@rollno", rollno);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@marks", marks);
            bool success= false;
            try
            {
               int n= command.ExecuteNonQuery();
                if(n>0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }catch(SqlException ex)
            {
                MessageBox.Show("error: " + ex.Message);
                success = false;
            }
            return success;
        }
        public static DataTable GetData()
        {
            String sql = "SELECT * FROM Student;";
            adapter = new SqlDataAdapter(sql , Database.GetConnection());
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return dt;

        }
    }
}
