using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Obleka(float x, float y, Image img, SEZONA sez)
        {
            X = x;
            Y = y;
            startX = x;
            startY = y;
            image = img;
            sezona = sez;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(image, X, Y, image.Width, image.Height);
        }

        public bool isOver(float x, float y)
        {
            return Math.Abs(X - x) <= image.Width  && Math.Abs(Y - y) <= image.Height;
        }

        public void Move(float dx, float dy)
        {
            X += dx;
            Y += dy;
        }
    }
}
