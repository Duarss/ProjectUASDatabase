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
                c.Nama_cabang = textBoxNamaCabang.Text;
                c.Alamat = textBoxAlamatCinema.Text;
                c.TglDibuka = dateTimePickerTglDibukaCInema.Value;
                c.Kota = textBoxKotaCinema.Text;

                Cinema.TambahData(c);
                MessageBox.Show("Add data success!");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Add data failed. Error: " + x.Message);
            }
        }

        private void FormTambahCinema_Load(object sender, EventArgs e)
        {
            textBoxNamaCabang.Focus();
        }

        private void textBoxNamaCabang_Click(object sender, EventArgs e)
        {
            textBoxNamaCabang.Select(0, textBoxNamaCabang.Text.Length);
        }

        private void textBoxNamaCabang_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
