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
        //Initialize properties
        int timeElapsed;
        List<Stavka> stavki;
        string[] kategorii;
        int pogodeniLevo;
        int pogodeniDesno;
        int noStavki;

        public Prostorna()
        {
            InitializeComponent();
            //Initialize a couple of stavki for start
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
            //Initialize categories
            kategorii = new string[] { "Зеленчук", "Овошје" };
            //Start with a new game
            newGame();
        }

        // Reset all the needed properties, fill Primary list with start items, start the timer
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
            noStavki = lbPrimary.Items.Count;
            lblRight.Text = kategorii[0];
            lblLeft.Text = kategorii[1];
            pbPogodeni.Maximum = noStavki;
            pbPogodeni.Value = 0;
            timer1.Start();
        }

        // Set the time elapsed label in the form and update the progress bar
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed++;
            int min = timeElapsed / 60;
            int sec = timeElapsed % 60;
            lblTimer.Text = String.Format("{0:00}:{1:00}", min, sec);
            pbPogodeni.Value = Convert.ToInt32(tbPogodeniLeft.Text) + Convert.ToInt32(tbPogodeniRight.Text);
            //If all items in correct lists stop the timer and start a new game (confirmation dialog)
            if(pbPogodeni.Value == pbPogodeni.Maximum)
            {
                timer1.Stop();
                if (MessageBox.Show("Нова игра?", String.Format("Ја завршивте играта за {0:00}:{1:00}", min, sec), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    newGame();
                }
            }
        }

        //Add new Stavka item
        private void btnDodadi_Click(object sender, EventArgs e)
        {
            //Confirmation dialog for adding a new item; must start a new game
            if (MessageBox.Show("Со додавањето на нова ставка ќе мора да започнете нова игра. Дали сте сигурни?", "Потврда за додавање?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Open new form for adding an item
                DodadiStavka dodadiStavka = new DodadiStavka();
                if (dodadiStavka.ShowDialog() == DialogResult.OK)
                {
                    //Add item if dialog returned OK result, start new game with updated list
                    stavki.Add(dodadiStavka.Stavka);
                    newGame();
                }
            }
        }

        //Delete item from stavki list
        private void btnIzbrishi_Click(object sender, EventArgs e)
        {
            //Check if an item is selected
            if (lbPrimary.SelectedIndex != -1)
            {
                //Confirmation dialog for deleting an item; must start a new game
                if (MessageBox.Show("Дали сте сигурни дека сакате да ја избришете оваа ставка? Со ова се започнува нова игра!", "Потврда за бришење?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Delete the item if dialog returned OK result, start new game with updated list
                    stavki.Remove(lbPrimary.SelectedItem as Stavka);
                    newGame();
                }
            }
        }

        //Move selected items from source list to destination list
        private void moveListItems(ListBox source, ListBox destination)
        {
            //Check if an item is selected
            if (source.SelectedIndex != -1)
            {
                //Move all selected items, multiple selection enabled
                foreach (var item in source.SelectedItems)
                {
                    destination.Items.Add(item);
                }
                //Remove the selected items from the source list, while there are selected items
                //Must do this, because they will remain in the source list too
                while (source.SelectedItems.Count > 0)
                {
                    source.Items.Remove(source.SelectedItems[0]);
                }
            }
        }

        //Move selected items from Primary to the Right list
        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            moveListItems(lbPrimary, lbRight);
            pogodeniDesno = 0;
            //Check if the category of the items corresponds to the category of the right list(label)
            foreach (var item in lbRight.Items)
            {
                Stavka s = item as Stavka;
                if (s.Category == lblRight.Text)
                {
                    //Count correct items in list
                    pogodeniDesno++; 
                }
            }
            //Update the number of correct items
            tbPogodeniRight.Text = pogodeniDesno.ToString();
        }

        //Move selected items from Primary to the Left list
        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            moveListItems(lbPrimary, lbLeft);
            pogodeniLevo = 0;
            //Check if the category of the items corresponds to the category of the left list(label)
            foreach (var item in lbLeft.Items)
            {
                Stavka s = item as Stavka;
                if (s.Category == lblLeft.Text)
                {
                    //Count correct items in list
                    pogodeniLevo++; 
                }
            }
            //Update the number of correct items
            tbPogodeniLeft.Text = pogodeniLevo.ToString();
        }

        //Move items from the Left list back to the Primary list
        private void btnMoveBackRight_Click(object sender, EventArgs e)
        {
            moveListItems(lbLeft, lbPrimary);
            pogodeniLevo = 0;
            foreach (var item in lbLeft.Items)
            {
                Stavka s = item as Stavka;
                if (s.Category == lblLeft.Text)
                {
                    //Count correct items in Left list
                    pogodeniLevo++; 
                }  
            }
            //Update the number of correct items in the Left list
            tbPogodeniLeft.Text = pogodeniLevo.ToString();
        }

        //Move items from the Right list back to the Primary list
        private void btnMoveBackLeft_Click(object sender, EventArgs e)
        {
            moveListItems(lbRight, lbPrimary);
            pogodeniDesno = 0;
            foreach (var item in lbRight.Items)
            {
                Stavka s = item as Stavka;
                if (s.Category == lblRight.Text)
                {
                    //Count correct items in Right list
                    pogodeniDesno++;
                }
            }
            //Update the number of correct items in the Right list
            tbPogodeniRight.Text = pogodeniDesno.ToString();
        }

        //Start a new game (confirmation dialog)
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да започнете нова игра?", "Нова игра?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                newGame();
            }
        }
    }
}
