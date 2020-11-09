using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Net;
using System.Runtime.InteropServices;

namespace Manager_1._0
{
    class My_Console
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

        public void Console()
        {
            if (AllocConsole())
            {
                Register new_register = new Register();
                System.Console.WriteLine("Введите Фамилию:");
                string a = System.Console.ReadLine();
                System.Console.WriteLine("Введите Имя:");
                string b = System.Console.ReadLine();
                System.Console.WriteLine("Введите Отчество:");
                string c = System.Console.ReadLine();
                System.Console.WriteLine("Введите e-mail:");
                string f = System.Console.ReadLine();
                string d = a+b+c;
                string new_log = new_register.New_Register_log(f);
                int new_pass = new_register.New_Register_pass(a, b, c);
                System.Console.WriteLine("Вы ввели: {0} {1} {2}\nВаш логин в системе: {4}\nВаш код доступа: {3}", a, b, c, new_pass, new_log);
                
                FreeConsole();
            }
        }

    }
}
