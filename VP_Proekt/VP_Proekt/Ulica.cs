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
        Image person_up;
        Image car1;
        Image car2;
        Image car3;
        Image sidewalk_up;
        Image sidewalk_down;
        Image street;

        public Ulica()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            person_up = Resources.Person1_Up;
            car1 = Resources.car1;
            car2 = Resources.car2;
            car3 = Resources.car3;
            street = Resources.street;
            sidewalk_up = Resources.sidewalk_Up;
            sidewalk_down = Resources.sidewalk__Down;

        }

        private void Ulica_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for(int i=0;i<this.Width;i++)
            {
                g.DrawImage(sidewalk_up, i*sidewalk_up.Width, sidewalk_down.Height+street.Height, sidewalk_up.Width, sidewalk_up.Height);
                g.DrawImage(sidewalk_down, i * sidewalk_down.Width, 0, sidewalk_down.Width, sidewalk_down.Height);
                g.DrawImage(street, i*street.Width, sidewalk_up.Height, street.Width, street.Height);
            }
        }
    }
}
