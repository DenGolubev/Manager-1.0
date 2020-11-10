using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_1._0
{
    /// <summary>
    /// Регистрация нового пользователя
    /// </summary>
    class Register
    {
        /// <summary>
        /// Свойства
        /// </summary>
        protected string F_Name { get; set; }
        protected string M_Name { get; set; }
        protected string L_Name { get; set; }
        protected string E_Mail { get; set; }
        protected string Login { get; set; }
        protected int Pass { get; set; }
        protected int N_Tab { get; set; }

        /// <summary>
        /// Получение логина
        /// </summary>
        /// <param name="e_mail"></param>
        /// <returns></returns>
        public string New_Register_log(string e_mail)
        {
            E_Mail = e_mail;
            Login = E_Mail;

            return Login;
        }

        /// <summary>
        /// Генерация пароля
        /// </summary>
        /// <param name="l_name"></param>
        /// <param name="f_name"></param>
        /// <param name="m_name"></param>
        /// <returns></returns>
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
