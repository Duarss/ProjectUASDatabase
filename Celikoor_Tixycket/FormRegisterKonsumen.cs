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
        FormLoginKonsumen formLoginKonsumen;

        private void FormRegisterKonsumen_Load(object sender, EventArgs e)
        {
            formLoginKonsumen = (FormLoginKonsumen)this.Owner;
        }

        private void linkLabelAlreadyHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLoginKonsumen.Visible = true;
            this.Visible = false;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            formLoginKonsumen.Visible = true;
            this.Visible = false;
        }
    }
}
