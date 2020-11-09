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
    public partial class Entrance : Form
    {
        My_Console Get_console = new My_Console();
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
            Task.Factory.StartNew(Get_console.Console);
        }

        
    }
}
