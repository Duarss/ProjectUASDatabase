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
    public partial class FormUtama1 : Form
    {
        public FormUtama1()
        {
            InitializeComponent();
        }
        public Konsumen konsumenLogin;
        public Pegawai pegawaiLogin;
        public FormRegisterKonsumen formRegisterKonsumen;
        public FormLogin formLoginKonsumen;
        public bool loginStatus = false;

        #region menu master
        private void buttonMaster_Click(object sender, EventArgs e)
        {
            ShowMenu(panelMaster);
        }

        private void buttonCinema_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterCinema());
            HiddenMenu();
        }

        private void buttonStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterStudio());
            HiddenMenu();
        }

        private void buttonJenisStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterJenisStudio());
            HiddenMenu();
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterGenre());
            HiddenMenu();
        }

        private void buttonAktors_Click(object sender, EventArgs e)
        {
            OpenForm (new FormMasterAktor());
            HiddenMenu();
        }

        private void buttonKonsumen_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterKonsumen());
            HiddenMenu();
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterPegawai());
            HiddenMenu();
        }

        private void buttonKelompok_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterKelompok());
            HiddenMenu();
        }
        #endregion

        #region menu system
        private void buttonSystem_Click(object sender, EventArgs e)
        {
            ShowMenu(panelSystem);
        }

        private void buttonPenjadwalanFilm_Click(object sender, EventArgs e)
        {
            HiddenMenu();
        }

        private void buttonPencatatanKedatangan_Click(object sender, EventArgs e)
        {
            HiddenMenu();
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
            HiddenMenu();
        }
        #endregion

        #region methods
        private Form formActive = null;
        private void OpenForm(Form form)
        {
            if (formActive != null)
            {
                formActive.Close();
            }
            formActive = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelForm.Controls.Add(form);
            panelForm.Tag = form;
            form.BringToFront();
            form.Show();
        }

        public void CustomDesign()
        {
            panelMaster.Visible = false;
            panelSystem.Visible = false;
        }

        private void HiddenMenu()
        {
            if (panelMaster.Visible == true)
            {
                panelMaster.Visible = false;
            }
            if (panelSystem.Visible == true)
            {
                panelSystem.Visible = false;
            }
        }

        private void ShowMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                HiddenMenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        private void AturMenu()
        {
            if (pegawaiLogin != null)
            {
                if (pegawaiLogin.Role == "ADMIN")
                {
                    buttonMaster.Visible = true;
                    panelMaster.Visible = true;
                    buttonSystem.Visible = true;
                    panelSystem.Visible = true;
                    buttonTransaction.Visible = true;
                }
                else if (pegawaiLogin.Role == "OPERATOR")
                {
                    buttonMaster.Enabled = false;
                    panelMaster.Enabled = false;
                    buttonSystem.Enabled = true;
                    panelSystem.Enabled = true;
                    buttonPencatatanKedatangan.Enabled = true;
                    buttonPenjadwalanFilm.Enabled = false;
                    buttonLaporan.Enabled = false;

                }
                else if (pegawaiLogin.Role == "KASIR")
                {
                    sistemToolStripMenuItem.Visible = true;
                    laporanToolStripMenuItem.Visible = true;
                }
            }
            if (konsumenLogin != null)
            {
                transaksiToolStripMenuItem.Visible = true;
            }
        }
        #endregion

        private void FormUtama1_Load(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
