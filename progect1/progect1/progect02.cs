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
    public partial class progect02 : Form
    {
        public progect02()
        {
            InitializeComponent();
            label5.Text = null;
        }

        private void progect2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float b = Convert.ToInt32(textBox2.Text);

            float r = (a / 100) * b;
            label5.Text = r.ToString() + " Л/100км";
        }
    }
}
