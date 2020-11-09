using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_1._0
{
    class Register
    {
        string F_Name { get; set; }
        string M_Name { get; set; }
        string L_Name { get; set; }
        string E_Mail { get; set; }
        string Login { get; set; }
        int Pass { get; set; }
        int N_Tab { get; set; }

        public string New_Register_log(string e_mail)
        {
            E_Mail = e_mail;
            Login = E_Mail;

            return Login;
        }

        public int New_Register_pass(string l_name, string f_name, string m_name)
        {
            F_Name = f_name;
            M_Name = m_name;
            L_Name = l_name;
            string a = F_Name + M_Name + L_Name;
            Pass = a.GetHashCode();
            return Pass;
        }


    }
}
