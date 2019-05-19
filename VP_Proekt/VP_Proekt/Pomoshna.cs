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
    public partial class Pomoshna : Form
    {
        public Image smiley { get; set; }
        public string text1 { get; set; }
        public string text2 { get; set; }
        public string text3 { get; set; }
        public string buttonYes { get; set; }
        public string buttonNo { get; set; }
        public Pomoshna()
        {
            InitializeComponent();
            smiley = null;
            text1 = null;
            text2 = null;
            text3 = null;
            
        }
        private void WidthForm()
        {
            int i = Math.Max(smiley.Width, labelBravo.Width);
            if(Math.Max(labelObidPovtorno.Width, labelUspeshno.Width) > i)
            {
                i = Math.Max(labelObidPovtorno.Width, labelUspeshno.Width);
            }
            Width =i+ 20;

       

        }

        private void Win_Paint(object sender, PaintEventArgs e)
        {
            
            Height = smiley.Height + 40 + labelUspeshno.Height + 10 + labelObidPovtorno.Height + 10 + labelBravo.Height + 20 + buttonDa.Height;
            WidthForm();
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.DrawImage(smiley, 10, 10, smiley.Width, smiley.Height);
            Point point = new Point();

            labelBravo.Text = text1;
            point.X = Width / 2 - labelBravo.Width / 2;
            point.Y = smiley.Height + 10;
            labelBravo.Location = point;

            labelUspeshno.Text = text2;
            point.X = Width / 2 - labelUspeshno.Width / 2;
            point.Y = smiley.Height + 10 + labelBravo.Height + 10;
            labelUspeshno.Location = point;

            labelObidPovtorno.Text = text3;
            point.X = Width / 2 - labelObidPovtorno.Width / 2;
            point.Y = smiley.Height + 10 + labelBravo.Height + 10 + labelUspeshno.Height + 10;
            labelObidPovtorno.Location = point;

            buttonDa.Text = buttonYes;

            if (buttonNo != null)
            {
                point.X = Width / 2 - 20 - buttonDa.Width;
                point.Y = smiley.Height + 10 + labelBravo.Height + 10 + labelUspeshno.Height + 10 + labelObidPovtorno.Height + 10;
                buttonDa.Location = point; 

                buttonNe.Text = buttonNo;
                point.X += buttonDa.Width + 20;
                buttonNe.Location = point;
            }
            else
            {
                point.X = Width / 2  - buttonDa.Width/2;
                point.Y = smiley.Height + 10 + labelBravo.Height + 10 + labelUspeshno.Height + 10 + labelObidPovtorno.Height + 10;
                buttonDa.Location = point;
                buttonNe.Hide();

            }


        }

        private void buttonDa_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonNe_Click(object sender, EventArgs e)
        {
            DialogResult =DialogResult.Cancel;
            Close();
        }
    }
}
