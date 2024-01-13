﻿using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        public Konsumen konsumenLogin;
        public Pegawai pegawaiLogin;

        private void FormProfile_Load(object sender, EventArgs e)
        {
            if (konsumenLogin is Konsumen)
            {
                List<Konsumen> listDataKonsumen = Konsumen.BacaData();
                labelNamaUser.Text = listDataKonsumen[konsumenLogin.Id].Username;
                customTextBoxNama.Texts = listDataKonsumen[konsumenLogin.Id].Nama;
                customTextBoxUsername.Texts = listDataKonsumen[konsumenLogin.Id].Username;
                customTextBoxPassword.Texts = listDataKonsumen[konsumenLogin.Id].Password;
                customTextBoxEmail.Texts = listDataKonsumen[konsumenLogin.Id].Email;
                customTextBoxNoHp.Texts = listDataKonsumen[konsumenLogin.Id].NoHp;
                customTextBoxTglLahir.Texts = listDataKonsumen[konsumenLogin.Id].TglLahir.ToString("MM/dd/yyyy");
            }
        }

        private void customTextboxName_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxNama.UnderlinedStyle = true;
        }

        private void customTextboxEmail_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxEmail.UnderlinedStyle = true;
        }

        private void customTextboxUsername_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxUsername.UnderlinedStyle = true;
        }

        private void customTextboxPhoneNumber_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxNoHp.UnderlinedStyle = true;
        }

        private void customTextboxPassword_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxPassword.UnderlinedStyle = true;
        }

        private void customTextboxBirthDate_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextBoxTglLahir.UnderlinedStyle = true;
        }
        private void DisableUnderlineStyle()
        {
            foreach (CustomTextbox customTextbox in panelFotoProfile.Controls.OfType<CustomTextbox>())
            {
                customTextbox.UnderlinedStyle = false;
            }
        }

        private void FormProfile_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }

        private void panelFotoProfile_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }

        private void buttonEditProfilePicture_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonUpdateChanges_Click(object sender, EventArgs e)
        {
            try
            {
                Konsumen konsumen = new Konsumen();
                konsumen.Nama = customTextBoxNama.Texts;
                konsumen.Username = customTextBoxUsername.Texts;
                konsumen.Password = customTextBoxPassword.Texts;
                konsumen.Email = customTextBoxEmail.Texts;
                konsumen.NoHp = customTextBoxNoHp.Texts;
                konsumen.TglLahir = DateTime.Parse(customTextBoxTglLahir.Texts);

                Konsumen.UbahData(konsumen);

                MessageBox.Show("Success to update your profile changes!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Failed to update your profile changes! Error: " + ex.Message);
            }
        }
    }
}
