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

        //global variable
        public FormRegisterKonsumen formRegisterKonsumen;
        public FormLoginKonsumen formLoginKonsumen;

        private void FormUtama_Load(object sender, EventArgs e)
        {
            try
            {
                string server = db.Default.dbServer;
                string dbname = db.Default.dbName;
                string uid = db.Default.dbUsername;
                string pwd = db.Default.dbPassword;
                Koneksi k = new Koneksi(server, dbname, uid, pwd);

                MessageBox.Show("Status: Koneksi Berhasil!\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Status: Koneksi Gagal! error: " + ex.Message + "\n");
            }
        }

        private void buttonLogInOut_Click(object sender, EventArgs e)
        {
            formRegisterKonsumen = new FormRegisterKonsumen(); //test
            formRegisterKonsumen.MdiParent = this;

            formLoginKonsumen = new FormLoginKonsumen();
            formLoginKonsumen.MdiParent = this;

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

            buttonLogInOut.Enabled = false;
            buttonLogInOut.Text = "In Progress";
        }
    }
}
