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
    public partial class progect08 : Form
    {
        public progect08()
        {
            InitializeComponent();
            label4.Text = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float size1 = Convert.ToInt32(textBox1.Text);
            float size2 = Convert.ToInt32(textBox2.Text);
            float price = (size1 / 100 * size2 / 100) * 5;

            if (comboBox1.SelectedIndex == 0) price += 1000;
            else if (comboBox1.SelectedIndex == 1) price += 1500;
            else MessageBox.Show("Выберите тип механизма ");

            if (checkBox1.Checked) price += 300;
            if (checkBox2.Checked) price += 2000;
            if (checkBox3.Checked) price += 500;

            label4.Text = "Сумма к оплате " + price + " рублей" ;
        }
    }
}
