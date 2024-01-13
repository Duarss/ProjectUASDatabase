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
    public partial class FormUpdateAktor : Form
    {
        public FormUpdateAktor()
        {
            InitializeComponent();
        }

        public string idUpdate;

        private void FormUpdateAktor_Load(object sender, EventArgs e)
        {
            List<Aktor> listDataAktor = Aktor.BacaData();
            textBoxNama.Text = listDataAktor[int.Parse(idUpdate)].Nama;

            string dateString = listDataAktor[int.Parse(idUpdate)].TglLahir;

            if (DateTime.TryParse(dateString, out DateTime parsedDate))
            {
                dateTimePickerTglLahir.Value = parsedDate;
            }

            else
            {
                MessageBox.Show("Invalid date format");
            }

            labelGenderValue.Text = listDataAktor[int.Parse(idUpdate)].Gender;
            labelNegaraAsalValue.Text = listDataAktor[int.Parse(idUpdate)].NegaraAsal;
        }

        private void buttonKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Aktor aktor = new Aktor();
                aktor.Nama = textBoxNama.Text;
                aktor.TglLahir = dateTimePickerTglLahir.Value.ToString("yyyy-MM-dd");

                Aktor.UbahData(aktor);

                MessageBox.Show("Success to update data!");

                this.Close();
            }

            catch (Exception x)
            {
                MessageBox.Show("Failed to update data! Error: " + x.Message);
            }
        }
    }
}
