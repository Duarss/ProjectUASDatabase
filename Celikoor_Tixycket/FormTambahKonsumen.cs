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
    public partial class FormTambahKonsumen : Form
    {
        public FormTambahKonsumen()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Konsumen k = new Konsumen();
                k.Nama = textBoxNamaKonsumen.Text;
                k.NoHp = textBoxNoHpKonsumen.Text;
                if (radioButtonLakiKonsumen.Checked)
                {
                    k.Gender = "L";
                }
                else if (radioButtonPerempuanKonsumen.Checked)
                {
                    k.Gender = "P";
                }
                k.TglLahir = dateTimePickerTglLahirKonsumen.Value;
                k.Saldo = double.Parse(textBoxSaldoKonsumen.Text);
                k.Username = textBoxUsernameKonsumen.Text;
                k.Password = textBoxPasswordKonsumen.Text;

                Konsumen.TambahData(k);
                MessageBox.Show("Tambah data berhasil");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Tambah data gagal. Error: " + x.Message);
            }
        }

        private void FormTambahKonsumen_Load(object sender, EventArgs e)
        {
            textBoxNamaKonsumen.Select();
        }
    }
}
