using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VP_Proekt.Properties
{
    public class Car
    {
        public int X { get; set;}
        public int Y { get; set; }
        public Image car;
        public int formWidth { get; set; }
        public bool lightColor { get; set; }

        public Car(int X, int Y, Image car, int formWidth, bool lightColor)
        {
            Random random = new Random();
            int i = random.Next(1, 3);
            this.X = X;
            this.Y = Y*i +i/2*20;
            this.car = car;
            this.formWidth = formWidth;
            this.lightColor = lightColor;
        }

        public void Move()
        {
            
            if (X> formWidth)
            {
                X = 0;
                Random random = new Random();
                int i = random.Next(1, 3);
                this.Y = 85 * i + i / 2 * 20;
            }
            else
            {
                X += 1;
            }
        }

        public double Stop()
        {
            //distance = speed x time promeni go vremeto
            double distance = X + 1;
            double startOfZebra = formWidth - 90 - 2 * Resources.Person1_Left.Width - 20;
            double endOfZebra = formWidth - 90 - 20;

            if (distance >= startOfZebra && distance <= endOfZebra)
            {
                double time = ((startOfZebra) - X);
                return time;

            }

            return 0;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(car, X, Y, car.Width, car.Height);
        }



    }
}
