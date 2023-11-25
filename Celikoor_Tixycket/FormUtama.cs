using Celikoor_Tixycket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Tixycket
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        #region Global Variable
        public Konsumen konsumenLogin;
        public Pegawai pegawaiLogin;
        public FormRegisterKonsumen formRegisterKonsumen;
        public FormLoginKonsumen formLoginKonsumen;
        public bool loginStatus = false;
        #endregion
        #region Methods
        public void LoginConstraint(bool status, string text)
        {
            buttonLogInOut.Enabled = status;
            buttonLogInOut.Text = text;
            masterToolStripMenuItem.Enabled = status;
            sistemToolStripMenuItem.Enabled = status;
            transaksiToolStripMenuItem.Enabled = status;
        }
        private void AturMenuAfterLogout()
        {
            masterToolStripMenuItem.Visible = false;
            transaksiToolStripMenuItem.Visible = false;
            sistemToolStripMenuItem.Visible = false;
            penjadwalanFilmToolStripMenuItem.Visible = false;
            laporanToolStripMenuItem.Visible = false;
            pencatatanKedatanganToolStripMenuItem.Visible = false;
        }
        private void AturMenuAfterLogin()
        {
            if(pegawaiLogin != null)
            {
                if (pegawaiLogin.Role == "ADMIN")
                {
                    masterToolStripMenuItem.Visible = true;
                    transaksiToolStripMenuItem.Visible = true;
                    sistemToolStripMenuItem.Visible = true;
                }
                else if (pegawaiLogin.Role == "OPERATOR")
                {
                    sistemToolStripMenuItem.Visible = true;
                    pencatatanKedatanganToolStripMenuItem.Visible = true;
                }
                else if (pegawaiLogin.Role == "KASIR")
                {
                    sistemToolStripMenuItem.Visible= true;
                    laporanToolStripMenuItem.Visible = true;
                }
            }
            if(konsumenLogin != null)
            {
                transaksiToolStripMenuItem.Visible = true;
            }
        }
        #endregion
        #region Events
        private void FormUtama_Load(object sender, EventArgs e)
        {
            AturMenuAfterLogout();
        }

        private void buttonLogInOut_Click(object sender, EventArgs e)
        {
            if (loginStatus == false)
            {
                Form form = Application.OpenForms["FormLoginKonsumen"];
                LoginConstraint(false, "In Progress");

                if (form == null)
                {
                    formLoginKonsumen = new FormLoginKonsumen();
                    formLoginKonsumen.Owner = this;

                    formRegisterKonsumen = new FormRegisterKonsumen();
                    formRegisterKonsumen.Owner = this;

                    formLoginKonsumen.ShowDialog();
                    formLoginKonsumen.StartPosition = FormStartPosition.CenterScreen;
                }

                else
                {
                    form.Show();
                    form.BringToFront();
                }

                if (konsumenLogin != null)
                {
                    labelLogInSebagai.Text = "Logged In as : " + konsumenLogin.Nama;

                }

                else if (pegawaiLogin != null)
                {
                    labelLogInSebagai.Text = "Logged In as : " + pegawaiLogin.Nama;
                }

                AturMenuAfterLogin();
            }
            else
            {
                loginStatus = false;
                buttonLogInOut.Text = "Log in";
                konsumenLogin = null;
                pegawaiLogin = null;
                MessageBox.Show("Anda Berhasil Log Out!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AturMenuAfterLogout();
            }

        }
        #endregion
        private void cinemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterCinema frmCinema = new FormMasterCinema();
            frmCinema.MdiParent = this;
            frmCinema.Show();
        }

        private void studioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterStudio frmStudio = new FormMasterStudio();
            frmStudio.MdiParent = this;
            frmStudio.Show();
        }

        private void jenisStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterJenisStudio frmJenisStudio = new FormMasterJenisStudio();
            frmJenisStudio.MdiParent = this;
            frmJenisStudio.Show();
        }

        private void genreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterGenre frmGenre = new FormMasterGenre();
            frmGenre.MdiParent = this;
            frmGenre.Show();
        }

        private void aktorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterAktor frmAktor = new FormMasterAktor();
            frmAktor.MdiParent = this;
            frmAktor.Show();
        }

        private void konsumenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterKonsumen frmKonsumen = new FormMasterKonsumen();
            frmKonsumen.MdiParent = this;
            frmKonsumen.Show();
        }

        private void pegawaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterPegawai frmPegawai = new FormMasterPegawai();
            frmPegawai.MdiParent = this;
            frmPegawai.Show();
        }

        private void kelompokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMasterKelompok frmKelompok = new FormMasterKelompok();
            frmKelompok.MdiParent = this;
            frmKelompok.Show();
        }

        private void penjadwalanFilmToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pencatatanKedatanganToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void laporanToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
