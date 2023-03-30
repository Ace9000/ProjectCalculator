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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        int Brojac = 0;
        enum Season : int
        {
            Spring = 0,
            Summer = 1,
            D1 = 444,
            Winter = 5
        }
        enum Season2 : int
        {
            Spring,
            Summer,
            D1,
            Winter
        }
        public class CalendarEntry
        {

            // private field (Located near wrapping "Date" property).
            private DateTime _date;

            // Public property exposes _date field safely.
            public DateTime Date
            {
                get
                {
                    return _date;
                }
                set
                {
                    // Set some reasonable boundaries for likely birth dates.
                    if (value.Year > 1900 && value.Year <= DateTime.Today.Year)
                    {
                        _date = value;
                    }
                    else
                    {
                        throw new ArgumentOutOfRangeException("Date");
                    }
                }
            }

            // public field (Generally not recommended).
            public string? Day;

            // Public method also exposes _date field safely.
            // Example call: birthday.SetDate("1975, 6, 30");
            public void SetDateRoden(string dateString)
            {
                DateTime dt = Convert.ToDateTime(dateString);

                // Set some reasonable boundaries for likely birth dates.
                if (dt.Year > 1900 && dt.Year <= DateTime.Today.Year)
                {
                    _date = dt;
                    //MessageBox.Show(_date.ToShortDateString());
                }
                else
                {
                    throw new ArgumentOutOfRangeException("dateString");
                }
            }

            public TimeSpan GetDenoviOdRodendenotDosega(string dateString)
            {
                DateTime dt = Convert.ToDateTime(dateString);
                //MessageBox.Show(dt.ToShortDateString());

                if (dt.Ticks > _date.Ticks)
                {
                    return dt - _date;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("dateString");
                }
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            int a3 = 5, b3 = 4;
            if (a3 == b3)
            {
                
            }
            else
            {
                //goto kaj_substring;
                goto kaj_replace;
            }


            CalendarEntry birthday1 = new CalendarEntry();
            //birthday1.Day = "Saturday";
            birthday1.SetDateRoden("1995, 6, 30");
            TimeSpan xxx1 = birthday1.GetDenoviOdRodendenotDosega("1996, 6, 29");
            TimeSpan xxx2 = birthday1.GetDenoviOdRodendenotDosega(DateTime.Now.Year.ToString() + ", " +
                                                                  DateTime.Now.Month.ToString() + ", " +
                                                                  DateTime.Now.Day.ToString()
                );

            MessageBox.Show(xxx1.TotalDays.ToString() + "  " + xxx2.TotalDays.ToString());


            return;
            int a = 0;

            a = (int)Season.D1;

            int b = (int)Season2.D1;

            MessageBox.Show(a.ToString() + "  " + b.ToString());

            return;

            //////////////////////////////////////////////////////////////////////////////////////////////////
            kaj_substring:

            label1.Text = "";
            // "name: Anastas"
            int poz = -2;

            int aa = 4, bb = 4;
            if (aa == bb)
            {
                poz = textBox1.Text.IndexOf(": ");
            }
            //MessageBox.Show(poz.ToString());


            if (poz >= -1)
            {
                if (poz == -1)
                {
                    MessageBox.Show("Nema vakov string");
                    return;
                }
                else
                {
                    MessageBox.Show("Ima vakov string, i zapocnuva so index = " + poz.ToString());
                }

                // "name: Anastas"
                // ovde poz = 4
                // dolzina = 13
                int dolzina = textBox1.Text.Length;

                // PocSubstring  = 4 + 2 = 6
                int PocSubstring = poz + 2;
                int DolzinaSubstr = dolzina - PocSubstring;        // dolzina - (poz + 2) = 7 t.e. go ispisuva 'Anastas'

                label1.Text = textBox1.Text.Substring(PocSubstring, DolzinaSubstr);

                MessageBox.Show("Vo substring-ot zede  Pocetok=" + PocSubstring.ToString() + "  i Dolzina=" + DolzinaSubstr.ToString());

            }
            else
            {
                MessageBox.Show("ne barase pozicija");
                return;
            }


        //////////////////////////////////////////////////////////////////////////////////////////////////
        kaj_replace:
            MessageBox.Show("sega e kaj :  kaj_replace");

            //string xstr = textBox1.Text.ToLower();
            //xstr = "a b c d e";
            //xstr = xstr.Trim();

            label1.Text = "=" + textBox1.Text.TrimStart() + "=";

            //label1.Text = textBox1.Text.ToLower().Replace("anastas", "simo").Replace(" ","");

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
           
        }
    }
}
