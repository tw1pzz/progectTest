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
    public partial class progect04 : Form
    {
        public progect04()
        {
            InitializeComponent();
            label4.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox1.Text);
            int summa = 1;
            if (comboBox1.SelectedIndex == 0)
            {
                summa = 12 * k;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                summa = 24 * k;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                summa = 59 * k;
            }
            label4.Text = (summa).ToString() + " Руб";
        }
    }
}
