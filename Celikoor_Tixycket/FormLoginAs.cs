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
    public partial class FormLoginAs : Form
    {
        public FormLoginAs()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        FormUtama formUtama;

        private void radioButtonKonsumen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonKonsumen.Checked)
            {
                DialogResult confirm = MessageBox.Show("Login as Consumen?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (confirm == DialogResult.OK)
                {
                    this.Visible = false;
                    //FormLoginKonsumen formLoginKonsumen = new FormLoginKonsumen();
                    //formLoginKonsumen.Owner = this;
                    //formLoginKonsumen.ShowDialog();

                    //formLoginKonsumen.StartPosition = FormStartPosition.CenterScreen;
                    formUtama.formLoginKonsumen.Visible = true;
                    formUtama.formLoginKonsumen.StartPosition = FormStartPosition.CenterScreen;
                }

                radioButtonKonsumen.Checked = false;
            }
        }

        private void radioButtonPegawai_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPegawai.Checked)
            {
                DialogResult confirm = MessageBox.Show("Login as Employee?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (confirm == DialogResult.OK)
                {
                    this.Visible = false;
                    //FormLoginEmployee formLoginEmployee = new FormLoginEmployee();
                    //formLoginEmployee.Owner = this;
                    //formLoginEmployee.ShowDialog();

                    //formLoginEmployee.StartPosition = FormStartPosition.CenterScreen;
                }

                radioButtonPegawai.Checked = false;        
            }
        }

        private void FormLoginAs_Load(object sender, EventArgs e)
        {
            formUtama = (FormUtama)this.MdiParent;
        }

        private void FormLoginAs_FormClosing(object sender, FormClosingEventArgs e)
        {
            //clean memory
            formUtama.formLoginKonsumen.Close();
            formUtama.formRegisterKonsumen.Close();
        }
    }
}
