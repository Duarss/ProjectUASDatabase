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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void labelCreateAnAccount_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabelCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegisterKonsumen formRegisterKonsumen = new FormRegisterKonsumen();
            formRegisterKonsumen.Owner = this;
            formRegisterKonsumen.ShowDialog();

            this.Close();
        }
    }
}
