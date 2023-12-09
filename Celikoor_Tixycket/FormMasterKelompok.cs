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
    public partial class FormMasterKelompok : Form
    {
        public FormMasterKelompok()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahKelompok formTambahKelompok = new FormTambahKelompok();
            formTambahKelompok.Owner = this;
            formTambahKelompok.ShowDialog();
        }
    }
}
