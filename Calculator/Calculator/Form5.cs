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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "...";
            txtDenovi.Text = "";

            Int32 iDenovi = 0;

            // 111 pretvoranje na 'string' vo 'broj' so 'Try ... catch'
            //try
            //{
            //    iDenovi = Convert.ToInt32(txtDenovi.Text);
            //}
            //catch { iDenovi = 1; txtDenovi.Text = "1"; }


            // 222 pretvoranje na 'string' vo 'broj' so 'TryParse'
            bool bOk = Int32.TryParse(txtDenovi.Text, out iDenovi);
            if (bOk)
            {
                //MessageBox.Show("Ok");
                toolStripStatusLabel2.Text = "Ok";
            }
            else
            {
                //MessageBox.Show("nee   Ok");
                toolStripStatusLabel2.Text = "nee Ok";
            }


            dtp_Valuta.Value = DateTime.Today.AddDays(iDenovi);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        private void dtp_Data_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Vnesi DATA ...";
        }

        private void txtDenovi_Enter(object sender, EventArgs e)
        {
            txtDenovi.BackColor = Color.Yellow;
            toolStripStatusLabel2.Text = "Vnesi denovi ...";
        }
        private void txtDenovi_Leave(object sender, EventArgs e)
        {
            txtDenovi.BackColor = Color.White;
            Int32 iDenovi = 0;
            bool bOk = Int32.TryParse(txtDenovi.Text, out iDenovi);
            if (bOk)
            {
                //MessageBox.Show("Ok");
                toolStripStatusLabel2.Text = "Ok";
            }
            else
            {
                //MessageBox.Show("nee   Ok");
                toolStripStatusLabel2.Text = "nee Ok";
            }

            dtp_Valuta.Value = DateTime.Today.AddDays(iDenovi);

        }
        private void dtp_Valuta_Enter(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = "Vnesi VALUTA ...";
        }

        private void dtp_Valuta_Leave(object sender, EventArgs e)
        {
            // ne raboti bidejki : satot, min, a posebno sekundite se razlicni na dvete promenlivi
            //var RazlDenovi = (dtp_Valuta.Value - dtp_Data.Value).TotalDays;
            //txtDenovi.Text = RazlDenovi.ToString();

            // ne raboti bidejki : satot, min, a posebno sekundite se razlicni na dvete promenlivi
            //TimeSpan t = dtp_Valuta.Value - dtp_Data.Value;
            //double NrOfDays = t.TotalDays;
            //txtDenovi.Text = NrOfDays.ToString("#0");

            //toolStripStatusLabel2.Text = NrOfDays.ToString();


            DateTime d1 = new DateTime(dtp_Data.Value.Year, dtp_Data.Value.Month,dtp_Data.Value.Day, 1, 1, 1);
            DateTime d2 = new DateTime(dtp_Valuta.Value.Year, dtp_Valuta.Value.Month, dtp_Valuta.Value.Day, 1, 1, 1);

            var RazlDenovi = (d2 - d1).TotalDays;
            txtDenovi.Text = RazlDenovi.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
