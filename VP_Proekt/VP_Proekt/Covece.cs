using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VP_Proekt.Properties;

namespace VP_Proekt
{
    public class Covece
    {
        public enum DIRECTION
        {
            UP,
            DOWN,
            LEFT,
            RIGHT

        }
        public Image person;
        public int X { get; set; }
        public int Y { get; set; }
        public DIRECTION direction { get; set; }
        public int formWidth { get; set; }

        public Covece()
        {
            
            person = Resources.Person1_Up;
            Random random = new Random();
            int i=random.Next(0, 9);
            X = i * person.Width;
            Y = 300;
            direction = DIRECTION.UP;
        }

        public bool CheckLocation()
        {
            int startOfZebra = formWidth - 90 - 2 * person.Width - 20;
            int endOfZebra = startOfZebra + 2 * person.Width;

            if(X>=startOfZebra && X+person.Width<=endOfZebra)
            {
                return true;
            }

            return false;
        }
        public void ChangeDirection(DIRECTION d)
        {
            direction = d;
        }
        public void Move ()
        {
            if(direction==DIRECTION.UP)
            {
                person = Resources.Person1_Up;
                if((Y-10)>0)
                {
                    Y -= 10;
                }
                if(!CheckLocation())
                {
                    Y += 10;
                }
               


            }
            if (direction == DIRECTION.LEFT)
            {
                person = Resources.Person1_Left;
                if ((X - 10) > 0)
                {
                    X-= 10;
                }
                if(Y<300)
                {
                    if (!CheckLocation())
                    {
                        X += 10;
                    }
                }
                
                

            }
            if (direction == DIRECTION.RIGHT)
            {
                person = Resources.Person1_Right;
                if ((X + 10) < formWidth-person.Width)
                {
                    X += 10;
                }
                if (Y < 300)
                {
                    if (!CheckLocation())
                    {
                        X -= 10;
                    }
                }


            }
           

        }
         public void Draw(Graphics g)
        {
            g.DrawImage(person, X, Y, person.Width, person.Height);
        }




    }
}
