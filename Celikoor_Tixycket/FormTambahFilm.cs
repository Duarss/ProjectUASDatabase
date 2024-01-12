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
    public partial class FormTambahFilm : Form
    {
        public FormTambahFilm()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            try
            {
                Film film = new Film();
                film.Judul = textBoxJudul.Text;
                film.Sinopsis = textBoxSinopsis.Text;
                film.Durasi = int.Parse(textBoxDurasi.Text);
                film.KelompokUsia = (Kelompok)comboBoxKelompokUsia.SelectedItem;
                film.Bahasa = textBoxBahasa.Text;

                if (checkBoxSubIndo.Checked)
                {
                    film.Is_sub_indo = 'Y';
                }

                else
                {
                    film.Is_sub_indo = 'N';
                }

                film.CoverImage = textBoxCoverImage.Text;
                film.Diskon = double.Parse(textBoxDiskon.Text);

                Film.TambahData(film);

                MessageBox.Show("Success to add data!");

                this.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show("Failed to add data! Error: " + x.Message);
            }
        }

        private void FormTambahFilm_Load(object sender, EventArgs e)
        {
            List<Kelompok> listDataKelompokUsia = Kelompok.BacaData();
            comboBoxKelompokUsia.DataSource = listDataKelompokUsia;
            comboBoxKelompokUsia.DisplayMember = "Nama";

            textBoxJudul.Select();
        }
    }
}
