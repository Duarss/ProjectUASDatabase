using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormMasterStudio : Form
    {
        public FormMasterStudio()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahStudio frmTambahStudio = new FormTambahStudio();
            frmTambahStudio.Owner = this;
            frmTambahStudio.ShowDialog();
            FormMasterStudio_Load(this, e);
        }

        private void FormMasterStudio_Load(object sender, EventArgs e)
        {

        }

        private void textboxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception x)
            {
                // empty
            }
        }
    }
}
