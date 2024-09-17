using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace Main_Menu_Form
{
    public class NewCustomer
    {
        public bool AddCustomerRecord(String id, String Name, String address, String mobile)
        {
            String sql = "INSERT INTO AddCustomerTable(CustomerId,CustomerName,Address,MobileNo) VALUES(@id,@Name,@address,@mobile)";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = database.GetConnection();  
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@address",address );
            command.Parameters.AddWithValue("@mobile",mobile);
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
        public bool UpdateCustomerRecord(String id, String Name, String address, String mobile)
        {
            String sql = "UPDATE AddCustomerTable SET CustomerId=@id,CustomerName=@Name,Address=@address,MobileNo=@mobile where CustomerId=@id";
            SqlCommand command = new SqlCommand();
            command.Connection = database.GetConnection();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
          
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@address", address);
            command.Parameters.AddWithValue("@mobile", mobile);
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
        public bool DeleteCustomerRecord(int id)
        {
            String sql = "DELETE FROM AddCustomerTable WHERE CustomerId=@id";
            SqlCommand command = new SqlCommand();
            command.Connection = database.GetConnection();
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
        public DataTable showCustomerRecord()
        {
            String sql = "SELECT * FROM AddCustomerTable";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, database.GetConnection());
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
