using Celikoor_LIB;
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
    public partial class FormTambahKelompok : Form
    {
        public FormTambahKelompok()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Kelompok k = new Kelompok();
                k.Id = int.Parse(textBoxIdKelompok.Text);
                k.Nama = textBoxNamaKelompok.Text;

                Kelompok.TambahData(k);
                MessageBox.Show("Tambah data berhasil");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Tambah data gagal. Error: " + x.Message);
            }
        }
    }
}
