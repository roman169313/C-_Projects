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
    public class StoreUser
    {
        private SqlCommand cmd;
        public bool loginCheck(String username, String password)
        {
            String sql = "SELECT * FROM Store_User WHERE userId=@username and password=@password";
            cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = database.GetConnection();
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable dt = new DataTable();
            bool login = false;
            try
            {
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    login = true;
                }
                else
                {
                    login = false;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return login;

        }
    }
}
