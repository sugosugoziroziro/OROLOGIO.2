using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace orologio
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }
        int FusoOre;
        int FusoMinuti;
        string PiuOMeno;
        string FusoOreString;
        string FusoMinutiString;

        string Ore = "0";
        string Minuti = "0";
        string Secondi = "0";
        DateTime Data = new DateTime();
        

        private void timer1_Tick(object sender, EventArgs e)
        {
           

            Data = DateTime.Now.AddMinutes(FusoMinuti).AddHours(FusoOre - 1);
            
            lblData.Text = Data.ToString();

            if (cmbFuso.SelectedIndex == -1)
            {
                cmbFuso.SelectedIndex = 2;
            }

            if ((int)cmbColori.SelectedIndex == -1)
            {
                cmbColori.SelectedItem = "Base";
            }
            
            if ((string)cmbColori.SelectedItem == "Antico")
            {
                BackColor = Color.Sienna;
                cmbFuso.BackColor= Color.Sienna;
                cmbOre.BackColor = Color.Sienna;
                cmbMinuti.BackColor = Color.Sienna;
                cmbColori.BackColor= Color.Sienna;
                cmbFuso.ForeColor = Color.AntiqueWhite;
                cmbOre.ForeColor = Color.AntiqueWhite;
                cmbMinuti.ForeColor = Color.AntiqueWhite;
                cmbColori.ForeColor = Color.AntiqueWhite;
                lblData.ForeColor = Color.White;
                lblFuso.ForeColor = Color.White;
                lblColori.ForeColor = Color.White;
                cmbFuso.BackColor = Color.Sienna;
                Graphics g = this.CreateGraphics();
                Graphics ellisse = this.CreateGraphics();
                int xc = ClientSize.Width / 2;
                int yc = ClientSize.Height / 2;
                g.Clear(Color.Sienna);

                Rectangle r = new Rectangle(xc - xc / 100 * 45, yc - yc / 100 * 45, xc / 100 * 90, yc / 100 * 90);

                ellisse.FillEllipse(Brushes.AntiqueWhite, r);
                Pen pennaS = new Pen(Brushes.Black, 0.2F);
                Pen pennaM = new Pen(Brushes.DarkGoldenrod, 2.0F);
                Pen pennaO = new Pen(Brushes.Goldenrod, 4.0F);
                Pen pt = new Pen(Brushes.Black, 5.0F);

                int sinpSecondi = (int)(Math.Sin(-Math.PI / 2 + (DateTime.Now.Second * Math.PI) / 30) * (yc / 100 * 40));
                int cospSecondi = (int)(Math.Cos(-Math.PI / 2 + (DateTime.Now.Second * Math.PI) / 30) * (xc / 100 * 40));
                g.DrawLine(pennaS, xc, yc, xc + cospSecondi, yc + sinpSecondi);

                int sinpMinuti = (int)(Math.Sin(-Math.PI / 2 + (((DateTime.Now.Minute * 60) + DateTime.Now.Second + FusoMinuti * 60 ) * Math.PI) / 1800) * (yc / 100 * 34));
                int cospMinuti = (int)(Math.Cos(-Math.PI / 2 + (((DateTime.Now.Minute * 60) + DateTime.Now.Second + FusoMinuti * 60 ) * Math.PI) / 1800) * (xc / 100 * 34));
                g.DrawLine(pennaM, xc, yc, xc + cospMinuti, yc + sinpMinuti);

                int sinpOre = (int)(Math.Sin(-Math.PI / 2 + (((DateTime.Now.Hour * 60) + DateTime.Now.Minute + FusoOre*60-60) * Math.PI) / 360) * (yc / 100 * 20));
                int cospOre = (int)(Math.Cos(-Math.PI / 2 + (((DateTime.Now.Hour * 60) + DateTime.Now.Minute + FusoOre*60-60) * Math.PI) / 360) * (xc / 100 * 20));
                g.DrawLine(pennaO, xc, yc, xc + cospOre, yc + sinpOre);

                

                Pen pennaE = new Pen(Brushes.Goldenrod, 10.0F);

                ellisse.DrawEllipse(pennaE, r);


                for (int i = 1; i < 61; i++)
                {

                    int grandex = (int)(Math.Cos(-Math.PI / 2 + (i * Math.PI) / 30) * (xc / 100 * 43));
                    int grandey = (int)(Math.Sin(-Math.PI / 2 + (i * Math.PI) / 30) * (yc / 100 * 43));
                    int piccolox = (int)(Math.Cos(-Math.PI / 2 + (i * Math.PI) / 30) * (xc / 100 * 38));
                    int piccoloy = (int)(Math.Sin(-Math.PI / 2 + (i * Math.PI) / 30) * (yc / 100 * 38));
                    int numerox = xc + (int)(Math.Cos(-Math.PI / 2 + (i * Math.PI) / 30) * (xc / 100 * 32) - this.FontHeight / 2);
                    int numeroy = yc + (int)(Math.Sin(-Math.PI / 2 + (i * Math.PI) / 30) * (yc / 100 * 32) - this.FontHeight / 2);

                    if (i % 5 == 0)
                    {
                        string numero = (i / 5).ToString();
                        TextFormatFlags flags = TextFormatFlags.Default;
                        
                        g.DrawLine(pt, xc + piccolox, yc + piccoloy, xc + grandex, yc + grandey);
                        
                        TextRenderer.DrawText(g, numero, this.Font, new Point(numerox, numeroy),
                            Color.Goldenrod, Color.AntiqueWhite, flags);
                    }

                    else
                    {
                        g.DrawLine(Pens.DarkGoldenrod, xc + piccolox, yc + piccoloy, xc + grandex, yc + grandey);
                    }
                }

                if (Ore == Data.Hour.ToString() && Minuti == Data.Minute.ToString() && Secondi == Data.Second.ToString())
                {
                    MessageBox.Show("SVEGLIA!! DIN DIN DIN", "Sveglia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
            
            if ((string)cmbColori.SelectedItem == "Base")
            {
                BackColor = Color.White;
                lblData.ForeColor = Color.Black;
                lblFuso.ForeColor = Color.Black;
                lblColori.ForeColor = Color.Black;

                Graphics g = this.CreateGraphics();
                Graphics ellisse = this.CreateGraphics();
                int xc = ClientSize.Width / 2;
                int yc = ClientSize.Height / 2;
                g.Clear(Color.White);

                Rectangle r = new Rectangle(xc - xc / 100 * 45, yc - yc / 100 * 45, xc / 100 * 90, yc / 100 * 90);

                ellisse.FillEllipse(Brushes.White, r);
                Pen pennaS = new Pen(Brushes.Black, 0.2F);
                Pen pennaM = new Pen(Brushes.Black, 2.0F);
                Pen pennaO = new Pen(Brushes.Red, 4.0F);
                Pen pt = new Pen(Brushes.Black, 5.0F);

                int sinpSecondi = (int)(Math.Sin(-Math.PI / 2 + (DateTime.Now.Second * Math.PI) / 30) * (yc / 100 * 40));
                int cospSecondi = (int)(Math.Cos(-Math.PI / 2 + (DateTime.Now.Second * Math.PI) / 30) * (xc / 100 * 40));
                g.DrawLine(pennaS, xc, yc, xc + cospSecondi, yc + sinpSecondi);

                int sinpMinuti = (int)(Math.Sin(-Math.PI / 2 + (((DateTime.Now.Minute * 60) + DateTime.Now.Second + FusoMinuti*60) * Math.PI) / 1800) * (yc / 100 * 34));
                int cospMinuti = (int)(Math.Cos(-Math.PI / 2 + (((DateTime.Now.Minute * 60) + DateTime.Now.Second + FusoMinuti*60) * Math.PI) / 1800) * (xc / 100 * 34));
                g.DrawLine(pennaM, xc, yc, xc + cospMinuti, yc + sinpMinuti);

                int sinpOre = (int)(Math.Sin(-Math.PI / 2 + (((DateTime.Now.Hour * 60) + DateTime.Now.Minute + FusoOre * 60 - 60) * Math.PI) / 360) * (yc / 100 * 20));
                int cospOre = (int)(Math.Cos(-Math.PI / 2 + (((DateTime.Now.Hour * 60) + DateTime.Now.Minute + FusoOre * 60 - 60) * Math.PI) / 360) * (xc / 100 * 20));
                g.DrawLine(pennaO, xc, yc, xc + cospOre, yc + sinpOre);

                Pen pennaE = new Pen(Brushes.Black, 10.0F);

                ellisse.DrawEllipse(pennaE, r);

                for (int i = 1; i < 61; i++)
                {

                    int grandex = (int)(Math.Cos(-Math.PI / 2 + (i * Math.PI) / 30) * (xc / 100 * 43));
                    int grandey = (int)(Math.Sin(-Math.PI / 2 + (i * Math.PI) / 30) * (yc / 100 * 43));
                    int piccolox = (int)(Math.Cos(-Math.PI / 2 + (i * Math.PI) / 30) * (xc / 100 * 38));
                    int piccoloy = (int)(Math.Sin(-Math.PI / 2 + (i * Math.PI) / 30) * (yc / 100 * 38));
                    int numerox = xc + (int)(Math.Cos(-Math.PI / 2 + (i * Math.PI) / 30) * (xc / 100 * 32) - this.FontHeight / 2);
                    int numeroy = yc + (int)(Math.Sin(-Math.PI / 2 + (i * Math.PI) / 30) * (yc / 100 * 32) - this.FontHeight / 2);

                    if (i % 5 == 0)
                    {
                        string numero = (i / 5).ToString();
                        TextFormatFlags flags = TextFormatFlags.Default;
                        g.DrawLine(pt, xc + piccolox, yc + piccoloy, xc + grandex, yc + grandey);
                        TextRenderer.DrawText(g, numero, this.Font, new Point(numerox, numeroy),
                            Color.Red, Color.White, flags);
                    }

                    else
                    {
                        g.DrawLine(Pens.Gray, xc + piccolox, yc + piccoloy, xc + grandex, yc + grandey);
                    }
                }

                if (Ore == Data.Hour.ToString() && Minuti == Data.Minute.ToString() && Secondi == Data.Second.ToString())
                {
                    MessageBox.Show("SVEGLIA!! DIN DIN DIN", "Sveglia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            if ((string)cmbColori.SelectedItem == "Special")
            {
                BackColor = Color.Fuchsia;
                lblData.ForeColor = Color.MediumBlue;
                lblFuso.ForeColor = Color.MediumBlue;
                lblColori.ForeColor = Color.MediumBlue;

                Graphics g = this.CreateGraphics();
                Graphics ellisse = this.CreateGraphics();
                int xc = ClientSize.Width / 2;
                int yc = ClientSize.Height / 2;
                g.Clear(Color.Fuchsia);

                Rectangle r = new Rectangle(xc - xc / 100 * 45, yc - yc / 100 * 45, xc / 100 * 90, yc / 100 * 90);

                ellisse.FillEllipse(Brushes.Red, r);
                Pen pennaS = new Pen(Brushes.MediumBlue, 0.2F);
                Pen pennaM = new Pen(Brushes.MediumBlue, 2.0F);
                Pen pennaO = new Pen(Brushes.DarkMagenta, 4.0F);
                Pen pt = new Pen(Brushes.MediumBlue, 5.0F);

                int sinpSecondi = (int)(Math.Sin(-Math.PI / 2 + (DateTime.Now.Second * Math.PI) / 30) * (yc / 100 * 40));
                int cospSecondi = (int)(Math.Cos(-Math.PI / 2 + (DateTime.Now.Second * Math.PI) / 30) * (xc / 100 * 40));
                g.DrawLine(pennaS, xc, yc, xc + cospSecondi, yc + sinpSecondi);

                int sinpMinuti = (int)(Math.Sin(-Math.PI / 2 + (((DateTime.Now.Minute * 60) + DateTime.Now.Second + FusoMinuti * 60 ) * Math.PI) / 1800) * (yc / 100 * 34));
                int cospMinuti = (int)(Math.Cos(-Math.PI / 2 + (((DateTime.Now.Minute * 60) + DateTime.Now.Second + FusoMinuti * 60 ) * Math.PI) / 1800) * (xc / 100 * 34));
                g.DrawLine(pennaM, xc, yc, xc + cospMinuti, yc + sinpMinuti);

                int sinpOre = (int)(Math.Sin(-Math.PI / 2 + (((DateTime.Now.Hour * 60) + DateTime.Now.Minute + FusoOre * 60 - 60) * Math.PI) / 360) * (yc / 100 * 20));
                int cospOre = (int)(Math.Cos(-Math.PI / 2 + (((DateTime.Now.Hour * 60) + DateTime.Now.Minute + FusoOre * 60 - 60) * Math.PI) / 360) * (xc / 100 * 20));
                g.DrawLine(pennaO, xc, yc, xc + cospOre, yc + sinpOre);



                Pen pennaE = new Pen(Brushes.MediumBlue, 10.0F);

                ellisse.DrawEllipse(pennaE, r);


                for (int i = 1; i < 61; i++)
                {

                    int grandex = (int)(Math.Cos(-Math.PI / 2 + (i * Math.PI) / 30) * (xc / 100 * 43));
                    int grandey = (int)(Math.Sin(-Math.PI / 2 + (i * Math.PI) / 30) * (yc / 100 * 43));
                    int piccolox = (int)(Math.Cos(-Math.PI / 2 + (i * Math.PI) / 30) * (xc / 100 * 38));
                    int piccoloy = (int)(Math.Sin(-Math.PI / 2 + (i * Math.PI) / 30) * (yc / 100 * 38));
                    int numerox = xc + (int)(Math.Cos(-Math.PI / 2 + (i * Math.PI) / 30) * (xc / 100 * 32) - this.FontHeight / 2);
                    int numeroy = yc + (int)(Math.Sin(-Math.PI / 2 + (i * Math.PI) / 30) * (yc / 100 * 32) - this.FontHeight / 2);

                    if (i % 5 == 0)
                    {
                        string numero = (i / 5).ToString();
                        TextFormatFlags flags = TextFormatFlags.Default;
                        g.DrawLine(pt, xc + piccolox, yc + piccoloy, xc + grandex, yc + grandey);
                        TextRenderer.DrawText(g, numero, this.Font, new Point(numerox, numeroy),
                            Color.Yellow, Color.Red, flags);
                    }

                    else
                    {
                        g.DrawLine(Pens.Yellow, xc + piccolox, yc + piccoloy, xc + grandex, yc + grandey);
                    }
                }

                if (Ore == Data.Hour.ToString() && Minuti == Data.Minute.ToString() && Secondi == Data.Second.ToString())
                {
                    MessageBox.Show("SVEGLIA!! DIN DIN DIN", "Sveglia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            cmbOre.Top = ClientRectangle.Top + ClientSize.Height - 2 * cmbOre.Height;
            cmbOre.Left = ClientRectangle.Left + cmbOre.Width;

            cmbMinuti.Top = ClientRectangle.Top + ClientSize.Height - 2 * cmbMinuti.Height;
            cmbMinuti.Left = ClientRectangle.Left + 2 * cmbOre.Width + 5;

            cmbSecondi.Top = ClientRectangle.Top + ClientSize.Height - 2 * cmbOre.Height;
            cmbSecondi.Left = ClientRectangle.Left + 3 * cmbOre.Width + 10;

            button1.Top = ClientRectangle.Top + ClientSize.Height - 3 * cmbOre.Height - 10;
            button1.Left = ClientRectangle.Left + cmbOre.Width;

            lblData.Top = ClientRectangle.Top + lblData.Height;
            lblData.Left = ClientRectangle.Left + cmbOre.Width;

            cmbFuso.Top = ClientRectangle.Top + 2 * lblData.Height + 10;
            cmbFuso.Left = ClientRectangle.Left + ClientSize.Width - cmbFuso.Width - cmbOre.Width;

            lblFuso.Top = ClientRectangle.Top + lblData.Height;
            lblFuso.Left = ClientRectangle.Left + ClientSize.Width - cmbFuso.Width - cmbOre.Width;

            cmbColori.Top = ClientRectangle.Top + ClientSize.Height - 3 * cmbOre.Height - 10;
            cmbColori.Left = ClientRectangle.Left + ClientSize.Width - cmbColori.Width - cmbOre.Width;

            lblColori.Top = ClientRectangle.Top + ClientSize.Height - 4 * cmbOre.Height - 10;
            lblColori.Left = ClientRectangle.Left + ClientSize.Width - cmbColori.Width - cmbOre.Width;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ore = (string)cmbOre.SelectedItem;
            Minuti = (string)cmbMinuti.SelectedItem;
            Secondi = (string)cmbSecondi.SelectedItem;
        }

        
        private void cmbFuso_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FusoSelezionato = (string)cmbFuso.SelectedItem;
            PiuOMeno= FusoSelezionato.Substring(1,1);
            FusoOreString = FusoSelezionato.Substring(2,2); 
            FusoMinutiString= FusoSelezionato.Substring (5, 2);
            FusoOre = int.Parse(FusoOreString);
            FusoMinuti=int.Parse(FusoMinutiString);

            if(PiuOMeno == "-")
            {
                FusoOre = -FusoOre;
                FusoMinuti = -FusoMinuti;
         
            }
            
            
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
} 
