using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Main_Menu_Form
{
    public class Product
    {
        public bool AddProduct(String id, String Desc, String price, String Quantity,String brand,String catId)
        {
            String sql = "INSERT INTO Product(ProdId,Description,UnitPrice,Qty,Brand,CatId) VALUES(@id,@Desc,@price,@Quantity,@brand,@catId)";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = database.GetConnection();
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Desc", Desc);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@CatId", catId);
            command.Parameters.AddWithValue("@brand", brand);

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
        public bool UpdateProductRecord(String id, String Desc, String price, String Quantity, String brand, String catId)
        {
            String sql = "UPDATE Product SET ProdId=@id,Description=@Desc,UnitPrice=@price,Qty=@Quantity,Brand=@brand,CatId=@catId where ProdId=@id";
            SqlCommand command = new SqlCommand();
            command.Connection = database.GetConnection();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@Desc", Desc);
            command.Parameters.AddWithValue("@price", price);
            command.Parameters.AddWithValue("@Quantity", Quantity);
            command.Parameters.AddWithValue("@CatId", catId);
            command.Parameters.AddWithValue("@brand", brand);
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
        public bool DeleteProductRecord(int id)
        {
            String sql = "DELETE FROM Product WHERE ProdId=@id";
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
        public DataTable showProductRecord()
        {
            String sql = "SELECT * FROM Product";
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
