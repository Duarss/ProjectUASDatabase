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

        FormUtama formUtama;
        FormRegisterKonsumen formRegisterKonsumen;
        FormLoginAs formLoginAs;

        private void FormLoginKonsumen_Load(object sender, EventArgs e)
        {
            formLoginAs = (FormLoginAs)this.Owner;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            formUtama.Visible = true;
            formRegisterKonsumen.Close();
            this.Close();
        }

        private void linkLabelCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formRegisterKonsumen = new FormRegisterKonsumen();
            formRegisterKonsumen.Owner = this;
            this.Visible = false;
            formRegisterKonsumen.ShowDialog();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            string username = textBoxUsernameLogin.Text;
            string password = textBoxPasswordLogin.Text;


        }
    }
}
