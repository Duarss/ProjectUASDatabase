using Celikoor_LIB;
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
    public partial class FormKasir : Form
    {
        public FormKasir()
        {
            InitializeComponent();
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {

        }

        private void FormKasir_Load(object sender, EventArgs e)
        {
            List<Invoices> listInvoices = Invoices.BacaData();
            dgvData.DataSource = listInvoices;

            int statusColumnIndex = 6;
            int actionColumnIndex = 7;
        
            foreach (DataGridViewRow row in dgvData.Rows)
            {
               
                if (row.Cells[statusColumnIndex].Value.ToString() == "PENDING")
                {
                    DataGridViewButtonColumn btnValidasi = new DataGridViewButtonColumn();
                    btnValidasi.Text = "Validasi";
                    btnValidasi.HeaderText = "Action";
                    btnValidasi.UseColumnTextForButtonValue = true;
                    btnValidasi.Name = "buttonValidasiGrid";
                    if (!dgvData.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == btnValidasi.Name))
                    {
                        dgvData.Columns.Insert(actionColumnIndex, btnValidasi);
                    }
                }
                if(row.Cells[statusColumnIndex].Value.ToString() == "VALIDASI")
                {
                    DataGridViewButtonColumn btnSelesai = new DataGridViewButtonColumn();
                    btnSelesai.Text = "Selesai";
                    btnSelesai.HeaderText = "Action";
                    btnSelesai.UseColumnTextForButtonValue = true;
                    btnSelesai.Name = "buttonSelesaiGrid";

                    if (!dgvData.Columns.Cast<DataGridViewColumn>().Any(col => col.Name == btnSelesai.Name))
                    {
                        dgvData.Columns.Insert(actionColumnIndex, btnSelesai);
                    }
                }
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string kode = dgvData.CurrentRow.Cells["Id"].Value.ToString();

            if (e.ColumnIndex == dgvData.Columns["buttonValidasiGrid"].Index)
            {
                if(dgvData.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "PENDING")
                {
                    DialogResult dr = MessageBox.Show("Validate invoice " + kode + "?", "Validate Process",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) //jika user setuju hapus data
                    {
                        try
                        {
                            //hapus data dari database
                            Invoices.UbahData(kode.ToString(), false);
                            //refresh form master
                            FormKasir_Load(this, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to validate data: " + ex.Message);
                        }
                    }
                }
                else if(dgvData.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "VALIDASI")
                {
                    MessageBox.Show("Has been validated!");
                }
                else
                {
                    MessageBox.Show("Has been paid!");
                }
                //konfirmasi penghapusan ke user
                
            }
            else if (e.ColumnIndex == dgvData.Columns["buttonSelesaiGrid"].Index)
            {
                if(dgvData.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "VALIDASI")
                {
                    DialogResult dr = MessageBox.Show("Finish process " + kode + "?", "Finish Process",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes) //jika user setuju hapus data
                    {
                        try
                        {
                            //hapus data dari database
                            Invoices.UbahData(kode.ToString(), true);
                            //refresh form master
                            FormKasir_Load(this, e);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed to finish data: " + ex.Message);
                        }
                    }
                }
                else if(dgvData.Rows[e.RowIndex].Cells["Status"].Value.ToString() == "PENDING")
                {
                    MessageBox.Show("Hasn't been validated!");
                }
                else
                {
                    MessageBox.Show("Has been paid!");
                }
                //konfirmasi penghapusan ke user
                
            }
        }
    }
}
