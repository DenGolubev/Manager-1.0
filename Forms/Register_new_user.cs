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
            Register new_register = new Register();
            string log = new_register.New_Register_log(textBox4.Text);
            int pass = new_register.New_Register_pass(textBox1.Text, textBox2.Text, textBox3.Text);
            string user = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text;
            int n_tab = Convert.ToInt32(textBox5.Text);
            Worker new_user = new Worker();
            new_user.in_array(user,log, pass, log);
            var message = (user, n_tab, log, pass);
            MessageBox.Show(Convert.ToString(message));
            
        }
    }
}
