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
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUlica_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Помини ја улицата на пешачкиот премин. Внимавај на светлото на семафорот!",
                                     "Почни нова игра",
                                     MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                this.Hide();
                Ulica ulica = new Ulica();
                DialogResult result = ulica.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
        }

        private void btnProstorna_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Премести ги овошјата и зеленчуците од листата во средина во соодветните листи според насловот.",
                                     "Почни нова игра",
                                     MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                this.Hide();
                Prostorna prostorna = new Prostorna();
                DialogResult result = prostorna.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
        }

        private void btnVremenska_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Избери карактер и облечи го според зададената временската сезона",
                                     "Почни нова игра",
                                     MessageBoxButtons.OKCancel);
            if (confirmResult == DialogResult.OK)
            {
                this.Hide();
                Vremenska vremenska = new Vremenska();
                DialogResult result = vremenska.ShowDialog();
                if (result == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
        }
    }
}
