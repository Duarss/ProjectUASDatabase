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
    public partial class FormUpdateJenisMenu : Form
    {
        public FormUpdateJenisMenu()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            try
            {
                Jenis_Menu jM = new Jenis_Menu();
                jM.Id = int.Parse(idUpdate);
                jM.Nama = textBoxJenisMenu.Text;
                jM.Deskripsi = richTextBoxDeskripsi.Text;

                Jenis_Menu.UbahData(jM);

                MessageBox.Show("Success to add data!");

                this.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show("Failed to update data! Error: " + x.Message);
            }
        }

        public string idUpdate;

        private void FormUpdateJenisMenu_Load(object sender, EventArgs e)
        {
            List<Jenis_Menu> listJenisMenu = Jenis_Menu.BacaData("id", idUpdate);
            textBoxJenisMenu.Text = listJenisMenu[0].Nama;
            richTextBoxDeskripsi.Text = listJenisMenu[0].Deskripsi;
        }
    }
}
