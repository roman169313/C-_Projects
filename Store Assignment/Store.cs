using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace Store_Assignment
{
    public class Store
    {
       public bool AddRecord(int id,String Desc,String Brand,String Size,String Quantity,String Price)
        {
            String sql = "INSERT INTO Store(Pid,\"Desc\",Brand,Size,Quantity,Price) VALUES(@id,@Desc,@Brand,@Size,@Quantity,@Price)";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = Database.getConnection();
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Desc", Desc);
            command.Parameters.AddWithValue("@Brand", Brand);
            command.Parameters.AddWithValue("@Size", Size);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@Price", Price);
            bool success = false;
            try
            {
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public bool UpdateRecord(int id, String Desc, String Brand, String Size, String Quantity, String Price)
        {
            String sql = "UPDATE Store SET Pid=@id,\"Desc\"=@Desc,Brand=@Brand,Size=@Size,Quantity=@Quantity,Price=@Price where Pid=@id";
            SqlCommand command = new SqlCommand();
            command.Connection = Database.getConnection();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Desc", Desc);
            command.Parameters.AddWithValue("@Brand", Brand);
            command.Parameters.AddWithValue("@Size", Size);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@Price", Price);
            bool success = false;
            try
            {
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public bool DeleteRecord(int id)
        {
            String sql = "DELETE FROM Store WHERE Pid=@id";
            SqlCommand command = new SqlCommand();
            command.Connection = Database.getConnection();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@id", id);
            bool success = false;
            try
            {
                int n = command.ExecuteNonQuery();
                if (n > 0)
                {
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return success;
        }
        public DataTable showRecord()
        {
            String sql = "SELECT * FROM Store";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, Database.getConnection());
            try
            {
                da.Fill(dt);
            }catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;

        }
    }
}

