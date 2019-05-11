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
        Timer timerSemaphore;
        Covece person;
        List<Car> cars;
        Image sidewalk_up;
        Image sidewalk_down;
        Image street;
        bool lightColor;
        double count;

        public Ulica()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            street = Resources.street;
            sidewalk_up = Resources.sidewalk_Up;
            sidewalk_down = Resources.sidewalk__Down;
            newGame();
        }

        public void newGame()
        {
            Width = sidewalk_down.Width * 10 + 20;
            Height = sidewalk_down.Height*2+street.Height+40;
            person = new Covece();
            person.formWidth = Width;
            lightColor = true;
            count = 0;
            //cars
            cars = new List<Car>()
            {
                new Car(0,85,Resources.car1, Width, true ),
                new Car(180,85,Resources.car2, Width, true ),
                new Car(360,85,Resources.car3, Width, true ),
            
             };
            

            timerSemaphore = new Timer();
            timerSemaphore.Interval= 5000;
            timerSemaphore.Tick += new EventHandler(timerSemaphore_Tick);
            timerSemaphore.Start();

            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }
        
        void timer_Tick(object sender, EventArgs e)
        {
            if(count==5000)
            {
                count = 0;
            }
            else
            {
                count++;
            }
            foreach (Car c in cars)
            {
                double f = c.Stop();
                f = count;
                if ((5000-count) != c.Stop())
                {
                    c.Move();
                }
            }
            
            
            Invalidate();
        }

  
        void timerSemaphore_Tick(object sender, EventArgs e)
        {
            lightColor = !lightColor;
            foreach (Car c in cars)
            {
                c.lightColor = lightColor;
            }
            Invalidate();
        }

        private void Ulica_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up)
            {
                person.ChangeDirection(Covece.DIRECTION.UP);
                person.Move();
            }
            if (e.KeyCode == Keys.Down)
            {
                person.ChangeDirection(Covece.DIRECTION.DOWN);
                person.Move();
            }
            if (e.KeyCode == Keys.Left)
            {
                person.ChangeDirection(Covece.DIRECTION.LEFT);
                person.Move();
            }
            if (e.KeyCode == Keys.Right)
            {
                person.ChangeDirection(Covece.DIRECTION.RIGHT);
                person.Move();
            }
            if (person.Y == 20 )
            {
                if (MessageBox.Show("Успешно поминавте од другата страна на коловозот. Дали сакате да се обидете повторно?", "Победник", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    newGame();
                }
                else
                {
                    this.Close();
                }
            }
            Invalidate();
        }
     

        private void Ulica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i=0;i<this.Width;i++)
            {
                g.DrawImage(sidewalk_up, i*sidewalk_up.Width, sidewalk_down.Height+street.Height, sidewalk_up.Width, sidewalk_up.Height);
                g.DrawImage(sidewalk_down, i * sidewalk_down.Width, 0, sidewalk_down.Width, sidewalk_down.Height);
                g.DrawImage(street, i*street.Width, sidewalk_up.Height, street.Width, street.Height);
            }
            //peshacki
            for(int i=0; i< 4;i++)
            {
                Rectangle peshacki = new Rectangle(Width-90-2*person.person.Width - 20, sidewalk_up.Height+10+i*50, 2*person.person.Width, person.person.Height/2);
                g.FillRectangle(Brushes.WhiteSmoke, peshacki);
            }

            //cars
            foreach(Car c in cars)
            {
                c.Draw(g);
            }
            person.Draw(g);
            Rectangle r = new Rectangle(Width-sidewalk_down.Width-20, 10, 70, 130);
            g.FillRectangle(Brushes.LightGray, r);
            Rectangle r1 = new Rectangle(Width - sidewalk_down.Width-20 + 5, 13, 60, 60);
            Rectangle r2 = new Rectangle(Width - sidewalk_down.Width - 20 + 5, 75, 60, 60);
            switch (lightColor)
            {
                case false:
                    g.FillEllipse(Brushes.Red, r1);
                    g.FillEllipse(Brushes.Black, r2);
                    break;
                case true:
                    g.FillEllipse(Brushes.Black, r1);
                    g.FillEllipse(Brushes.Green, r2);
                    break;
            }
        }
    }
}
