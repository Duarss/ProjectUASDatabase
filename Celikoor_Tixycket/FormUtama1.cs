﻿using System;
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
        public FormLogin formLogin;
        public bool loginStatus = false;

        bool sidebarExpand = true;
        bool masterSection = false;
        bool systemSection = false;

        #region menu master
        private void buttonMaster_Click(object sender, EventArgs e)
        {
            timerMasterExpand.Start();
        }

        private void buttonCinema_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterCinema());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonCinema);
        }

        private void buttonStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterStudio());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonStudio);
        }

        private void buttonJenisStudio_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterJenisStudio());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonJenisStudio);
        }

        private void buttonGenre_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterGenre());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonGenre);
        }

        private void buttonAktors_Click(object sender, EventArgs e)
        {
            OpenForm (new FormMasterAktor());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonAktors);
        }

        private void buttonPegawai_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterPegawai());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonPegawai);
        }

        private void buttonKelompok_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMasterKelompok());
            DefaultTextBoxForeColor(panelMaster);
            ChangeForeColor(buttonKelompok);
        }
        private void buttonProfile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenForm(new FormProfile());
            }
            catch (Exception x) 
            {
                MessageBox.Show("Please log in first");
            };
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenForm(new FormProfile());
        }
        #endregion

        #region menu system
        private void buttonSystem_Click(object sender, EventArgs e)
        {
            timerSystemExpand.Start();
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
        private void DefaultTextBoxForeColor(Panel panelControl)
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
        public void OpenForm(Form form)
        {
            form.Owner = this;
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

        public void LoginConstraint(bool status, string text)
        {
            buttonLogInOut.Enabled = status;
            buttonLogInOut.Text = text;
            panelButtonMaster.Enabled = status;
            panelButtonSystem.Enabled = status;
            panelButtonTransaction.Enabled = status;
        }

        private void AturMenu()
        {
            if (pegawaiLogin != null)
            {
                panelHome.Visible = false;
                if (pegawaiLogin.Role == "ADMIN")
                {
                    panelButtonMaster.Visible = true;
                    panelButtonSystem.Visible = true;
                    panelButtonTransaction.Visible = true; // +-+
                    panelButtonTransaction.Enabled = false;
                }
                else if (pegawaiLogin.Role == "OPERATOR")
                {
                    panelButtonSystem.Visible = true;
                    buttonPenjadwalanFilm.Visible = false;
                    buttonLaporan.Visible = false;

                }
                else if (pegawaiLogin.Role == "KASIR")
                {
                    panelButtonSystem.Visible = true;
                    buttonPencatatanKedatangan.Visible = false;
                    buttonPenjadwalanFilm.Visible = false;
                }
            }
            else if (konsumenLogin != null)
            {
                panelButtonMaster.Enabled = false;
                panelMaster.Enabled = false;
                panelButtonSystem.Enabled = false;
                panelSystem.Enabled = false;
                panelButtonTransaction.Enabled = true;
            }
        }
        #endregion

        private void FormUtama1_Load(object sender, EventArgs e)
        {
            panelButtonMaster.Visible = false;
            panelMaster.Height = 0;
            panelButtonSystem.Visible = false;
            panelSystem.Height = 0;
            panelButtonTransaction.Visible = false;
            OpenForm(new FormMain());
        }

        public void LoginSetUp(object sender, EventArgs e)
        {
            if (loginStatus == false)
            {
                Form form = Application.OpenForms["FormLogin"];
                LoginConstraint(false, "In Progress");

                if (form == null)
                {
                    formLogin= new FormLogin();
                    formLogin.Owner = this;

                    OpenForm(formLogin);
                }

                else
                {
                    form.Show();
                    form.BringToFront();
                }
            }

            else
            {
                loginStatus = false;
                buttonLogInOut.Text = "Log in";
                konsumenLogin = null;
                pegawaiLogin = null;
                panelForm.Controls.Clear();
                FormUtama1_Load(sender, e);
                buttonProfile.Text = "                 Not logged in";
                MessageBox.Show("Anda Berhasil Log Out!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AturMenu();
            }
        }

        public void SetUIAfterLogin()
        {
            if (konsumenLogin != null)
            {
                buttonProfile.Text = "                 " + konsumenLogin.Nama;
            }

            else if (pegawaiLogin != null)
            {
                buttonProfile.Text = "                 " + pegawaiLogin.Nama;
            }

            AturMenu();
        }

        private void buttonTransaction_Click(object sender, EventArgs e)
        {

        }

        private void panelSystem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timerSideMenuExpand_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                panelMenu.Width -= 8;
                if(panelMenu.Width <= 81)
                {
                    timerSideMenuExpand.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                panelMenu.Width += 8;
                if (panelMenu.Width >= panelMenu.MaximumSize.Width)
                {
                    timerSideMenuExpand.Stop();
                    sidebarExpand = true;
                }
            }
        }

        private void timerMasterExpand_Tick(object sender, EventArgs e)
        {
            if (masterSection)
            {
                panelMaster.Height -= 15;
                if (panelMaster.Height<= 0)
                {
                    timerMasterExpand.Stop();
                    masterSection = false;
                }
            }
            else
            {
                panelMaster.Height += 15;
                if (panelMaster.Height >= panelMaster.MaximumSize.Height)
                {
                    timerMasterExpand.Stop();
                    masterSection = true;
                }
            }
        }
        private void timerSystemExpand_Tick(object sender, EventArgs e)
        {
            if (systemSection)
            {
                panelSystem.Height -= 15;
                if (panelSystem.Height <= 0)
                {
                    timerSystemExpand.Stop();
                    systemSection = false;
                }
            }
            else
            {
                panelSystem.Height += 15;
                if (panelSystem.Height >= panelSystem.MaximumSize.Height)
                {
                    timerSystemExpand.Stop();
                    systemSection = true;
                }
            }
        }
        private void buttonSideMenu_Click(object sender, EventArgs e)
        {
            timerSideMenuExpand.Start();
        }

        private void pictureBoxMaster_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxStudio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxGenre_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxActors_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxEmployee_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            OpenForm(new FormMain());
        }
    }
}
