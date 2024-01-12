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
    public partial class FormTambahStudio : Form
    {
        public FormTambahStudio()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            try
            {
                Studio s = new Studio();
                s.Nama = textBoxNamaStudio.Text;
                s.Kapasitas = (int)numericUpDownKapasitas.Value;
                s.JenisStudio = (Jenis_Studio)comboBoxStudio.SelectedItem;
                s.Cinema = (Cinema)comboBoxCinema.SelectedItem;
                s.Harga_weekday = (int)numericUpDownWeekday.Value;
                s.Harga_weekend = (int)numericUpDownWeekend.Value;

                Studio.TambahData(s);
                MessageBox.Show("Success to add data!");
                this.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show("Failed to add data! Error: " + x.Message);
            }
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTambahStudio_Load(object sender, EventArgs e)
        {
            textBoxNamaStudio.Focus();
            List<Jenis_Studio> listJenisStudio = Jenis_Studio.BacaData();
            comboBoxStudio.DataSource = listJenisStudio;
            comboBoxStudio.DisplayMember = "Nama";

            List<Cinema> listCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listCinema;
            comboBoxCinema.DisplayMember = "Nama_cabang";
        }
    }
}
