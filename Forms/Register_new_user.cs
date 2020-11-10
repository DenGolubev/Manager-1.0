using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manager_1._0
{
    public partial class Register_new_user : Form
    {
        public Register_new_user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrance entrance_form = new Entrance();
            entrance_form.Show();
            this.Hide();

        }
    }
}
