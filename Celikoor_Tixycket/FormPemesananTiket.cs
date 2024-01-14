using Celikoor_LIB;
using System;
using System.Collections;
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
        Studio selectedStudio;
        private void LayoutTempatDuduk()
        {
            string[] seatType = { "A", "B", "C" };
            int capacity = selectedStudio.Kapasitas;
            
            for (int i = 0; i < 3; i++)
            {
                string sectionSeat = seatType[i];
                int seatNumber = 1;
                int pointX = 33 + (i * 247);
                int pointY = 129;
                for (int j = 0; j < capacity/3; j++)
                {
                    CheckBox newCheckBox = new CheckBox();
                    newCheckBox.Location = new System.Drawing.Point(pointX, pointY);
                    newCheckBox.Size = new System.Drawing.Size(45, 22);
                    newCheckBox.Text = seatNumber.ToString();
                    newCheckBox.Name = sectionSeat + seatNumber.ToString();
                    seatNumber++;
                    pointX += 46;

                    panelTempatDuduk.Controls.Add(newCheckBox);
                    if ((j+1) % 4 == 0 && j != 0)
                    {
                        pointX = 33 + (i * 247);
                        pointY += 38;
                    }
                    
                }
            }
        }
        private void DeleteAllSeat()
        {
            foreach (Control control in new ArrayList(panelTempatDuduk.Controls))
            {
                if (control is CheckBox checkBox)
                {
                    checkBox.Dispose();
                }
            }
        }
        private void FormPemesananTiket_Load(object sender, EventArgs e)
        {
            CheckBox newCheckBox = new CheckBox();
            panelTempatDuduk.Controls.Add(newCheckBox);
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
                List<Genre_film> listGenreFilm = Film.BacaDataDetailGenreFilm("films_id", selectedFilm.Id.ToString());
                List<Aktor_film> listAktorFilm = Film.BacaDataDetailAktorFilm("films_id", selectedFilm.Id.ToString());

                string dir = Environment.CurrentDirectory;
                dir = dir.Substring(0, dir.Length - 9);
                dir += $"Resources\\{selectedFilm.CoverImage}.jpg";

                pictureBoxCoverImage.BackgroundImage = Image.FromFile(dir);
                labelDurasi.Text = "Durasi: " + selectedFilm.Durasi.ToString() + " menit";
                richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
                labelAktorUtama.Text = "Aktor Utama: ";
                for (int i = 0; i < listAktorFilm.Count; i++)
                {
                    labelAktorUtama.Text += listAktorFilm[i].Aktor.Nama;
                    if (i == listAktorFilm.Count - 1)
                    {
                        break;
                    }
                    if (i + 1 < 2)
                    {
                        labelAktorUtama.Text += ", ";
                    }
                    else
                    {
                        labelAktorUtama.Text += ",...";
                        break;
                    }
                }
                labelGenre.Text = "Genre: ";
                for (int i = 0; i < listGenreFilm.Count; i++)
                {
                    labelGenre.Text += listGenreFilm[i].Genre.Nama;
                    if (i + 1 < listGenreFilm.Count)
                    {
                        labelGenre.Text += ", ";
                    }
                }
                labelKelompok.Text = "Kelompok: " + selectedFilm.KelompokUsia;

                comboBoxJudulFilm.Text = selectedFilm.Judul;
            }
        }

        private void comboBoxStudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudio = (Studio)comboBoxStudio.SelectedItem;
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
            labelJumlahKursi.Text = ((Studio)comboBoxStudio.SelectedItem).Kapasitas.ToString() + " kursi";
            DeleteAllSeat();
            LayoutTempatDuduk();
        }

        private void comboBoxJudulFilm_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFilm = (Film)comboBoxJudulFilm.SelectedItem;
            List<Genre_film> listGenreFilm = Film.BacaDataDetailGenreFilm("films_id", selectedFilm.Id.ToString());
            List<Aktor_film> listAktorFilm = Film.BacaDataDetailAktorFilm("films_id", selectedFilm.Id.ToString());
            string dir = Environment.CurrentDirectory;
            dir = dir.Substring(0, dir.Length - 9);
            dir += $"Resources\\{selectedFilm.CoverImage}.jpg";

            pictureBoxCoverImage.BackgroundImage = Image.FromFile(dir);
            labelDurasi.Text = "Durasi: " + selectedFilm.Durasi.ToString() + " menit";
            richTextBoxSinopsis.Text = selectedFilm.Sinopsis;
            labelAktorUtama.Text = "Aktor Utama: ";
            for (int i = 0; i < listAktorFilm.Count; i++)
            {
                labelAktorUtama.Text += listAktorFilm[i].Aktor.Nama;
                if (i == listAktorFilm.Count - 1)
                {
                    break;
                }
                if (i + 1 < 2)
                {
                    labelAktorUtama.Text += ", ";
                }
                else
                {
                    labelAktorUtama.Text += ",...";
                    break;
                }
            }
            labelGenre.Text = "Genre: ";
            for (int i = 0; i < listGenreFilm.Count; i++)
            {
                labelGenre.Text += listGenreFilm[i].Genre.Nama;
                if (i + 1 < listGenreFilm.Count)
                {
                    labelGenre.Text += ", ";
                }
            }
            labelKelompok.Text = "Kelompok: " + selectedFilm.KelompokUsia;
        }

        private void comboBoxCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Studio> listStudio = Studio.BacaData("cinemas_id", ((Cinema)comboBoxCinema.SelectedItem).Id.ToString());
            comboBoxStudio.DataSource = listStudio;
            comboBoxStudio.DisplayMember = "Nama";
            comboBoxStudio.Enabled = true;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
