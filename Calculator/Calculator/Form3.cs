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
    public partial class Form3 : Form
    {
        public Form3()
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


            // resenie so anomalija bidejki ako se vnesi neparen broj na karakteri poslednite 2 ne gi pisuva
            //if (textBox1.Text.Length >= 2)
            //    label1.Text = textBox1.Text.Substring(0, 2);
            //if (textBox1.Text.Length >= 4)
            //    label2.Text = textBox1.Text.Substring(2, 2);
            //if (textBox1.Text.Length >= 6)
            //    label3.Text = textBox1.Text.Substring(4, 2);
            //if (textBox1.Text.Length >= 8)
            //    label4.Text = textBox1.Text.Substring(6, 2);
            //if (textBox1.Text.Length >= 10)
            //    label5.Text = textBox1.Text.Substring(8, 2);
            //if (textBox1.Text.Length >= 12)
            //    label6.Text = textBox1.Text.Substring(10, 2);
            //if (textBox1.Text.Length >= 14)
            //    label7.Text = textBox1.Text.Substring(12, 2);

            if (textBox1.Text.Length >= 1)
                label1.Text = label1.Text + textBox1.Text.Substring(0, 1); // So subrstring zema od 0 do 1
            if (textBox1.Text.Length >= 2)
                label1.Text = label1.Text + textBox1.Text.Substring(1, 1);

            if (textBox1.Text.Length >= 3)
                label2.Text = label2.Text + textBox1.Text.Substring(2, 1);
            if (textBox1.Text.Length >= 4)
                label2.Text = label2.Text + textBox1.Text.Substring(3, 1);

            if (textBox1.Text.Length >= 5)
                label3.Text = label3.Text + textBox1.Text.Substring(4, 1);
            if (textBox1.Text.Length >= 6)
                label3.Text = label3.Text + textBox1.Text.Substring(5, 1);

            if (textBox1.Text.Length >= 7)
                label4.Text = label4.Text + textBox1.Text.Substring(6, 1).ToUpper();
            if (textBox1.Text.Length >= 8)
                label4.Text = label4.Text + textBox1.Text.Substring(7, 1).ToUpper();

            if (textBox1.Text.Length >= 9)
                label5.Text = label5.Text + textBox1.Text.Substring(8, 1);
            if (textBox1.Text.Length >= 10)
                label5.Text = label5.Text + textBox1.Text.Substring(9, 1);

            if (textBox1.Text.Length >= 11)
                label6.Text = label6.Text + textBox1.Text.Substring(10, 1);
            if (textBox1.Text.Length >= 12)
                label6.Text = label6.Text + textBox1.Text.Substring(11, 1);

            if (textBox1.Text.Length >= 13)
                label7.Text = label7.Text + textBox1.Text.Substring(12, 1);
            if (textBox1.Text.Length >= 14)
                label7.Text = label7.Text + textBox1.Text.Substring(13, 1);

            string xx = " simo simo".Replace(" ", string.Empty).ToUpper();
            //xx[0] = 'm';
            System.Text.StringBuilder sb = new System.Text.StringBuilder("Rat: the ideal pet").Replace(" ", string .Empty);
            sb[0] = 'C';


            label7.Text = "=" + sb + "=";

           
            // json 
            //Console.WriteLine($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            //Console.WriteLine($"He was first published in {jh.published} at the age of {jh.published - jh.born}.");
            //Console.WriteLine($"He'd be over {Math.Round((2018d - jh.born) / 100d) * 100d} years old today.");
           
            var jh = (firstName: "Anastas", lastName: "Acevski", born: 1989, published: 2000);
            MessageBox.Show($"{jh.firstName} {jh.lastName} was an African American poet born in {jh.born}.");
            MessageBox.Show($"He was first published in {jh.published} at the age of {jh.published - jh.born}."); // "ss" + (x1 - x2).ToString()
            MessageBox.Show($"He'd be over {Math.Round((2020d - jh.born) / 10d) * 10d} years old today.");

            // Output:
            // Jupiter Hammon was an African American poet born in 1711.
            // He was first published in 1761 at the age of 50.
            // He'd be over 300 years old today.


        }




    }
}
