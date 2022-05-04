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
    public partial class progect07 : Form
    {
        public progect07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form3().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form4().Show();
        }
    }
}
