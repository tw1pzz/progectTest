﻿using System;
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
    public partial class progect03 : Form
    {
        public progect03()
        {
            InitializeComponent();
            label5.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(textBox2.Text);
            int summa = 1;
            if (comboBox1.SelectedIndex == 0)
            {
                summa = 300 * k;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                summa = 500 * k;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                summa = 700 * k;
            }
            label5.Text = (summa).ToString() + " Руб";
        }
    }
}
