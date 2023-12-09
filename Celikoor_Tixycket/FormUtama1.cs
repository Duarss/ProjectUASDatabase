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
                    formLogin= new FormLogin();
                    formLogin.Owner = this;

                    formRegisterKonsumen = new FormRegisterKonsumen();
                    formRegisterKonsumen.Owner = this;

                    formLogin.ShowDialog();
                    formLogin.StartPosition = FormStartPosition.CenterScreen;
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
    }
}