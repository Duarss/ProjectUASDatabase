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

        private void sistemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void transaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
