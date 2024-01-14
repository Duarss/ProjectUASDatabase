using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Jadwal_film
    {
        #region FIELDS
        int id;
        string tanggal;
        string jam_pemutaran;
        #endregion

        #region CONSTRUCTORS
        public Jadwal_film()
        {
            Id = 0;
            Tanggal = "";
            Jam_pemutaran = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Tanggal { get => tanggal; set => tanggal = value; }
        public string Jam_pemutaran { get => jam_pemutaran; set => jam_pemutaran = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Jadwal_film jadwalFilm)
        {
            string perintah = $"INSERT INTO jadwal_films (tanggal, jam_pemutaran) VALUES ('{jadwalFilm.Tanggal}', '{jadwalFilm.Jam_pemutaran}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD UPDATE U
        public static void UbahData(Jadwal_film jadwalFilm)
        {
            string perintah = $"UPDATE jadwal_films SET tanggal='{jadwalFilm.Tanggal}', jam_pemutaran='{jadwalFilm.Jam_pemutaran}' WHERE id='{jadwalFilm.Id}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus="")
        {
            string perintah = $"DELETE FROM jadwal_films WHERE id='{idHapus}'";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Jadwal_film> BacaData(string filter="", string nilai = "")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM jadwal_films";
            }
            else if(filter == "getLastIndex")
            {
                perintah = $"SELECT * FROM jadwal_films order by id DESC LIMIT 1;";
            }
            else
            {
                perintah = $"SELECT * FROM jadwal_films WHERE {filter} like '%{nilai}%'";
            }

            List<Jadwal_film> listJadwalFilm = new List<Jadwal_film>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Jadwal_film tampung = new Jadwal_film();
                tampung.Id = dr.GetInt32(0);
                tampung.Tanggal = dr.GetValue(1).ToString();
                tampung.Jam_pemutaran = dr.GetValue(2).ToString();

                listJadwalFilm.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listJadwalFilm;
        }
        #endregion
    }
}
