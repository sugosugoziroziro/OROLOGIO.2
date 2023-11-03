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

        private void timer1_Tick(object sender, EventArgs e)
        {  

            Graphics g = this.CreateGraphics();
            int xc = ClientSize.Width / 2;
            int yc = ClientSize.Height / 2;
            g.Clear(Color.White);
            int sinpSecondi = (int)(Math.Sin(-Math.PI / 2 + (DateTime.Now.Second * Math.PI) / 30) * (yc/100*80));
            int cospSecondi = (int)(Math.Cos(-Math.PI / 2 + (DateTime.Now.Second * Math.PI) / 30) * (xc/100*80));
            g.DrawLine(Pens.RosyBrown, xc, yc, xc + cospSecondi, yc + sinpSecondi);

            int sinpMinuti = (int)(Math.Sin(-Math.PI / 2 + (DateTime.Now.Minute * Math.PI) / 30) * (yc/100*60));
            int cospMinuti = (int)(Math.Cos(-Math.PI / 2 + (DateTime.Now.Minute * Math.PI) / 30) * (xc/100*60));
            g.DrawLine(Pens.GreenYellow, xc, yc, xc + cospMinuti, yc + sinpMinuti);

            int sinpOre = (int)(Math.Sin(-Math.PI / 2 + (DateTime.Now.Hour * Math.PI) / 6) * (yc/100*40));
            int cospOre = (int)(Math.Cos(-Math.PI / 2 + (DateTime.Now.Hour * Math.PI) / 6) * (xc/100*40));
            g.DrawLine(Pens.Blue, xc, yc, xc + cospOre, yc + sinpOre);
            Rectangle r = new Rectangle(xc-xc/100*90/2, yc - yc/100*90/2, xc / 100 * 90, yc / 100 * 90);
            g.DrawRectangle(Pens.RoyalBlue, r);
            g.DrawEllipse(Pens.HotPink,r);
                

           label1.Text= DateTime.Now.ToString();    
             
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
} 
