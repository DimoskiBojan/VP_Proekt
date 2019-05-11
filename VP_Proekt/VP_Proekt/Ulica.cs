using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Proekt.Properties;

namespace VP_Proekt
{
    public partial class Ulica : Form
    {
        Timer timer;
        Image person_up;
        Image car1;
        Image car2;
        Image car3;
        Image sidewalk_up;
        Image sidewalk_down;
        Image street;
        int lightColor;

        public Ulica()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            person_up = Resources.Person1_Up;
            car1 = Resources.car1;
            car2 = Resources.car2;
            car3 = Resources.car3;
            street = Resources.street;
            sidewalk_up = Resources.sidewalk_Up;
            sidewalk_down = Resources.sidewalk__Down;
            newGame();
        }

        public void newGame()
        {
            lightColor = 2;
            timer = new Timer();
            timer.Interval = 250;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
           
        }

        private void Ulica_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Ulica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for(int i=0;i<this.Width;i++)
            {
                g.DrawImage(sidewalk_up, i*sidewalk_up.Width, sidewalk_down.Height+street.Height, sidewalk_up.Width, sidewalk_up.Height);
                g.DrawImage(sidewalk_down, i * sidewalk_down.Width, 0, sidewalk_down.Width, sidewalk_down.Height);
                g.DrawImage(street, i*street.Width, sidewalk_up.Height, street.Width, street.Height);
            }
            Rectangle r = new Rectangle(80*9, 10, 70, 130);
            g.FillRectangle(Brushes.LightGray, r);
            Rectangle r1 = new Rectangle(80*9 +5, 13, 60, 60);
            Rectangle r2 = new Rectangle(80*9 +5, 75, 60, 60);
            switch (lightColor)
            {
                case 1:
                    g.FillEllipse(Brushes.Red, r1);
                    g.FillEllipse(Brushes.Black, r2);
                    break;
                case 2:
                    g.FillEllipse(Brushes.Black, r1);
                    g.FillEllipse(Brushes.Green, r2);
                    break;
            }

            // tests
            g.DrawImage(car1, 0, 80, car1.Width, car1.Height);
            g.DrawImage(car2, 180, 180, car2.Width, car2.Height);
            g.DrawImage(car3, 360, 80, car3.Width, car3.Height);
            g.DrawImage(person_up, 80*7, 300, person_up.Width, person_up.Height);
        }
    }
}
