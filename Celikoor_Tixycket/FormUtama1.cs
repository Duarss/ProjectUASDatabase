using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Tixycket
{
    public partial class FormUtama1 : Form
    {
        public FormUtama1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
            DefaultForeColor(panelMaster);
            ChangeForeColor(buttonCinema);
        }

        private void buttonStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterStudio());
            DefaultForeColor(panelMaster);
            ChangeForeColor(buttonStudio);
        }

        private void buttonJenisStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterJenisStudio());
            DefaultForeColor(panelMaster);
            ChangeForeColor(buttonJenisStudio);
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterGenre());
            DefaultForeColor(panelMaster);
            ChangeForeColor(buttonGenre);
        }

        private void buttonAktors_Click(object sender, EventArgs e)
        {
            OpenForm (new FormMasterAktor());
            DefaultForeColor(panelMaster);
            ChangeForeColor(buttonAktors);
        }

        private void buttonKonsumen_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterKonsumen());
            DefaultForeColor(panelMaster);
            ChangeForeColor(buttonKonsumen);
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterPegawai());
            DefaultForeColor(panelMaster);
            ChangeForeColor(buttonPegawai);
        }

        private void buttonKelompok_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterKelompok());
            DefaultForeColor(panelMaster);
            ChangeForeColor(buttonKelompok);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormProfile());
        }
        #endregion

        #region menu system
        private void buttonSystem_Click(object sender, EventArgs e)
        {
            ShowMenu(panelSystem);
        }

        private void buttonPenjadwalanFilm_Click(object sender, EventArgs e)
        {
        }

        private void buttonPencatatanKedatangan_Click(object sender, EventArgs e)
        {
        }

        private void buttonLaporan_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #region methods
        private Form formActive = null;
        private void DefaultForeColor(Panel panelControl)
        {
            foreach(Button button in panelMaster.Controls.OfType<Button>())
            {
                button.ForeColor = Color.White;
            }
        }
        private void ChangeForeColor(Button buttonControl)
        {
            buttonControl.ForeColor = Color.DarkSlateGray;
        }
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

        private void HiddenMenu(Panel menu)
        {
            if (menu.Visible == true)
            {
                menu.Visible = false;
            }
            if (menu.Visible == true)
            {
                menu.Visible = false;
            }
        }

        private void ShowMenu(Panel menu)
        {
            if (menu.Visible == false)
            {
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        public void LoginConstraint(bool status, string text)
        {
            buttonLogInOut.Enabled = status;
            buttonLogInOut.Text = text;
            buttonMaster.Enabled = status;
            buttonSystem.Enabled = status;
            buttonTransaction.Enabled = status;
        }

        private void AturMenu()
        {
            if (pegawaiLogin != null)
            {
                if (pegawaiLogin.Role == "ADMIN")
                {
                    buttonMaster.Visible = true;
                    buttonSystem.Visible = true;
                    buttonTransaction.Visible = true; // +-+
                    buttonTransaction.Enabled = false;
                }
                else if (pegawaiLogin.Role == "OPERATOR")
                {
                    buttonSystem.Visible = true;
                    buttonPenjadwalanFilm.Visible = false;
                    buttonLaporan.Visible = false;

                }
                else if (pegawaiLogin.Role == "KASIR")
                {
                    buttonSystem.Visible = true;
                    buttonPencatatanKedatangan.Visible = false;
                    buttonPenjadwalanFilm.Visible = false;
                }
            }
            else if (konsumenLogin != null)
            {
                buttonMaster.Enabled = false;
                panelMaster.Enabled = false;
                buttonSystem.Enabled = false;
                panelSystem.Enabled = false;
                buttonTransaction.Enabled = true;
            }
        }
        #endregion

        private void FormUtama1_Load(object sender, EventArgs e)
        {/*
            panelMaster.Enabled = false;
            buttonCinema.Visible = false;
            buttonStudio.Visible = false;
            buttonJenisStudio.Visible = false;
            buttonGenre.Visible = false;
            buttonAktors.Visible = false;
            buttonKonsumen.Visible = false;
            buttonPegawai.Visible = false;
            buttonKelompok.Visible = false;
            */
            buttonMaster.Visible = false;
            panelMaster.Visible = false;
            buttonSystem.Visible = false;
            panelSystem.Visible = false;
            buttonTransaction.Visible = false;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLogInOut_Click(object sender, EventArgs e)
        {
            if (loginStatus == false)
            {
                Form form = Application.OpenForms["FormLogin"];
                LoginConstraint(false, "In Progress");

                if (form == null)
                {
                    formLoginKonsumen= new FormLogin();
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
                    labelLoginSebagai.Text = "Logged In as : " + konsumenLogin.Nama;
                }

                else if (pegawaiLogin != null)
                {
                    labelLoginSebagai.Text = "Logged In as : " + pegawaiLogin.Nama;
                }

                AturMenu();
            }

            else
            {
                loginStatus = false;
                buttonLogInOut.Text = "Log in";
                konsumenLogin = null;
                pegawaiLogin = null;
                FormUtama1_Load(sender, e);
                labelLoginSebagai.Text = "Logged In as : ";
                MessageBox.Show("Anda Berhasil Log Out!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AturMenu();
            }
        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {

        }

        private void panelSystem_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
