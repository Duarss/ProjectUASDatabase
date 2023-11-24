using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Tixycket
{
    public partial class FormTambahAktor : Form
    {
        public FormTambahAktor()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Aktor a = new Aktor();
                a.Id = int.Parse(textBoxIdAktor.Text);
                a.Nama = textBoxNamaAktor.Text;
                a.TglLahir = dateTimePickerTglLahirAktor.Value;
                if (radioButtonLakiAktor.Checked)
                {
                    a.Gender = "L";
                }
                else if (radioButtonPerempuanAktor.Checked)
                {
                    a.Gender = "P";
                }
                a.NegaraAsal = textBoxNegaraAsalAktor.Text;

                Aktor.TambahData(a);
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
