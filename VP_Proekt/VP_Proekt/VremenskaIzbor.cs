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
    public partial class VremenskaIzbor : Form
    {
        Image covece_mashko { get; set; }
        Image covece_zensko { get; set; }
        Image zima { get; set; }
        Image leto { get; set; }
        int SelectedMashkoZensko { get; set; }
        int SelectedZimaLeto { get; set; }
        public Vremenska vremenska { get; set; }
        Point click { get; set; }

        public VremenskaIzbor()
        {
            InitializeComponent();
            DoubleBuffered = true;
            covece_mashko = Resources.vremenska_covece_masko;
            covece_zensko = Resources.vremenska_covece_zensko;
            zima = Resources.summer_test;
            leto = Resources.winter;
            vremenska = new Vremenska();
            SelectedMashkoZensko = 3;
            SelectedZimaLeto = 3;

        }

        private void VremenskaIzbor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //Draw the characters
            DrawMashkoZensko(g);
            //Draw summer and winter;
            DrawZimaLeto(g);
            

          
            
        }
        private void DrawMashkoZensko(Graphics g)
        {
            if (MashkoKliknato(click) || SelectedMashkoZensko==0)
            {
                g.DrawImage(covece_mashko, 40, label1.Location.Y + label1.Height + 30, 120, 207);
                g.DrawImage(covece_zensko, 50 + 110 + 40, label1.Location.Y + label1.Height + 30, 110, 197);
                return;
            }
            if(ZenskoKliknato(click) || SelectedMashkoZensko == 1)
            {
                g.DrawImage(covece_mashko, 50, label1.Location.Y + label1.Height + 30, 110, 197);
                g.DrawImage(covece_zensko, 40 + 110 + 40, label1.Location.Y + label1.Height + 30, 120, 207);
                return;
            }
            g.DrawImage(covece_zensko, 50 + 110 + 40, label1.Location.Y + label1.Height + 30, 110, 197);
            g.DrawImage(covece_mashko, 50, label1.Location.Y + label1.Height + 30, 110, 197);
        }

        private void DrawZimaLeto(Graphics g)
        {

            if (ZimaKliknato(click) || SelectedZimaLeto==0)
            {
                g.DrawImage(zima, label2.Location.X - 14, label2.Location.Y + label2.Height + 30, 189, 109);
                g.DrawImage(leto, label2.Location.X - 9, label2.Location.Y + label2.Height + 30 + 99 + 30, 179, 99);
                return;
            }
            if (LetoKliknato(click) || SelectedZimaLeto == 1)
            {
                g.DrawImage(zima, label2.Location.X - 9, label2.Location.Y + label2.Height + 30, 179, 99);
                g.DrawImage(leto, label2.Location.X - 14, label2.Location.Y + label2.Height + 30 + 99 + 30, 189, 109);
                return;
            }
             g.DrawImage(leto, label2.Location.X - 9, label2.Location.Y + label2.Height + 30 + 99 + 30, 179, 99);
             g.DrawImage(zima, label2.Location.X - 9, label2.Location.Y + label2.Height + 30, 179, 99);
            
        }
        private bool MashkoKliknato(Point p)
        {
            if((p.X >= 50 && p.X <= 50+ 110) && (p.Y >= label1.Location.Y+label1.Height+30 && p.Y <= label1.Location.Y + label1.Height + 30 + 197))
            {
                SelectedMashkoZensko = 0;
                return true;
            }
            return false;
        }
        private bool ZenskoKliknato(Point p)
        {
            if ((p.X >= 50 + 110 + 40 && p.X <= 50 + 110 + 40 + 110) && (p.Y >= label1.Location.Y + label1.Height + 30 && p.Y <= label1.Location.Y + label1.Height + 30 + 197))
            {
                SelectedMashkoZensko = 1;
                return true;
              
            }
            return false;
        }
        private bool ZimaKliknato(Point p)
        {
            if ((p.X >= label2.Location.X - 9 && p.X <= label2.Location.X - 9 + 179) && (p.Y >= label2.Location.Y + label2.Height + 30 && p.Y <= label2.Location.Y + label2.Height + 30 +99))
            {
                SelectedZimaLeto = 0;
                return true;
            }
            return false;
        }
        private bool LetoKliknato(Point p)
        {
            if ((p.X >= label2.Location.X - 9 && p.X <= label2.Location.X - 9 + 179) && (p.Y >= label2.Location.Y + label2.Height + 30 +99 +30 && p.Y <= label2.Location.Y + label2.Height + 30 + 99 + 30 + 99))
            {
                SelectedZimaLeto = 1;
                return true;
            }
            return false;
        }
        private void VremenskaIzbor_MouseDown(object sender, MouseEventArgs e)
        {
            click = e.Location;
            MashkoKliknato(click);
            ZenskoKliknato(click);
            LetoKliknato(click);
            ZimaKliknato(click);
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vremenska = new Vremenska();
            if(SelectedMashkoZensko==3 || SelectedZimaLeto==3)
            {
                MessageBox.Show("Мора да избереш карактер и сезона");
                return;
            }
            if(SelectedZimaLeto==0)
            {
                vremenska.background = zima;
            }
            if(SelectedZimaLeto==1)
            {
                vremenska.background = leto;
            }
            if(SelectedMashkoZensko==0)
            {
                vremenska.character = covece_mashko;
            }
            if(SelectedMashkoZensko==1)
            {
                vremenska.character = covece_zensko;
            }
            this.Hide();
            if (vremenska.ShowDialog() == DialogResult.Cancel)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();

            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }


        }
    }
}
