using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormPemesananTiket : Form
    {
        public FormPemesananTiket()
        {
            InitializeComponent();
        }
        FormUtama formUtama;
        Film selectedFilm;
        private void FormPemesananTiket_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;
            List<Film> listFilm = Film.BacaData();
            comboBoxJudulFilm.DataSource = listFilm;
            comboBoxJudulFilm.DisplayMember = "Judul";
            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "Nama_cabang";
            selectedFilm = formUtama.film;
            if (selectedFilm != null)
            {
                string dir = Environment.CurrentDirectory;
                dir = dir.Substring(0, dir.Length - 9);
                dir += $"Resources\\{selectedFilm.CoverImage}.jpg";

                pictureBoxCoverImage.BackgroundImage = Image.FromFile(dir);
                labelDurasi.Text = selectedFilm.Durasi.ToString();
                richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
                labelAktorUtama.Text = "Aktor Utama: ";
                labelGenre.Text = "Genre";
                labelKelompok.Text = "Kelompok: " + selectedFilm.KelompokUsia;

                comboBoxJudulFilm.Text = selectedFilm.Judul;
            }
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelJenisStudio.Text = ((Studio)comboBoxStudio.SelectedItem).JenisStudio.ToString();
            DateTime selectedDate = dateTimePicker.Value;
            if (selectedDate.DayOfWeek >= DayOfWeek.Monday && selectedDate.DayOfWeek <= DayOfWeek.Friday)
            {
                labelNominalHarga.Text = ((Studio)comboBoxStudio.SelectedItem).Harga_weekday.ToString();
            }
            else
            {
                labelNominalHarga.Text = ((Studio)comboBoxStudio.SelectedItem).Harga_weekend.ToString();
            }
            
        }

        private void comboBoxJudulFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFilm = (Film)comboBoxJudulFilm.SelectedItem;
            string dir = Environment.CurrentDirectory;
            dir = dir.Substring(0, dir.Length - 9);
            dir += $"Resources\\{selectedFilm.CoverImage}.jpg";

            pictureBoxCoverImage.BackgroundImage = Image.FromFile(dir);
            labelDurasi.Text = selectedFilm.Durasi.ToString();
            richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
            labelAktorUtama.Text = "Aktor Utama: ";
            labelGenre.Text = "Genre";
            labelKelompok.Text = "Kelompok: " + selectedFilm.KelompokUsia;
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Studio> listStudio = Studio.BacaData();
            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "Nama";
        }
    }
}
