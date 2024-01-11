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
    public partial class FormMasterStudio : Form
    {
        public FormMasterStudio()
        {
            InitializeComponent();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahStudio frmTambahStudio = new FormTambahStudio();
            frmTambahStudio.Owner = this;
            frmTambahStudio.ShowDialog();
            FormMasterStudio_Load(this, e);
        }

        private void FormMasterStudio_Load(object sender, EventArgs e)
        {
            List<Studio> listStudio = Studio.BacaData();
            dgvData.DataSource = listStudio;

            if (dgvData.ColumnCount == 7)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Text = "Delete"; //judul button
                btnHapus.HeaderText = "Action"; //judul kolom
                btnHapus.UseColumnTextForButtonValue = true; //agar tulisan muncul di button
                btnHapus.Name = "buttonHapusGrid"; //nama objek button
                dgvData.Columns.Add(btnHapus); //tambahkan button ke grid

                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Update"; //judul button
                btnUpdate.HeaderText = "Action"; //judul kolom
                btnUpdate.UseColumnTextForButtonValue = true; //agar tulisan muncul di button
                btnUpdate.Name = "buttonUpdateGrid"; //nama objek button
                dgvData.Columns.Add(btnUpdate); //tambahkan button ke grid
            }
            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                if (column.Name != "Id" && column.Name != "buttonHapusGrid")
                {
                    column.Width = 130;
                }
            }
        }

        private void textboxCari_TextChanged(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception x)
            {
                // empty
            }
        }

        private void buttonKeluar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            try
            {
                string value = textboxCari.Text;
                string filter = "";
                if(comboboxCari.Text == "Nama")
                {
                    filter = "nama";
                }else if (comboboxCari.Text == "Kapasitas")
                {
                    filter = "kapasitas";
                }else if (comboboxCari.Text == "Jenis Studio")
                {
                    filter = "jenis_studios_id";
                }
                List<Studio> listStudio = Studio.BacaData(filter, value);
                dgvData.DataSource=listStudio;
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
