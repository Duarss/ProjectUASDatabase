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

namespace Celikoor_Tixycket
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormUtama_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogInOut_Click(object sender, EventArgs e)
        {
            Form form = Application.OpenForms["FormLoginAs"];

            if (form == null)
            {
                FormLoginAs formLoginAs = new FormLoginAs();
                formLoginAs.MdiParent = this;
                formLoginAs.Show();
                formLoginAs.StartPosition = FormStartPosition.CenterScreen;
            }

            else
            {
                form.Show();
                form.BringToFront();
            }
        }
    }
}
