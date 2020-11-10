using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_1._0
{
    class Worker: Register
    {
        protected string Department { get; set; } // Отдел  
        protected string Position { get; set; } // Должность
        protected string Education { get; set; } // Образование
        protected int Experience { get; set; } // Опыт работы (Время на данной должности)
        protected int Productivity { get; set; } //Уровень продуктивности 1-10
        protected int Adaptation { get; set; } //Уровень адаптации 1-10
        protected bool Overtime { get; set; } //Работа во внеурочное время (да/нет)
        protected int Literacy { get; set; }  //Грамотность 1-10
        protected int Organizational_skills { get; set; } //Организаторские способности 1-10
        protected bool Ability_to_communicate { get; set; } //Коммуникативность (да/нет)
        protected bool Teamwork { get; set; } //Работа в комманде (да/нет)
        string[] user_array = new string [20];

        public void User_Card(string department, string position)
        {
            Department = department;
            Position = position;


        }

        public void in_array(string user, string log, int pass, string e_mail)
           {
           for(int i = 0; i < user_array.Length; i++)
            {
                user_array[i] = user + " " + log + " " + pass + " " + e_mail;
            } 
        }

        public void out_array()
        {

        }

    }
}
