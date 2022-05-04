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
    public partial class progect01 : Form
    {
        public progect01()
        {
            InitializeComponent();
            label3.Text = null;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int price = 0;
            if (radioButton1.Checked) price = 12;
            else if (radioButton2.Checked) price = 24;
            else if (radioButton3.Checked) price = 59;

            int count = Convert.ToInt32(textBox1.Text);
            label3.Text = (count * price).ToString();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            int sym = Convert.ToInt32(textBox1.Text);
            sym = sym + 1;
            textBox1.Text = sym.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            int sym = Convert.ToInt32(textBox1.Text);
            sym = sym - 1;
            textBox1.Text = sym.ToString();
        }
    }
}
