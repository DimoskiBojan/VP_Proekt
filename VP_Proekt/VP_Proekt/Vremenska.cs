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
    public partial class Vremenska : Form
    {
        Image character;
        List<Obleka> alista;
        bool mouseDown;
        Obleka selectedObleka;
        float previousX;
        float previousY;
        const int WIDTH_HEIGHT_OBLEKA = 220;

        public Vremenska()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            character = Resources.vremenska_covece_masko;
            this.ClientSize = new Size(1280, 720);
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
            this.BackgroundImage = Resources.summer_test;
        }

        private void Vremenska_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            Pen pn = new Pen(Color.Black, 4);
            SolidBrush sb = new SolidBrush(Color.FromArgb(50, 0, 0, 0));

            foreach (Obleka o in alista)
            {
                g.DrawRectangle(pn, o.startX, o.startY, WIDTH_HEIGHT_OBLEKA, WIDTH_HEIGHT_OBLEKA);
                g.FillRectangle(sb, o.startX, o.startY, WIDTH_HEIGHT_OBLEKA, WIDTH_HEIGHT_OBLEKA);
            }

            g.DrawImage(character, Width - character.Width - 50, Height - character.Height - 60, character.Width, character.Height);

            foreach (Obleka o in alista)
            {
                o.Draw(g);
            }
            if (selectedObleka != null)
            {
                selectedObleka.Draw(g);
            }
            
        }

        private void Vremenska_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            selectedObleka = SelectObleka(e.X, e.Y);
            previousX = e.X;
            previousY = e.Y;
        }

        private void Vremenska_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (selectedObleka != null)
                {
                    float dx = e.X - previousX;
                    float dy = e.Y - previousY;
                    selectedObleka.Move(dx, dy);
                    Cursor = Cursors.Hand;
                    Invalidate();
                }
                previousX = e.X;
                previousY = e.Y;
            }
        }

        private void Vremenska_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            Cursor = Cursors.Default;
        }

        private Obleka SelectObleka(float x, float y)
        {
            foreach(Obleka o in alista)
            {
                if(o.isOver(x, y))
                {
                    return o;
                }
                
            }
            return null;
        }
    }
}
