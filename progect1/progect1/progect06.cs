using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progect1
{
    public partial class progect06 : Form
    {
        public progect06()
        {
            InitializeComponent();
            label3.Text = null;
        }

        private bool check_Login(string login, string password)
        {
            if (login == "admin" && password == "admin") return true;
            else if (login == "root" && password == "root") return true;
            else if (login == "student" && password == "password") return true;

            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            label3.Text = "";
            if (check_Login(login, password))
            {
                Form form = new Next();
                form.Show();
                this.Hide();
            }
            else
            {
                label3.Text = "Неправильный логин и/или пароль";
            }
        }
    }
}
