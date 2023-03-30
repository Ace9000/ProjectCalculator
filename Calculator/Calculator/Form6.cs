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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] niza1 = textBox1.Text.Split('*');

            goto kaj_for;

            //listanje na elementi od nizata 'niza1' so pomos na 'foreach'
            foreach (string n in niza1)
            {
                MessageBox.Show(n);

                if (n.Contains('/'))
                {
                    MessageBox.Show("Ima simbol '/'");
                    string[] niza2 = n.Split('/');
                    //listanje na elementi od nizata 'niza2' so pomos na 'foreach'
                    foreach (string nn in niza2)
                    {
                        MessageBox.Show(nn);
                    }
                }
                else
                {
                    MessageBox.Show("Nema simbol '/'");
                }
            }
            return;

            kaj_for:

            //listanje na elementi od nizata 'niza1' so pomos na 'for'
            for (int i = 0; i < niza1.Length; i++)
            {
                MessageBox.Show(niza1[i]);

                if (niza1[i].Contains('/'))
                {
                    MessageBox.Show("Ima simbol '/'");
                    string[] niza2 = niza1[i].Split('/');
                    //listanje na elementi od nizata 'niza2' so pomos na 'for'
                    for (int ii = 0; ii < niza2.Length; ii++)
                    {
                        MessageBox.Show(niza2[ii]);
                    }
                }
                else
                {
                    MessageBox.Show("Nema simbol '/'");
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 5;
            string xx = "simo";

            MessageBox.Show("vo button2_Click  metoda ova e" + "  a=" + a.ToString() + "  xx=" + xx);

            //MessageBox.Show($"vo button2_Click  metoda ova e  a={a}  xx={xx}");
            string poraka = $"vo button2_Click  metoda ova e  a={a}  xx={xx}";
            MessageBox.Show(poraka);



        }


    }
}
