using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VP_Proekt.Properties;

namespace VP_Proekt
{
   

    public class Obleka
    {
        public enum SEZONA
        {
            LETO,
            ZIMA
        }
        public float X { get; set; }
        public float Y { get; set; }
        public float startX { get; set; }
        public float startY { get; set; }
        public Image image { get; set; }
        public SEZONA sezona { get; set; }
        public bool Pogodok { get; set; }

        public Obleka(float x, float y, Image img, SEZONA sez)
        {
            X = x;
            Y = y;
            startX = x;
            startY = y;
            image = img;
            sezona = sez;
            Pogodok = false;
        }

        public void Draw(Graphics g)
        {
            //if the player did't chose the corect image 
            if (!Pogodok)
            {
                g.DrawImage(image, X, Y, image.Width, image.Height);
            }
            //if the player chosed the corect image
            else
            {
                //Math so the check image can be in the midle of the rectangle 
                g.DrawImage(Resources.check, X+(image.Width/2)-(Resources.check.Width/2), Y + (image.Height / 2) - (Resources.check.Height / 2), Resources.check.Width, Resources.check.Height);
            }
        }

        public bool isOver(float x, float y)
        {
            return Math.Abs(X - x) <= image.Width  && Math.Abs(Y - y) <= image.Height;
        }

        public void Move(float dx, float dy)
        {
            //07.01.2019 do not move the check image
            if (!Pogodok)
            {
                X += dx;
                Y += dy;
            }
        }
        public bool  IsHit(int CharacterWidth, int CharacterHeight, int formWidth, int formHeight, SEZONA sezona)
        {
            //checks if the image is dropped in the right place
            int XPositionOfCharacter = formWidth - CharacterWidth-130;
            int YPositionOfCharacter = formHeight - CharacterHeight-100;
            if((X>XPositionOfCharacter && Y>YPositionOfCharacter) && (X+ image.Width < formWidth && Y+image.Height < formHeight))
            {
                if (sezona == this.sezona)
                {
                    Pogodok = true;

                }
                X = startX;
                Y = startY;
                return true;
            }
            X = startX;
            Y = startY;
            return false;
        }
    }
}
