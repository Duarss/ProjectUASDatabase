﻿using System;
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
    public partial class FormRegisterKonsumen : Form
    {
        public FormRegisterKonsumen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        #region Global Variable
        FormUtama formUtama;
        #endregion
        #region Events
        private void FormRegisterKonsumen_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.Owner;
        }

        private void linkLabelAlreadyHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formUtama.formLoginKonsumen.Visible = true;
            this.Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void FormRegisterKonsumen_FormClosing(object sender, FormClosingEventArgs e)
        {
            formUtama.formLoginKonsumen.Close();
            formUtama.LoginConstraint(true, "Log in");
        }
        #endregion

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            formUtama.formLoginKonsumen.Visible = true;
            this.Visible = false;
        }

        private void labelPINPassword_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
