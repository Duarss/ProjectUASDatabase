using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Invoices
    {
        #region FIELDS
        private int id;
        private DateTime tanggal;
        private double grand_total;
        private double diskon_nominal;
        private Konsumen penonton;
        private Pegawai kasir;
        private string status;
        #endregion

        #region CONSTRUCTORS
        public Invoices()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            Grand_total = 0;
            Diskon_nominal = 0;
            Penonton = new Konsumen();
            Kasir = new Pegawai();
            Status = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public double Grand_total { get => grand_total; set => grand_total = value; }
        public double Diskon_nominal { get => diskon_nominal; set => diskon_nominal = value; }
        public Konsumen Penonton { get => penonton; set => penonton = value; }
        public Pegawai Kasir { get => kasir; set => kasir = value; }
        public string Status { get => status; set => status = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Invoices invoice)
        {
            string perintah = $"INSERT INTO invoices (tanggal, grand_total, diskon_nominal, konsumens_id, kasir_id, status) " +
                $"VALUES ('{invoice.Tanggal.ToString("dd-MM-yyyy")}', '{invoice.Grand_total}'" +
                $", '{invoice.Diskon_nominal}', '{invoice.Penonton.Id}', '{invoice.Kasir.Id}','PENDING');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD UPDATE U
        public static void UbahData(Invoices invoice, bool isPaid)
        {
            string perintah;

            if (!isPaid)
            {
                perintah = $"UPDATE invoices SET status='VALIDASI' WHERE id='{invoice.Id}';";
            }

            else
            {
                perintah = $"UPDATE invoices SET status='TERBAYAR' WHERE id='{invoice.Id}';";
            }      

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R
        public static string GenerateNoInvoice()
        {
            string invoiceBaru = "001";

            string perintah = $"SELECT * FROM invoices " +
                $"\nWHERE tanggal=current_date " +
                $"\norder by invoices desc " +
                $"\nlimit 1;";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read() == true)
            {
                string noInvoiceAkhir = hasil.GetValue(0).ToString().Substring(3);
                int noInvoiceBaru = int.Parse(noInvoiceAkhir) + 1;

                invoiceBaru = noInvoiceBaru.ToString().PadLeft(3, '0');
            }

            return invoiceBaru;
        }
        #endregion
    }
}
