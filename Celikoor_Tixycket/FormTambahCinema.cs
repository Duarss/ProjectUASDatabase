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
    public partial class FormTambahCinema : Form
    {
        public FormTambahCinema()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Cinema c = new Cinema();
                c.Id = int.Parse(textBoxIdCinema.Text);
                c.Nama_cabang = textBoxNamaCabang.Text;
                c.Alamat = textBoxAlamatCinema.Text;
                c.TglDibuka = dateTimePickerTglDibukaCInema.Value;
                c.Kota = textBoxKotaCinema.Text;

                Cinema.TambahData(c);
                MessageBox.Show("Tambah data berhasil");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Tambah data gagal. Error: " + x.Message);
            }
        }

        private void FormTambahCinema_Load(object sender, EventArgs e)
        {
            textBoxIdCinema.Select();
        }
    }
}
