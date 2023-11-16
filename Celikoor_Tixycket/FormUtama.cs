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
            FormLoginEmployee formLoginEmployee = new FormLoginEmployee();
            formLoginEmployee.MdiParent = this;
            formLoginEmployee.Show();
            formLoginEmployee.StartPosition = FormStartPosition.CenterParent;
        }
    }
}
