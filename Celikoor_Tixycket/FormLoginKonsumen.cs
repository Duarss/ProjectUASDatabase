using Celikoor_Tixycket.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        #region Global Variable
        List<Image> posterList = new List<Image> { Resources.poster1, Resources.poster2, Resources.poster3 };
        FormUtama formUtama;
        int indexImg = 0; //untuk ganti poster
        bool loginStatus = false; //ganti nama button di formutama
        #endregion
        #region Events
        private void FormLoginKonsumen_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
        }

        private void linkLabelCreateAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            formUtama.formRegisterKonsumen.Visible = true;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //if login berhasil ---
            formUtama.Visible = true;
            formUtama.loginStatus = true;
            formUtama.formRegisterKonsumen.Close();
            loginStatus = true;
            this.Close();
        }

        private void textBoxPasswordLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUsernameLogin.Text == "")
            {
                textBoxUsernameLogin.Text = "Username";
                textBoxUsernameLogin.ForeColor = Color.Silver;
            }
            if (textBoxPasswordLogin.ForeColor == Color.Silver)
            {
                textBoxPasswordLogin.Text = "";
                textBoxPasswordLogin.UseSystemPasswordChar = true;
                textBoxPasswordLogin.ForeColor = Color.Black;
            }
        }

        private void textBoxUsernameLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPasswordLogin.Text == "")
            {
                textBoxPasswordLogin.Text = "Password";
                textBoxPasswordLogin.UseSystemPasswordChar = false;
                textBoxPasswordLogin.ForeColor = Color.Silver;
            }
            if (textBoxUsernameLogin.ForeColor == Color.Silver)
            {
                textBoxUsernameLogin.Text = "";
                textBoxUsernameLogin.ForeColor = Color.Black;
            }
        }

        private void timerImageMoving_Tick(object sender, EventArgs e)
        {
            if (indexImg > 2)
            {
                indexImg = 0;
            }
            panelImage.BackgroundImage = posterList[indexImg];
            indexImg++;
        }

        private void FormLoginKonsumen_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loginStatus)
            {
                formUtama.ButtonLoginEnabler(true, "Log out");
            }
            else
            {
                formUtama.ButtonLoginEnabler(true, "Log in");
            }
            formUtama.formRegisterKonsumen.Close();
        }
        #endregion
    }
}
