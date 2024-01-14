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

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD UBAH U
        public static void UbahData(Ticket ticket)
        {
            string perintah = $"UPDATE tikets SET status_hadir='TRUE' WHERE invoices_id='{ticket.NoInvoice.Id}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close(); //kirim ke command
        }

        //! METHOD RETRIEVE R
        public static string GenerateBarcode(Ticket ticket)
        {
            string barcodeBaru = "001" + ticket.NoKursi;

            string perintah = $"SELECT * FROM invoices " +
                //$"\nWHERE tanggal=current_date " +
                $"\norder by invoices desc " +
                $"\nlimit 1;";

            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);
            conn.KoneksiDB.Close(); //kirim ke command

            if (dr.Read() == true)
            {
                string noBarcodeAkhir = dr.GetValue(0).ToString().Substring(3);
                int noBarcodeBaru = int.Parse(noBarcodeAkhir) + 1;

                barcodeBaru = noBarcodeBaru.ToString().PadLeft(3, '0') + ticket.NoKursi;
            }

            return barcodeBaru;
        }
        public static List<Studio> BacaData(string nomorKursi, Sesi_film sesiFilm)
        {
            string perintah = $"SELECT * FROM tikets WHERE nomor_kursi = '{nomorKursi}'films_id = '{sesiFilm.FilmStudio.Film.Id}', studios_id = '{sesiFilm.FilmStudio.Studio.Id}";

            List<Studio> listStudio = new List<Studio>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Studio tampung = new Studio();

                tampung.Id = int.Parse(dr.GetValue(0).ToString());
                tampung.Nama = dr.GetValue(1).ToString();
                tampung.Kapasitas = int.Parse(dr.GetValue(2).ToString());
                Jenis_Studio tampungJenisStudio = new Jenis_Studio();
                if (dr.GetValue(3).ToString() != "")
                {
                    tampung.JenisStudio.Id = int.Parse(dr.GetValue(3).ToString());
                    List<Jenis_Studio> listItem = Jenis_Studio.BacaData(tampung.JenisStudio.Id.ToString());
                    tampung.JenisStudio = listItem[0];
                }
                Cinema tampungCinema = new Cinema();
                if (dr.GetValue(4).ToString() != "")
                {
                    tampung.Cinema.Id = int.Parse(dr.GetValue(4).ToString());
                    List<Cinema> listItem = Cinema.BacaData(tampung.Cinema.Id.ToString());
                    tampung.Cinema = listItem[0];
                }
                tampung.Harga_weekday = int.Parse(dr.GetValue(5).ToString());
                tampung.Harga_weekend = int.Parse(dr.GetValue(6).ToString());
                listStudio.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listStudio;
        }
        #endregion
    }
}
