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
    public partial class progect09 : Form
    {
        public progect09()
        {
            InitializeComponent();
            label2.Text = null;
        }

        private void progect9_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float a = Convert.ToInt32(textBox1.Text);
            float price = 0;

            if (radioButton1.Checked) price = (a * 20) + 1000;
            if (radioButton2.Checked) price = (a * 20);

            label2.Text = "Цена за км " + price + " руб";
        }
    }
}
