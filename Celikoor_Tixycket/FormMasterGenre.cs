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
    public partial class FormMasterGenre : Form
    {
        public FormMasterGenre()
        {
            InitializeComponent();
        }

        private void FormMasterGenre_Load(object sender, EventArgs e)
        {
            List<Genre> listDataGenre = Genre.BacaData();
            dgvData.DataSource = listDataGenre;

            if (dgvData.ColumnCount == 3)
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

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahGenre formTambahGenre = new FormTambahGenre();
            formTambahGenre.Owner = this;
            formTambahGenre.ShowDialog();
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
