using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VP_Proekt.Properties;

namespace VP_Proekt
{
    //class inbetween Vremenska and Obleka, doing all the process which Vremenska needs to be done for a List of Obleka
    public class KlasaZaObleki
    {
        public List<Obleka> alista { get; set; }
        public Obleka.SEZONA sezona { get; set; }
        public bool mashko { get; set; }
        public Obleka selectedObleka { get; set; }
        const int WIDTH_HEIGHT_OBLEKA = 220;

        public KlasaZaObleki(bool mashko)
        {
            if (mashko)
            {
                alista = new List<Obleka>
            {
                new Obleka(20, 10, Resources.masko_bluza, Obleka.SEZONA.LETO),
                new Obleka(20,WIDTH_HEIGHT_OBLEKA+30, Resources.masko_dzemper, Obleka.SEZONA.ZIMA),
                new Obleka(WIDTH_HEIGHT_OBLEKA+40,10, Resources.masko_pantaloni, Obleka.SEZONA.ZIMA),
                new Obleka(WIDTH_HEIGHT_OBLEKA*2+60,10, Resources.masko_patiki, Obleka.SEZONA.LETO),
                new Obleka(20, WIDTH_HEIGHT_OBLEKA*2+50, Resources.uni_shorcevi, Obleka.SEZONA.LETO),
                new Obleka(WIDTH_HEIGHT_OBLEKA+40,WIDTH_HEIGHT_OBLEKA+30, Resources.uni_dukser, Obleka.SEZONA.ZIMA),
                new Obleka(WIDTH_HEIGHT_OBLEKA*2+60,WIDTH_HEIGHT_OBLEKA+30, Resources.uni_cizmi, Obleka.SEZONA.ZIMA),
            };

            }
            else
            {
                alista = new List<Obleka>
            {
                new Obleka(20, 10, Resources.zensko_bluza, Obleka.SEZONA.LETO),
                new Obleka(20,WIDTH_HEIGHT_OBLEKA+30, Resources.zensko_pantaloni, Obleka.SEZONA.ZIMA),
                new Obleka(WIDTH_HEIGHT_OBLEKA+40,10, Resources.zensko_suknja, Obleka.SEZONA.LETO),
                new Obleka(WIDTH_HEIGHT_OBLEKA*2+60,10, Resources.zensko_patiki, Obleka.SEZONA.LETO),
                new Obleka(20, WIDTH_HEIGHT_OBLEKA*2+50, Resources.uni_shorcevi, Obleka.SEZONA.LETO),
                new Obleka(WIDTH_HEIGHT_OBLEKA+40,WIDTH_HEIGHT_OBLEKA+30, Resources.uni_dukser, Obleka.SEZONA.ZIMA),
                new Obleka(WIDTH_HEIGHT_OBLEKA*2+60,WIDTH_HEIGHT_OBLEKA+30, Resources.uni_cizmi, Obleka.SEZONA.ZIMA),
            };

            }
        }
        
        public void DrawRectagles(Graphics g)
        {
            Pen pn = new Pen(Color.Black, 4);
            SolidBrush sb = new SolidBrush(Color.FromArgb(50, 0, 0, 0));

            foreach (Obleka o in alista)
            {
                g.DrawRectangle(pn, o.startX, o.startY, WIDTH_HEIGHT_OBLEKA, WIDTH_HEIGHT_OBLEKA);
                g.FillRectangle(sb, o.startX, o.startY, WIDTH_HEIGHT_OBLEKA, WIDTH_HEIGHT_OBLEKA);
            }

        }
        public void Draw(Graphics g)
        {
            foreach (Obleka o in alista)
            {
                o.Draw(g);
            }
            if (selectedObleka != null)
            {
                selectedObleka.Draw(g);
            }
        }
        public  void  SelectObleka(float x, float y)
        {
            foreach (Obleka o in alista)
            {
                if (o.isOver(x, y))
                {
                    selectedObleka = o;
                    return;
                }

            }
            selectedObleka = null;
        }
        public void Pogodok(int characterWidth, int characterHeight, int formWidth, int formHeight)
        {
            foreach (Obleka o in alista)
            {
                //if an item from alishta is dropped near the character, the item will disappear 
                o.IsHit(characterWidth, characterHeight, formWidth, formHeight, sezona);
            }
        }
        public void Move(float x, float y)
        {
            foreach(Obleka o in alista)
            {
                if(o==selectedObleka)
                {
                    o.Move(x, y);
                }
            }
        }
        public bool  ProveriDaliPobedil()
        {
            foreach(Obleka o in alista)
            {
                if(o.sezona==sezona && o.Pogodok!=true)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
