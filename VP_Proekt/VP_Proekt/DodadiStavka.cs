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
            Stavka = new Stavka();
            Stavka.Name = tbName.Text;
            Stavka.Category = cbCategory.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
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
    }
}
