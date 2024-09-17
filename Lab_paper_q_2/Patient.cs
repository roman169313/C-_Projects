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
    public class Patient
    {
        public bool AddRecord(int id,String Name,String Disease, String HospitalName,String RoomNo,int Age)
        {
            String sql = "INSERT INTO Patient(PatientId,Name,Disease,HospitalName,RoomNo,Age) VALUES(@id,@Name,@Disease,@HospitalName,@RoomNo,@Age)";
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = Database.getConnection();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("id", id);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Disease", Disease);
            cmd.Parameters.AddWithValue("@HospitalName", HospitalName);
            cmd.Parameters.AddWithValue("@RoomNo", RoomNo);
            cmd.Parameters.AddWithValue("@Age", Age);
      
            int n=cmd.ExecuteNonQuery();
            bool Success = false;
            try
            {
                if (n > 0)
                {
                    Success = true;
                    
                }
                else
                {
                    Success = false;
                }

            }catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return Success;
        }
        public DataTable ShowAllRecord()
        {
            String sql = "SELECT * FROM Patient";
            SqlDataAdapter da = new SqlDataAdapter(sql, Database.getConnection());
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }
        public DataTable ShowSomeRecord()
        {
            String sql = "SELECT * FROM Patient WHERE Age>50 AND Disease='Sugar'";
            SqlDataAdapter da = new SqlDataAdapter(sql, Database.getConnection());
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }
    }
}
