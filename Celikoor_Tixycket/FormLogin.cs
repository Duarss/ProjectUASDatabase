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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        FormMenu formMenu;
        FormRegisterKonsumen formRegisterKonsumen;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;
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
    }
}
