using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VP_Proekt
{
    public partial class DodadiStavka : Form
    {
        public Stavka Stavka { get; set; }

        public DodadiStavka()
        {
            InitializeComponent();
        }

        //If canceled, close the form with Cancel result
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        //If validation succeeds, make new Stavka with entered info, close the form with OK result
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string image;
            Stavka = new Stavka();
            Stavka.Name = tbName.Text;
            Stavka.Category = cbCategory.Text;
            Stavka.description = textBoxOpis.Text;
            if(tbName.Text.Trim().Length != 0 && textBoxOpis.Text.Trim().Length != 0 && cbCategory.SelectedIndex != -1)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Мора да се внесат сите податоци");
            }
        }

        //Validating the name, can't be empty
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (tbName.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbName, "Името е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbName, null);
                e.Cancel = false;
            }
        }

        //Validating the category, can't be empty
        private void cbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (cbCategory.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbCategory, "Категоријата е задолжителна");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbCategory, null);
                e.Cancel = false;
            }
        }

        private void textBoxOpis_Validating(object sender, CancelEventArgs e)
        {
            if (textBoxOpis.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(textBoxOpis, "Описот е задолжително");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBoxOpis, null);
                e.Cancel = false;
            }

        }

        private void buttonDodadiSlika_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|png files(*.png)|*.png";

                if(dialog.ShowDialog()==DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox.ImageLocation = imageLocation;



                }
            }
            catch (Exception) {
            }

        }
    }
}
