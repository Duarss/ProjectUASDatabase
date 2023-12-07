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
    public partial class FormMasterCinema : Form
    {
        public FormMasterCinema()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMasterCinema_Load(object sender, EventArgs e)
        {

        }
    }
}
