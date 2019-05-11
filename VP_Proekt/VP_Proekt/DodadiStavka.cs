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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Stavka = new Stavka();
            Stavka.Name = tbName.Text;
            Stavka.Category = tbCategory.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

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

        private void tbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (tbCategory.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(tbCategory, "Категоријата е задолжителна");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCategory, null);
                e.Cancel = false;
            }
        }
    }
}
