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

        private void FormProfile_Load(object sender, EventArgs e)
        {
        }

        private void panelFotoProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customTextboxName_Click(object sender, EventArgs e)
        {
            ChangeUnderlineStyle();
            customTextboxName.UnderlinedStyle = true;
        }

        private void customTextboxEmail_Click(object sender, EventArgs e)
        {
            ChangeUnderlineStyle();
            customTextboxEmail.UnderlinedStyle = true;
        }

        private void customTextboxUsername_Click(object sender, EventArgs e)
        {
            ChangeUnderlineStyle();
            customTextboxUsername.UnderlinedStyle = true;
        }

        private void customTextboxPhoneNumber_Click(object sender, EventArgs e)
        {
            ChangeUnderlineStyle();
            customTextboxPhoneNumber.UnderlinedStyle = true;
        }

        private void customTextboxPassword_Click(object sender, EventArgs e)
        {
            ChangeUnderlineStyle();
            customTextboxPassword.UnderlinedStyle = true;
        }

        private void customTextboxBirthDate_Click(object sender, EventArgs e)
        {
            ChangeUnderlineStyle();
            customTextboxBirthDate.UnderlinedStyle = true;
        }
        private void ChangeUnderlineStyle()
        {
            foreach (CustomTextbox customTextbox in panelFotoProfile.Controls.OfType<CustomTextbox>())
            {
                customTextbox.UnderlinedStyle = false;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void FormProfile_Click(object sender, EventArgs e)
        {
            ChangeUnderlineStyle();
        }

        private void customTextboxEmail__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
