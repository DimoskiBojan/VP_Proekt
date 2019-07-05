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
        public Image character { get; set; }
        public Image background { get; set; }
        bool mouseDown;
        public KlasaZaObleki Obleki { get; set; }
        float previousX;
        float previousY;
        
        public Vremenska(bool zima, bool mashko, Image background, Image character)
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.ClientSize = new Size(1280, 720);
            this.character = character;
            this.background = background;
            //checks if the character is a boy
            Obleki = new KlasaZaObleki(mashko);
            Obleki.sezona = (zima ? Obleka.SEZONA.LETO : Obleka.SEZONA.ZIMA);
            
            

        }

        private void Vremenska_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Image image = new Bitmap(background);
            BackgroundImage = image;
            // Drawing rectagles for Obleka
            Obleki.DrawRectagles(g);
            // Drawing the character
            g.DrawImage(character, Width - character.Width - 50, Height - character.Height - 60, character.Width, character.Height);
            //Draw Obleka
            Obleki.Draw(g);
        }

        private void Vremenska_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            Obleki.SelectObleka(e.X, e.Y);
            previousX = e.X;
            previousY = e.Y;
        }

        private void Vremenska_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                if (Obleki.selectedObleka != null)
                {
                    float dx = e.X - previousX;
                    float dy = e.Y - previousY;
                    Obleki.Move(dx, dy);
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
            Obleki.Pogodok(character.Width, character.Height, this.Width, this.Height);
            if(Obleki.ProveriDaliPobedil())
            {
                Pomoshna pomoshna = new Pomoshna();
                pomoshna.smiley = Resources.smiley;
                pomoshna.text1 = "Браво !!!";
                pomoshna.text2 = "Ја завршивте играта";
                pomoshna.text3 = "Дали сакате нова игра?";
                pomoshna.buttonYes = "Да";
                pomoshna.buttonNo = "Не";
                if (pomoshna.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    DialogResult=DialogResult.Cancel;
                    this.Close();
                }
            }
        }

   
    }
}
