using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt
{
    public partial class Prostorna : Form
    {

        int timeElapsed;
        List<Stavka> stavki;
        string[] kategorii;
        int pogodeniLevo;
        int pogodeniDesno;
        int noItems;

        public Prostorna()
        {
            InitializeComponent();
            stavki = new List<Stavka>()
            {
                new Stavka("Јагода", "Овошје"),
                new Stavka("Банана", "Овошје"),
                new Stavka("Јаболко", "Овошје"),
                new Stavka("Марула", "Зеленчук"),
                new Stavka("Зелка", "Зеленчук"),
                new Stavka("Краставица", "Зеленчук"),
                new Stavka("Брокула", "Зеленчук")
            };
            kategorii = new string[] { "Зеленчук", "Овошје" };
            newGame();
        }

        private void newGame()
        {
            timeElapsed = 0;
            pogodeniLevo = 0;
            pogodeniDesno = 0;
            tbPogodeniLeft.Text = pogodeniLevo.ToString();
            tbPogodeniRight.Text = pogodeniDesno.ToString();
            lbPrimary.Items.Clear();
            lbLeft.Items.Clear();
            lbRight.Items.Clear();
            foreach(Stavka s in stavki)
            {
                lbPrimary.Items.Add(s);
            }
            noItems = lbPrimary.Items.Count;
            lblRight.Text = kategorii[0];
            lblLeft.Text = kategorii[1];
            pbPogodeni.Maximum = noItems;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            int min = timeElapsed / 60;
            int sec = timeElapsed % 60;
            lblTimer.Text = String.Format("{0:00}:{1:00}", min, sec);
            pbPogodeni.Value = Convert.ToInt32(tbPogodeniLeft.Text) + Convert.ToInt32(tbPogodeniRight.Text);
            if(pbPogodeni.Value == pbPogodeni.Maximum)
            {
                timer1.Stop();
                if (MessageBox.Show("Нова игра?", String.Format("Ја завршивте играта за {0:00}:{1:00}", min, sec), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    newGame();
                }
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Со додавањето на нова ставка ќе мора да започнете нова игра. Дали сте сигурни?", "Потврда за додавање?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DodadiStavka dodadiStavka = new DodadiStavka();
                if (dodadiStavka.ShowDialog() == DialogResult.OK)
                {
                    stavki.Add(dodadiStavka.Stavka);
                    newGame();
                }
            }
            
        }

        private void btnIzbrishi_Click(object sender, EventArgs e)
        {
            if (lbPrimary.SelectedIndex != -1)
            {
                if (MessageBox.Show("Дали сте сигурни дека сакате да ја избришете оваа ставка? Со ова се започнува нова игра!", "Потврда за бришење?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    stavki.Remove(lbPrimary.SelectedItem as Stavka);
                    lbPrimary.Items.RemoveAt(lbPrimary.SelectedIndex);
                    newGame();
                }
            }
        }

        private void moveListItems(ListBox source, ListBox destination)
        {
            if (source.SelectedIndex != -1)
            {
                foreach (var item in source.SelectedItems)
                {
                    destination.Items.Add(item);
                }
                while (source.SelectedItems.Count > 0)
                {
                    source.Items.Remove(source.SelectedItems[0]);
                }
            }
        }


        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            moveListItems(lbPrimary, lbRight);
            pogodeniDesno = 0;
            foreach (var item in lbRight.Items)
            {
                Stavka s = item as Stavka;
                if (s.Category == lblRight.Text)
                {
                    pogodeniDesno++; 
                }
            }
            tbPogodeniRight.Text = pogodeniDesno.ToString();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            moveListItems(lbPrimary, lbLeft);
            pogodeniLevo = 0;
            foreach (var item in lbLeft.Items)
            {
                Stavka s = item as Stavka;
                if (s.Category == lblLeft.Text)
                {
                    pogodeniLevo++; 
                }
            }
            tbPogodeniLeft.Text = pogodeniLevo.ToString();
        }

        private void btnMoveBackRight_Click(object sender, EventArgs e)
        {
            moveListItems(lbLeft, lbPrimary);
            pogodeniLevo = 0;
            foreach (var item in lbLeft.Items)
            {
                Stavka s = item as Stavka;
                if (s.Category == lblLeft.Text)
                {
                    pogodeniLevo++; 
                }  
            }
            tbPogodeniLeft.Text = pogodeniLevo.ToString();
        }

        private void btnMoveBackLeft_Click(object sender, EventArgs e)
        {
            moveListItems(lbRight, lbPrimary);
            pogodeniDesno = 0;
            foreach (var item in lbRight.Items)
            {
                Stavka s = item as Stavka;
                if (s.Category == lblRight.Text)
                {
                    pogodeniDesno++;
                }
            }
            tbPogodeniRight.Text = pogodeniDesno.ToString();
        }
    }
}
