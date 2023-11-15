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

        private void linkLabelAlreadyHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            formLogin.ShowDialog();

            this.Close();
        }
    }
}
