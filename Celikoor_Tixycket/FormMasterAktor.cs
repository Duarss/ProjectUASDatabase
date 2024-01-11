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
    public partial class FormMasterAktor : Form
    {
        public FormMasterAktor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahAktor formTambahAktor = new FormTambahAktor();
            formTambahAktor.Owner = this;
            formTambahAktor.ShowDialog();
        }

        private void FormMasterAktor_Load(object sender, EventArgs e)
        {
            List<Aktor> listDataAktor = Aktor.BacaData();
            dgvData.DataSource = listDataAktor;

            if (dgvData.ColumnCount == 5)
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.Text = "Delete"; //judul button
                btnHapus.HeaderText = "Action"; //judul kolom
                btnHapus.UseColumnTextForButtonValue = true; //agar tulisan muncul di button
                btnHapus.Name = "buttonHapusGrid"; //nama objek button
                dgvData.Columns.Add(btnHapus); //tambahkan button ke grid
            }

            foreach (DataGridViewColumn column in dgvData.Columns)
            {
                if (column.Name != "Id" && column.Name != "buttonHapusGrid")
                {
                    column.Width = 228;
                }
            }
        }

        private void buttonCari_Click(object sender, EventArgs e)
        {
            string filter;

            if (comboBoxCari.SelectedIndex == 0)
            {
                filter = "Nama";
            }

            else if (comboBoxCari.SelectedIndex == 1)
            {
                filter = "Gender";
            }

            else
            {
                filter = "Negara_Asal";
            }

            string nilai = textBoxCari.Text;

            List<Aktor> listDataAktor = Aktor.BacaData(filter, nilai);
            dgvData.DataSource = listDataAktor;
        }
    }
}
