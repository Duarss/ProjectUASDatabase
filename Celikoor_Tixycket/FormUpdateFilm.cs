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
    public partial class FormUpdateFilm : Form
    {
        public FormUpdateFilm()
        {
            InitializeComponent();
        }

        public string idUpdate;

        private void FormUpdateFilm_Load(object sender, EventArgs e)
        {
            List<Film> listDataFilm = Film.BacaData();
            textBoxJudul.Text = listDataFilm[int.Parse(idUpdate)].Judul;
            richTextBoxSinopsis.Text = listDataFilm[int.Parse(idUpdate)].Sinopsis;
            textBoxDurasi.Text = listDataFilm[int.Parse(idUpdate)].Durasi.ToString();
            comboBoxKelompokUsia.SelectedItem = listDataFilm[int.Parse(idUpdate)].KelompokUsia;
            textBoxBahasa.Text = listDataFilm[int.Parse(idUpdate)].Bahasa;
            
            if (listDataFilm[int.Parse(idUpdate)].Is_sub_indo == 0)
            {
                checkBoxSubIndo.Checked = false;
            }

            else
            {
                checkBoxSubIndo.Checked = true;
            }

            textBoxCoverImage.Text = listDataFilm[int.Parse(idUpdate)].CoverImage;
            textBoxDiskon.Text = listDataFilm[int.Parse(idUpdate)].Diskon.ToString();

            textBoxJudul.Select(0, textBoxJudul.TextLength);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Film film = new Film();
                film.Judul = textBoxJudul.Text;
                film.Sinopsis = richTextBoxSinopsis.Text;
                film.Durasi = int.Parse(textBoxDurasi.Text);
                film.KelompokUsia = (Kelompok)comboBoxKelompokUsia.SelectedItem;
                film.Bahasa = textBoxBahasa.Text;
                
                if (checkBoxSubIndo.Checked == false)
                {
                    film.Is_sub_indo = 0;
                }

                else
                {
                    film.Is_sub_indo = 1;
                }

                film.CoverImage = textBoxCoverImage.Text;
                film.Diskon = double.Parse(textBoxDiskon.Text);

                Film.UbahData(film);

                MessageBox.Show("Success to update data!");

                this.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show("Failed to update data! Error: " + x.Message);
            }
        }
    }
}
