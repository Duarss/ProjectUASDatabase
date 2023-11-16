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
    public partial class FormLoginKonsumen : Form
    {
        public FormLoginKonsumen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        FormUtama formMenu;
        FormRegisterKonsumen formRegisterKonsumen;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            formMenu = (FormUtama)this.Owner;
        }

        private void linkLabelCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formRegisterKonsumen = new FormRegisterKonsumen();
            formRegisterKonsumen.Owner = this;
            this.Visible = false;
            formRegisterKonsumen.ShowDialog();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            formMenu.Visible = true;
            formRegisterKonsumen.Close();
            this.Close();
        }

        private void labelLoginPanel_Click(object sender, EventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void textBoxUsernameLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPassword_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
