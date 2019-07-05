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
        Timer time;
        int time_min;
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
            Height = sidewalk_down.Height * 2 + street.Height + 40;
            person = new Covece();
            person.formWidth = Width;
            person.formHeight = Height;
            lightColor = true;
            time_min = 1;
            labeltime.Text = string.Format("{0:00}", time_min);
            count = 0;
            //cars
            cars = new List<Car>()
            {
                new Car(0,85,Resources.car1, Width, true ),
                new Car(180,85,Resources.car2, Width, true ),
                new Car(360,85,Resources.car3, Width, true ),

             };

            time = new Timer();
            time.Interval = 1000;
            time.Tick += new EventHandler(time_Tick);
            time.Start();

            timerSemaphore = new Timer();
            timerSemaphore.Interval = 10000;
            timerSemaphore.Tick += new EventHandler(timerSemaphore_Tick);
            timerSemaphore.Start();

            timer = new Timer();
            timer.Interval = 1;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

        }
        void time_Tick(object sender, EventArgs e)
        {
            time_min += 1;
            labeltime.Text = string.Format("{0:00}", time_min);
            person.NaZebraICrvenoSvetlo();
        }

        void timer_Tick(object sender, EventArgs e)
        {
            foreach (Car c in cars)
            {
                bool i = c.PredMene(cars[0].X, cars[0].Y);
                bool j= c.PredMene(cars[1].X, cars[1].Y);
                bool k= c.PredMene(cars[2].X, cars[2].Y);
                if(i || j || k)
                {
                    c.kolapredtebe = true;
                }
                else
                {
                    c.kolapredtebe = false;
                }
                c.Move(Width);
            }

            Invalidate();
        }


        void timerSemaphore_Tick(object sender, EventArgs e)
        {
            time_min = 0;
            lightColor = !lightColor;
            foreach (Car c in cars)
            {
                c.lightColor = lightColor;
            }
            person.lightColor = lightColor;

            Invalidate();
        }

        private void Ulica_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
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
            if (e.KeyCode == Keys.Down)
            {
                person.ChangeDirection(Covece.DIRECTION.DOWN);
                person.Move();
            }
            if (e.KeyCode == Keys.Right)
            {
                person.ChangeDirection(Covece.DIRECTION.RIGHT);
                person.Move();
            }
            if (person.Y == 20)
            {
                if (lightColor)
                {
                    Pomoshna pomoshna = new Pomoshna();
                    pomoshna.text1 = "Браво!!!!!";
                    pomoshna.text2 = "Успешно поминавте од другата страна на коловозот.";
                    pomoshna.text3 = "Дали сакате да се обидете повторно?";
                    pomoshna.buttonYes = "Да";
                    pomoshna.buttonNo = "Не";
                    pomoshna.smiley = Resources.smiley;
                    if (pomoshna.ShowDialog() == DialogResult.OK)
                    {
                        newGame();
                    }
                    else
                    {
                        Close();
                    }
                }
                Invalidate();
            }
        }


            private void Ulica_Paint(object sender, PaintEventArgs e)
            {
                Graphics g = e.Graphics;
                g.Clear(Color.White);
                for (int i = 0; i < this.Width; i++)
                {
                    g.DrawImage(sidewalk_up, i * sidewalk_up.Width, sidewalk_down.Height + street.Height, sidewalk_up.Width, sidewalk_up.Height);
                    g.DrawImage(sidewalk_down, i * sidewalk_down.Width, 0, sidewalk_down.Width, sidewalk_down.Height);
                    g.DrawImage(street, i * street.Width, sidewalk_up.Height, street.Width, street.Height);
                }
                //peshacki
                for (int i = 0; i < 4; i++)
                {
                    Rectangle peshacki = new Rectangle(Width- 2 * person.person.Width-20-90, sidewalk_up.Height + 10 + i * 50, 2 * person.person.Width, person.person.Height / 2);
                    g.FillRectangle(Brushes.WhiteSmoke, peshacki);
                }
               

            //cars
            foreach (Car c in cars)
                {
                    c.Draw(g);
                }
                person.Draw(g);
                Rectangle r = new Rectangle(Width - sidewalk_down.Width-20, 10, 70, 130);
                g.FillRectangle(Brushes.LightGray, r);
                labeltime.Location = new Point(Width - sidewalk_down.Width , 10+130);
                Rectangle r1 = new Rectangle(Width - sidewalk_down.Width - 20 + 5, 13, 60, 60);
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

