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
        FormLoginKonsumen formLogin;

        private void FormRegisterKonsumen_Load(object sender, EventArgs e)
        {
            formLogin = (FormLoginKonsumen)this.Owner;
        }

        private void linkLabelAlreadyHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLogin.Visible = true;
            this.Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            formLogin.Visible = true;
            this.Visible = false;
        }
    }
}
