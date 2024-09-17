using System;
using System.Data.SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace new
{
    public SQLiteConnection myConnection;
    internal class Database
    {
         myConnection = new SQLiteConnection("Data Source=Database.sqlite3");

    }
}
