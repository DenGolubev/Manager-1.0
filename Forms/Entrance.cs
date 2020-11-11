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
using System.Data.SQLite;

namespace Manager_1._0
{
    public partial class Entrance : Form
    {
        DB_Manager manager_db = new DB_Manager();
        public Entrance()
        {
            InitializeComponent();
            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register_new_user new_User_form = new Register_new_user();
            new_User_form.Show();
            this.Hide();
        }

        private void Entrance_Load(object sender, EventArgs e)
        {
            manager_db.db();
        }
    }
}
