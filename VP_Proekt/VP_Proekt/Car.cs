using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VP_Proekt.Properties;

namespace VP_Proekt
{
    public class Car
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int pocetna { get; set; }
        public Image car;
        public int formWidth { get; set; }
        public bool lightColor { get; set; }
        public bool kolapredtebe {get;set;}
        public Car(int X, int Y, Image car, int formWidth, bool lightColor)
        {
            Random random = new Random();
            int i = random.Next(1, 3);
            this.X = X;
            this.Y = Y * i + i / 2 * 20;
            this.car = car;
            this.formWidth = formWidth;
            this.lightColor = lightColor;
        }

        public void Move(int formWidth)
        {

            if (X > formWidth)
            {
                X = 0;
                Random random = new Random();
                int i = random.Next(1, 3);
                this.Y = 85 * i + i / 2 * 20;
                
            }
            else
            {
                int pocetokPeshacki = formWidth- 2 * Resources.Person1_Up.Width - 20 - 90;
                int kola = X + car.Width;
                if (!lightColor)
                {
                    X += 2;
                }
                else
                {
                    if (!kolapredtebe)
                    {
                        if (kola > pocetokPeshacki + 20)
                        {
                            X += 2;
                        }
                        if (kola < pocetokPeshacki)
                        {
                            X += 2;
                        }
                    }
                }
            }
        }
        public bool PredMene(int X, int Y)
        {
            //check if the front of this car is neer car in front of this one
            int ovaaKola = this.X + 180;
            if(this.Y==Y && ovaaKola==X)
            {
                return true;
            }
            return false;
        }
        public void Draw(Graphics g)
        {
            
            g.DrawImage(car, X, Y, car.Width, car.Height);
        }



    }
}
