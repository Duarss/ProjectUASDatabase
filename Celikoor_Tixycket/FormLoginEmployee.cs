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
    public partial class FormLoginEmployee : Form
    {
        public FormLoginEmployee()
        {
            InitializeComponent();
        }
        FormUtama formUtama;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            formUtama.Visible = true;
            //formRegisterKonsumen.Close();
            //test
            formUtama.formRegisterKonsumen.Close();
            formUtama.formLoginKonsumen.Close();
            //
            this.Close();
        }

        private void FormLoginEmployee_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
        }

        private void linkLabelCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
