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
    public partial class progect05 : Form
    {
        public progect05()
        {
            InitializeComponent();
            label1.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text) - 50;
            if (c >= 50)
            {
                label1.Text = c.ToString() + "$";
                textBox1.Text = c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text) + 50;
            if (c >= 50)
            {
                label1.Text = c.ToString() + "$";
                textBox1.Text = c.ToString();
            }
        }
    }
}
