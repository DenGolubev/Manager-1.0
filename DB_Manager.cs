using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Manager_1._0
{
    class DB_Manager
    {
        public void db()
        {
            var db = new SQLiteConnection ("Manager.db", true);
             // do your work here
            db.Dispose();
        }
        
    }
}
