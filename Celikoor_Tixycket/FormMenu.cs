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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Owner = this;
            this.Visible = false;
            FormRegisterKonsumen formRegister = new FormRegisterKonsumen();
            formRegister.Owner = this;
            formRegister.Visible = false;
            formLogin.ShowDialog();
        }
    }
}
