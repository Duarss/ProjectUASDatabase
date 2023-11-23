﻿using Celikoor_LIB;
using Celikoor_Tixycket.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormLoginKonsumen : Form
    {
        public FormLoginKonsumen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        #region Global Variable
        List<Image> imageList = new List<Image> { Resources.poster1, Resources.poster3};
        FormUtama formUtama;
        int indexImg = 0; //untuk ganti poster
        bool loginStatus = false; //ganti nama button di formutama. Ada di formClosing
        string loginAs;
        #endregion
        #region Methods
        
        private void TextboxDefault()
        {
            if (textBoxUsernameLogin.Text == "")
            {
                textBoxUsernameLogin.Text = "Enter your username";
                textBoxUsernameLogin.ForeColor = Color.Silver;
            }
            if (textBoxPasswordLogin.Text == "")
            {
                textBoxPasswordLogin.Text = "Enter your password";
                textBoxPasswordLogin.UseSystemPasswordChar = false;
                textBoxPasswordLogin.ForeColor = Color.Silver;
            }
        }
        
        #endregion
        #region Events
        private void FormLoginKonsumen_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;
            panelImage.Select();//to prevent textbox from being selected when a form load
        }

        private void linkLabelCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.ActiveControl = null;
            this.Visible = false;
            formUtama.formRegisterKonsumen.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                this.ActiveControl = null;
                string id = textBoxUsernameLogin.Text;
                string pwd = textBoxPasswordLogin.Text;
                if(textBoxUsernameLogin.ForeColor == Color.Black && textBoxPasswordLogin.ForeColor == Color.Black){
                    //untuk menentukan siapa yang login
                    if(loginAs != null)
                    {
                        if (loginAs == "Konsumen")
                        {
                            formUtama.konsumenLogin = Konsumen.CekLogin(id, pwd);
                        }
                        else if (loginAs == "Pegawai")
                        {
                            formUtama.pegawaiLogin = Pegawai.CekLogin(id, pwd);
                        }
                        //cek apakah ada yang berhasil login
                        if (formUtama.konsumenLogin == null && formUtama.pegawaiLogin == null) //jik tidak berhasil
                        {
                            MessageBox.Show("Username atau password salah");
                        }
                        else //jika berhasil
                        {
                            formUtama.loginStatus = true;
                            formUtama.Visible = true;
                            loginStatus = true;
                            loginAs = null;
                            formUtama.formRegisterKonsumen.Close();
                            this.Close();
                        }
                    }
                    else //jika radiobutton tidak diisi
                    {
                        MessageBox.Show("Login as harus diisi");
                    }
                }
                else
                {
                    MessageBox.Show("Username atau password harus diisi");
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void textBoxPasswordLogin_Click(object sender, EventArgs e)
        {
            TextboxDefault();
            if (textBoxPasswordLogin.ForeColor == Color.Silver)
            {
                textBoxPasswordLogin.Text = "";
                textBoxPasswordLogin.UseSystemPasswordChar = true;
                textBoxPasswordLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxUsernameLogin_Click(object sender, EventArgs e)
        {
            TextboxDefault();
            if (textBoxUsernameLogin.ForeColor == Color.Silver)
            {
                textBoxUsernameLogin.Text = "";
                textBoxUsernameLogin.ForeColor = Color.Black;
            }
        }

        private void timerImageMoving_Tick(object sender, EventArgs e)
        {
            if (indexImg > 1) // diubah berdasarkan jumlah gambar
            {
                indexImg = 0;
            }
            if (indexImg == 0)
            {
                pageIndicator1.ForeColor = Color.DarkOrange;
                pageIndicator1.BackColor = Color.DarkOrange;
                pageIndicator4.ForeColor = Color.AntiqueWhite;
                pageIndicator4.BackColor = Color.AntiqueWhite;
            }
            else if(indexImg == 1)
            {
                pageIndicator2.ForeColor = Color.DarkOrange;
                pageIndicator2.BackColor = Color.DarkOrange;
                pageIndicator1.ForeColor = Color.AntiqueWhite;
                pageIndicator1.BackColor = Color.AntiqueWhite;
            }else if (indexImg == 2)
            {
                pageIndicator3.ForeColor = Color.DarkOrange;
                pageIndicator3.BackColor = Color.DarkOrange;
                pageIndicator2.ForeColor = Color.AntiqueWhite;
                pageIndicator2.BackColor = Color.AntiqueWhite;
            }else if (indexImg == 3)
            {
                pageIndicator4.ForeColor = Color.DarkOrange;
                pageIndicator4.BackColor = Color.DarkOrange;
                pageIndicator3.ForeColor = Color.AntiqueWhite;
                pageIndicator3.BackColor = Color.AntiqueWhite;
            }
            panelImage.BackgroundImage = imageList[indexImg];
            indexImg++;
        }

        private void FormLoginKonsumen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loginStatus)
            {
                formUtama.LoginConstraint(true, "Log out");
            }
            else
            {
                formUtama.LoginConstraint(true, "Log in");
            }
            formUtama.formRegisterKonsumen.Close();
        }
        private void FormLoginKonsumen_Click(object sender, EventArgs e)
        {
            TextboxDefault();
            this.ActiveControl = null;
        }

        private void panelImage_Click(object sender, EventArgs e)
        {
            TextboxDefault();
            this.ActiveControl = null;
        }
        private void checkBoxRememberMe_Click(object sender, EventArgs e)
        {
            TextboxDefault();
            this.ActiveControl = null;
        }
        #endregion

        private void radioButtonKonsumen_CheckedChanged(object sender, EventArgs e)
        {
            loginAs = "Konsumen";
        }

        private void radioButtonPegawai_CheckedChanged(object sender, EventArgs e)
        {
            loginAs = "Pegawai";
        }
    }
}
