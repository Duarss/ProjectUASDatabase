using Celikoor_LIB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Celikoor_Tixycket
{
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        public Konsumen konsumenLogin;
        public Pegawai pegawaiLogin;

        private void FormProfile_Load(object sender, EventArgs e)
        {
            
        }

        private void customTextboxName_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextboxName.UnderlinedStyle = true;
        }

        private void customTextboxEmail_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextboxEmail.UnderlinedStyle = true;
        }

        private void customTextboxUsername_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextboxUsername.UnderlinedStyle = true;
        }

        private void customTextboxPhoneNumber_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextboxPhoneNumber.UnderlinedStyle = true;
        }

        private void customTextboxPassword_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextboxPassword.UnderlinedStyle = true;
        }

        private void customTextboxBirthDate_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
            customTextboxBirthDate.UnderlinedStyle = true;
        }
        private void DisableUnderlineStyle()
        {
            foreach (CustomTextbox customTextbox in panelFotoProfile.Controls.OfType<CustomTextbox>())
            {
                customTextbox.UnderlinedStyle = false;
            }
        }

        private void FormProfile_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }

        private void panelFotoProfile_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }

        private void labelProfile_Click(object sender, EventArgs e)
        {
            DisableUnderlineStyle();
        }

        private void buttonEditProfilePicture_Click(object sender, EventArgs e)
        {

        }
    }
}
