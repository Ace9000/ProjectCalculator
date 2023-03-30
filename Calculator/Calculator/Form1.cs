

namespace Calculator
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblRezultat.Text = "";

            this.KeyUp += XXX_KeyUp;

            btn0.MouseClick += XXX_MouseClick;
            btn1.MouseClick += XXX_MouseClick;
            btn2.MouseClick += XXX_MouseClick;
            btn3.MouseClick += XXX_MouseClick;
            btn4.MouseClick += XXX_MouseClick;
            btn5.MouseClick += XXX_MouseClick;
            btn6.MouseClick += XXX_MouseClick;
            btn7.MouseClick += XXX_MouseClick;
            btn8.MouseClick += XXX_MouseClick;
            btn9.MouseClick += XXX_MouseClick;
            btnDot.MouseClick += XXX_MouseClick;
            btnMinus.MouseClick += XXX_MouseClick;
            btnPlus.MouseClick += XXX_MouseClick;
            btnDelenje.MouseClick += XXX_MouseClick;
            btnMnozenje.MouseClick += XXX_MouseClick;
            btnEnter.MouseClick += XXX_MouseClick;


            bool NumLock = Control.IsKeyLocked(Keys.NumLock);
            if (NumLock)
            {
                lblNumLock.Text = "NumLock ON";
            }
            else
            {
                lblNumLock.Text = "NumLock OFF";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //bool NumLock = Control.IsKeyLocked(Keys.NumLock);
            //if (!NumLock)
            //{
            //    lblNumLock.Text = "NumLock OFF";
            //}
            //else
            //{
            //    lblNumLock.Text = "NumLock ON";
            //}
        }
        private void XXX_KeyUp(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString();

            if(e.KeyCode == Keys.NumLock)
            {
                bool NumLock = Control.IsKeyLocked(Keys.NumLock);
                if (NumLock)
                {
                    lblNumLock.Text = "NumLock ON";
                }
                else
                {
                    lblNumLock.Text = "NumLock OFF";
                }
                return;
            }

            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "0";
            }
            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "1";
            }

            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "2";
            }

            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "3";
            }

            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "4";
            }

            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "5";
            }

            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "6";
            }

            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "7";
            }

            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "8";
            }
            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                e.SuppressKeyPress = false;
                lblRezultat.Text = lblRezultat.Text + "9";
            }
            
            else if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                string[] ImaTocki;
                ImaTocki = lblRezultat.Text.Split('.');
                if (ImaTocki.Length == 1)
                {
                    e.SuppressKeyPress = false;
                    lblRezultat.Text = lblRezultat.Text + ".";
                }
            }
            else if (e.KeyCode == Keys.Back) 
            {
                if (lblRezultat.Text.Length >= 1)
                {
                    e.SuppressKeyPress = false;
                    lblRezultat.Text = lblRezultat.Text.Substring(0, lblRezultat.Text.Length - 1);
                }            
              
            }
            else if (e.KeyCode == Keys.Oemplus || e.KeyCode == Keys.Add)
            {
                if (lblRezultat.Text.Length >= 1)
                {
                    string PosledenKarakter = lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1);
                    string KarakteriBezPosledniotKarakter = lblRezultat.Text.Substring(0, lblRezultat.Text.Length - 1);

                    //MessageBox.Show("=" + KarakteriBezPosledniotKarakter + "=" + PosledenKarakter + "=");
                    //MessageBox.Show($"={KarakteriBezPosledniotKarakter}={PosledenKarakter}=");

                    if (PosledenKarakter == "-" || PosledenKarakter == "*" || PosledenKarakter == "/")
                    {
                        lblRezultat.Text = KarakteriBezPosledniotKarakter + "+";
                    }
                    else
                    {
                        if (PosledenKarakter == "+")
                        {
                            // ne go prifakaj Minusot kako 123--
                        }
                        else
                        {
                            lblRezultat.Text = lblRezultat.Text + "+";
                            e.SuppressKeyPress = false;
                        }
                    }

                }
            }
            else if (e.KeyCode == Keys.OemMinus || e.KeyCode == Keys.Subtract)
            {
                if (lblRezultat.Text.Length >= 1)
                {
                    string PosledenKarakter = lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1);
                    string KarakteriBezPosledniotKarakter = lblRezultat.Text.Substring(0, lblRezultat.Text.Length - 1);

                    //MessageBox.Show("=" + KarakteriBezPosledniotKarakter + "=" + PosledenKarakter + "=");
                    //MessageBox.Show($"={KarakteriBezPosledniotKarakter}={PosledenKarakter}=");

                    if (PosledenKarakter == "+" || PosledenKarakter == "*" || PosledenKarakter == "/")
                    {
                        lblRezultat.Text = KarakteriBezPosledniotKarakter + "-";
                    }
                    else
                    {
                        if (PosledenKarakter == "-")
                        {
                            // ne go prifakaj Minusot kako 123--
                        }
                        else
                        {
                            lblRezultat.Text = lblRezultat.Text + "-";
                            e.SuppressKeyPress = false;
                        }
                    }

                }
            }
            else if (e.KeyCode == Keys.Divide)
            {
                if (lblRezultat.Text.Length >= 1)
                {
                    string PosledenKarakter = lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1);
                    string KarakteriBezPosledniotKarakter = lblRezultat.Text.Substring(0, lblRezultat.Text.Length - 1);

                    //MessageBox.Show("=" + KarakteriBezPosledniotKarakter + "=" + PosledenKarakter + "=");
                    //MessageBox.Show($"={KarakteriBezPosledniotKarakter}={PosledenKarakter}=");

                    if (PosledenKarakter == "+" || PosledenKarakter == "*" || PosledenKarakter == "-")
                    {
                        lblRezultat.Text = KarakteriBezPosledniotKarakter + "/";
                    }
                    else
                    {
                        if (PosledenKarakter == "/")
                        {
                            // ne go prifakaj Minusot kako 123--
                        }
                        else
                        {
                            lblRezultat.Text = lblRezultat.Text + "/";
                            e.SuppressKeyPress = false;
                        }
                    }

                }
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                if (lblRezultat.Text.Length >= 1)
                {
                    string PosledenKarakter = lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1);
                    string KarakteriBezPosledniotKarakter = lblRezultat.Text.Substring(0, lblRezultat.Text.Length - 1);

                    //MessageBox.Show("=" + KarakteriBezPosledniotKarakter + "=" + PosledenKarakter + "=");
                    //MessageBox.Show($"={KarakteriBezPosledniotKarakter}={PosledenKarakter}=");

                    if (PosledenKarakter == "+" || PosledenKarakter == "-" || PosledenKarakter == "/")
                    {
                        lblRezultat.Text = KarakteriBezPosledniotKarakter + "*";
                    }
                    else
                    {
                        if (PosledenKarakter == "*")
                        {
                            // ne go prifakaj Minusot kako 123--
                        }
                        else
                        {
                            lblRezultat.Text = lblRezultat.Text + "*";
                            e.SuppressKeyPress = false;
                        }
                    }

                }
            }
            else if (e.KeyCode == Keys.Return)
            {
                //MessageBox.Show("pritisnato enter");
                PrikaziRezultat();
            }
        }
        private void XXX_MouseClick(object sender, EventArgs e)
        {
            Button bbb = sender as Button;
            //MessageBox.Show(bbb.Name);

            if (bbb.Name == "btn0")
                lblRezultat.Text = lblRezultat.Text + "0";
            else if (bbb.Name == "btn1")
                lblRezultat.Text = lblRezultat.Text + "1";
            else if (bbb.Name == "btn2")
                lblRezultat.Text = lblRezultat.Text + "2";
            else if (bbb.Name == "btn3")
                lblRezultat.Text = lblRezultat.Text + "3";
            else if (bbb.Name == "btn4")
                lblRezultat.Text = lblRezultat.Text + "4";
            else if (bbb.Name == "btn5")
                lblRezultat.Text = lblRezultat.Text + "5";
            else if (bbb.Name == "btn6")
                lblRezultat.Text = lblRezultat.Text + "6";
            else if (bbb.Name == "btn7")
                lblRezultat.Text = lblRezultat.Text + "7";
            else if (bbb.Name == "btn8")
                lblRezultat.Text = lblRezultat.Text + "8";
            else if (bbb.Name == "btn9")
                lblRezultat.Text = lblRezultat.Text + "9";
            else if (bbb.Name == "btnDot")
                lblRezultat.Text = lblRezultat.Text + ".";
            else if (bbb.Name == "btnMinus")
            {
                if (lblRezultat.Text.Length >= 1)
                {
                    string PosledenKarakter = lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1);
                    string KarakteriBezPosledniotKarakter = lblRezultat.Text.Substring(0, lblRezultat.Text.Length - 1);

                    //MessageBox.Show("=" + KarakteriBezPosledniotKarakter + "=" + PosledenKarakter + "=");
                    //MessageBox.Show($"={KarakteriBezPosledniotKarakter}={PosledenKarakter}=");

                    if (PosledenKarakter == "+" || PosledenKarakter == "*" || PosledenKarakter == "/")
                    {
                        lblRezultat.Text = KarakteriBezPosledniotKarakter + "-";
                    }
                    else
                    {
                        if (PosledenKarakter == "-")
                        {
                            // ne go prifakaj Minusot kako 123--
                        }
                        else
                        {
                            lblRezultat.Text = lblRezultat.Text + "-";
                        }
                    }

                }
            }
            else if (bbb.Name == "btnPlus")
            {
                if (lblRezultat.Text.Length >= 1)
                {
                    string PosledenKarakter = lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1);
                    string KarakteriBezPosledniotKarakter = lblRezultat.Text.Substring(0, lblRezultat.Text.Length - 1);

                    //MessageBox.Show("=" + KarakteriBezPosledniotKarakter + "=" + PosledenKarakter + "=");
                    //MessageBox.Show($"={KarakteriBezPosledniotKarakter}={PosledenKarakter}=");

                    if (PosledenKarakter == "-" || PosledenKarakter == "*" || PosledenKarakter == "/")
                    {
                        lblRezultat.Text = KarakteriBezPosledniotKarakter + "+";
                    }
                    else
                    {
                        if (lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1) == "+")
                        {
                            // ne go prifakaj PLUSOT kako 123++
                        }
                        else
                        {
                            lblRezultat.Text = lblRezultat.Text + "+";
                        }
                    }
                }

            }
            else if (bbb.Name == "btnDelenje")
            {
                if (lblRezultat.Text.Length >= 1)
                {

                    string PosledenKarakter = lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1);
                    string KarakteriBezPosledniotKarakter = lblRezultat.Text.Substring(0, lblRezultat.Text.Length - 1);

                    //MessageBox.Show("=" + KarakteriBezPosledniotKarakter + "=" + PosledenKarakter + "=");
                    //MessageBox.Show($"={KarakteriBezPosledniotKarakter}={PosledenKarakter}=");

                    if (PosledenKarakter == "-" || PosledenKarakter == "+" || PosledenKarakter == "*")
                    {
                        lblRezultat.Text = KarakteriBezPosledniotKarakter + "/";
                    }
                    else
                    {
                        if (lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1) == "/")
                        {
                            // ne go prifakaj Delenje kako 123//
                        }
                        else
                        {
                            lblRezultat.Text = lblRezultat.Text + "/";
                        }
                    }
                }
            }

            else if (bbb.Name == "btnMnozenje")
            {
                if (lblRezultat.Text.Length >= 1)
                {
                    string PosledenKarakter = lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1);
                    string KarakteriBezPosledniotKarakter = lblRezultat.Text.Substring(0, lblRezultat.Text.Length - 1);

                    //MessageBox.Show("=" + KarakteriBezPosledniotKarakter + "=" + PosledenKarakter + "=");
                    //MessageBox.Show($"={KarakteriBezPosledniotKarakter}={PosledenKarakter}=");

                    if (PosledenKarakter == "-" || PosledenKarakter == "+" || PosledenKarakter == "/")
                    {
                        lblRezultat.Text = KarakteriBezPosledniotKarakter + "*";
                    }
                    else
                    {
                        if (lblRezultat.Text.Substring(lblRezultat.Text.Length - 1, 1) == "*")
                        {
                            // ne go prifakaj Delenje kako 123//
                        }
                        else
                        {
                            lblRezultat.Text = lblRezultat.Text + "*";
                        }
                    }
                }
            }
            else if (bbb.Name == "btnEnter")
            {
                PrikaziRezultat();
            }

        }

        private void PrikaziRezultat()
        {
            //MessageBox.Show("ke se racuna ...");

            double Rezultat = 0;

            if (lblRezultat.Text.Length >= 3)
            {
                if (lblRezultat.Text.Contains('+'))
                {
                    string[] Niza;
                    Niza = lblRezultat.Text.Split('+');
                    
                    foreach (string xx in Niza)
                    {
                        double dxx = 0;
                        try
                        {
                            dxx = Convert.ToDouble(xx);
                        }
                        catch { }
                        Rezultat = Rezultat + dxx;
                    }
                }         

                
                if (lblRezultat.Text.Contains('-'))
                {
                    string[] Niza;
                    Niza = lblRezultat.Text.Split('-');

                    int BrojNaVrednostOdNiza = 0;
                    foreach (string xx in Niza)
                    {
                        BrojNaVrednostOdNiza++;
                        double dxx = 0;
                        try
                        {
                            dxx = Convert.ToDouble(xx);
                        }
                        catch { }

                        if (BrojNaVrednostOdNiza == 1)
                            Rezultat = Rezultat + dxx;
                        else
                            Rezultat = Rezultat - dxx; 

                    }
                }

                if (lblRezultat.Text.Contains('*'))
                {
                    Rezultat = 1;
                    string[] Niza;
                    Niza = lblRezultat.Text.Split('*');

                    foreach (string xx in Niza)
                    {
                        double dxx = 0;
                        try
                        {
                            dxx = Convert.ToDouble(xx);
                        }
                        catch { }

                        Rezultat = Rezultat * dxx;
                    }
                }
                if (lblRezultat.Text.Contains('/'))
                {
                    Rezultat = 0;
                    string[] Niza;
                    Niza = lblRezultat.Text.Split('/');
                    int BrojNaVrednostOdNiza = 0;

                    foreach (string xx in Niza)
                    {
                        BrojNaVrednostOdNiza++;
                        double dxx = 0;
                        try
                        {
                            dxx = Convert.ToDouble(xx);
                        }
                        catch { }

                        if (BrojNaVrednostOdNiza == 1)
                            Rezultat = Rezultat + dxx;
                        else
                            Rezultat = Rezultat / dxx;
                    }
                }

                lblVneseno.Text = lblRezultat.Text + " = " + Rezultat.ToString();
                lblRezultat.Text = "";

            }

        }
        private void obicenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ODBRAVTE OBICEN");
            button1.Visible = false;
            button2.Visible = false;
        }

        private void napredenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("ODBRAVTE NAPREDEN");
            button1.Visible = true;
            button2.Visible = true;
        }

        private void lblAvtor_MouseClick(object sender, MouseEventArgs e)
        {
            Avtor xx=new Avtor();
            xx.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 xx = new Form2();
            xx.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 xx = new Form3();
            xx.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 xx = new Form4();
            xx.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            Form6 xx = new Form6();
            xx.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form5 xx = new Form5();
            xx.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form7 xx = new Form7();
            xx.ShowDialog();
        }

        private void lblNumLock_Click(object sender, EventArgs e)
        {

        }
    }
}