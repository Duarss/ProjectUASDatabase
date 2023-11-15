using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace database_project
{
    public partial class FormRegisterKonsumen : Form
    {
        public FormRegisterKonsumen()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        FormLogin formLogin;

        private void FormRegisterKonsumen_Load(object sender, EventArgs e)
        {
            formLogin = (FormLogin)this.Owner;
        }

        private void linkLabelAlreadyHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            this.Visible = false;
            formLogin.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            formLogin.Visible = true;
            this.Close();
        }
    }
}
