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
    public partial class FormRegisterKonsumen : Form
    {
        public FormRegisterKonsumen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        #region Global Variable
        FormUtama1 formUtama;
        #endregion
        #region Events
        private void FormRegisterKonsumen_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama1)this.Owner;
        }

        private void linkLabelAlreadyHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formUtama.OpenForm(new FormLogin());
        }

        public void FormRegisterKonsumen_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
        #endregion

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            this.SendToBack();
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
