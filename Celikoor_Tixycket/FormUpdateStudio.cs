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
    public partial class FormUpdateStudio : Form
    {
        public FormUpdateStudio()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string idUpdate;

        private void FormUpdateStudio_Load(object sender, EventArgs e)
        {
            List<Jenis_Studio> listDataJenisStudio = Jenis_Studio.BacaData();
            comboBoxJenisStudio.DataSource = listDataJenisStudio;
            comboBoxJenisStudio.DisplayMember = "Nama";

            List<Cinema> listDataCinema = Cinema.BacaData();
            comboBoxCinema.DataSource = listDataCinema;
            comboBoxCinema.DisplayMember = "Nama_cabang";

            List<Studio> listDataStudio = Studio.BacaData();
            textBoxNamaStudio.Text = listDataStudio[int.Parse(idUpdate)].Nama;
            numericUpDownKapasitas.Value = listDataStudio[int.Parse(idUpdate)].Kapasitas;
            comboBoxJenisStudio.SelectedItem = listDataStudio[int.Parse(idUpdate)].JenisStudio.Nama;
            comboBoxCinema.SelectedItem = listDataStudio[int.Parse(idUpdate)].Cinema.Nama_cabang;
            numericUpDownWeekday.Value = listDataStudio[int.Parse(idUpdate)].Harga_weekday;
            numericUpDownWeekend.Value = listDataStudio[int.Parse(idUpdate)].Harga_weekend;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Studio studio = new Studio();
                studio.Nama = textBoxNamaStudio.Text;
                studio.Kapasitas = (int)numericUpDownKapasitas.Value;
                studio.JenisStudio = (Jenis_Studio)comboBoxJenisStudio.SelectedItem;
                studio.Cinema = (Cinema)comboBoxCinema.SelectedItem;
                studio.Harga_weekday = (int)numericUpDownWeekday.Value;
                studio.Harga_weekend = (int)numericUpDownWeekend.Value;

                Studio.UbahData(studio);

                MessageBox.Show("Success to update data!");

                this.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to update data! Error: " + ex.Message);
            }
        }
    }
}
