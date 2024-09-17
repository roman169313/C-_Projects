using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main_Menu_Form
{
    public class Category
    {
        public bool AddCategoryRecord(String CatId, String CatName)
        {
            String sql = "INSERT INTO Category(CatId,CatName) VALUES(@CatId,@CatName)";
            SqlCommand command = new SqlCommand();
            command.CommandText = sql;
            command.Connection = database.GetConnection();
            command.Parameters.AddWithValue("@CatId", CatId);
            command.Parameters.AddWithValue("@CatName", CatName);
            
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
        public bool UpdateCategoryRecord(String CatId, String CatName)
        {
            String sql = "UPDATE Category SET CatId=@CatId,CatName=@CatName where CatId=@CatId";
            SqlCommand command = new SqlCommand();
            command.Connection = database.GetConnection();
            command.CommandText = sql;
            command.CommandType = CommandType.Text;

            command.Parameters.AddWithValue("@CatId", CatId);
            command.Parameters.AddWithValue("@CatName", CatName);
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
        public bool DeleteCategoryRecord(int CatId)
        {
            String sql = "DELETE FROM Category WHERE CatId=@CatId";
            SqlCommand command = new SqlCommand();
            command.Connection = database.GetConnection();
            command.CommandText = sql;
            command.Parameters.AddWithValue("@CatId", CatId);
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
        public DataTable showCategoryRecord()
        {
            String sql = "SELECT * FROM Category";
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
