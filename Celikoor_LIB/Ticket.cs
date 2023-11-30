using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Ticket
    {
        #region FIELDS
        private Invoices noInvoice;
        private string noKursi;
        private bool statusHadir;
        private Pegawai operators;
        private double harga;
        private Jadwal_film jadwalFilm;
        private Studio studio;
        private Film film;
        #endregion

        #region CONSTRUCTORS
        public Ticket()
        {
            NoInvoice = new Invoices();
            NoKursi = "";
            StatusHadir = false;
            Operators = new Pegawai();
            Harga = 0;
            JadwalFilm = new Jadwal_film();
            Studio = new Studio();
            Film = new Film();
        }
        #endregion

        #region PROPERTIES
        public Invoices NoInvoice { get => noInvoice; set => noInvoice = value; }
        public string NoKursi { get => noKursi; set => noKursi = value; }
        public bool StatusHadir { get => statusHadir; set => statusHadir = value; }
        public Pegawai Operators { get => operators; set => operators = value; }
        public double Harga { get => harga; set => harga = value; }
        public Jadwal_film JadwalFilm { get => jadwalFilm; set => jadwalFilm = value; }
        public Studio Studio { get => studio; set => studio = value; }
        public Film Film { get => film; set => film = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Ticket ticket)
        {
            string perintah = $"INSERT INTO tikets (invoices_id, nomor_kursi, status_hadir, operator_id, harga, jadwal_film_id, studios_id, films_id) " +
                $"VALUES ('{ticket.NoInvoice}', '{ticket.NoKursi}', 'FALSE', '{ticket.Operators.Id}', '{ticket.Harga}'" +
                $", '{ticket.JadwalFilm.Id}', '{ticket.Studio.Id}', '{ticket.Film.Id}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }
        //! METHOD UBAH U
        public static void UbahData(Ticket ticket)
        {

        }
        //! METHOD RETRIEVE R
        public static string GenerateBarcode(Ticket ticket)
        {
            string barcodeBaru = "001" + ticket.NoKursi;

            string perintah = $"SELECT * FROM invoices " +
                //$"\nWHERE tanggal=current_date " +
                $"\norder by invoices desc " +
                $"\nlimit 1;";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read() == true)
            {
                string noBarcodeAkhir = hasil.GetValue(0).ToString().Substring(3);
                int noBarcodeBaru = int.Parse(noBarcodeAkhir) + 1;

                barcodeBaru = noBarcodeBaru.ToString().PadLeft(3, '0') + ticket.NoKursi;
            }

            return barcodeBaru;
        }
        #endregion
    }
}
