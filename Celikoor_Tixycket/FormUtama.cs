using Celikoor_Tixycket;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Celikoor_LIB;

namespace Celikoor_Tixycket
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        #region Global Variable
        public Konsumen konsumenLogin;
        public Pegawai pegawaiLogin;
        public FormRegisterKonsumen formRegisterKonsumen;
        public FormLoginKonsumen formLoginKonsumen;
        public bool loginStatus = false;
        #endregion
        #region Methods
        public void ButtonLoginEnabler(bool status, string text)
        {
            buttonLogInOut.Enabled = status;
            buttonLogInOut.Text = text;
        }
        #endregion
        #region Events
        private void FormUtama_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogInOut_Click(object sender, EventArgs e)
        {
            if (loginStatus == false)
            {
                Form form = Application.OpenForms["FormLoginKonsumen"];

                if (form == null)
                {
                    formLoginKonsumen = new FormLoginKonsumen();
                    formLoginKonsumen.MdiParent = this;

                    formRegisterKonsumen = new FormRegisterKonsumen();
                    formRegisterKonsumen.MdiParent = this;

                    formLoginKonsumen.Show();
                    formLoginKonsumen.StartPosition = FormStartPosition.CenterScreen;
                }

                else
                {
                    form.Show();
                    form.BringToFront();
                }

                buttonLogInOut.Enabled = false;
                buttonLogInOut.Text = "In Progress";
            }
            else
            {
                loginStatus = false;
                buttonLogInOut.Text = "Log in";
                konsumenLogin = null;
                pegawaiLogin = null;
                //code
            }

        }
        #endregion
    }
}
