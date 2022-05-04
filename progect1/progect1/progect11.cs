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
    public partial class progect11 : Form
    {
        public progect11()
        {
            InitializeComponent();
            label2.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label2.Text = "Цена в выбранной комплектации: 15.000.000 руб";
                pictureBox1.Image = Properties.Resources.iris;
            }
            else if (radioButton2.Checked)
            {
                label2.Text = "Цена в выбранной комплектации: 5.000.000 руб";
                pictureBox1.Image = Properties.Resources.iris__1_;
            }
            else if (radioButton3.Checked)
            {
                label2.Text = "Цена в выбранной комплектации: 10.000.000 руб";
                pictureBox1.Image = Properties.Resources.iris__2_;
            }
        }
    }
}
