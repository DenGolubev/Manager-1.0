using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_1._0
{
    class User: Register
    {
        protected string Department { get; set; }
        protected string Position { get; set; }

        public void User_Card(string department, string position)
        {
            Department = department;
            Position = position;


        }

    }
}
