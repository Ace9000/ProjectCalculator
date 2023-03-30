using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";

            if (textBox1.Text.Length >= 1) 
                label1.Text = textBox1.Text.Substring(0, 1);
            if (textBox1.Text.Length >= 2)
                label2.Text = textBox1.Text.Substring(1, 1);
            if (textBox1.Text.Length >= 3)
                label3.Text = textBox1.Text.Substring(2, 1);
            if (textBox1.Text.Length >= 4)
                label4.Text = textBox1.Text.Substring(3, 1);
            if (textBox1.Text.Length >= 5)
                label5.Text = textBox1.Text.Substring(4, 1);
            if (textBox1.Text.Length >= 6)
                label6.Text = textBox1.Text.Substring(5, 1);
            if (textBox1.Text.Length >= 7)
                label7.Text = textBox1.Text.Substring(6, 1);

        }

    }
}
