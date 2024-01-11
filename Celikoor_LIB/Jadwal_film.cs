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
        DateTime tanggal;
        string jam_pemutaran;
        #endregion

        #region CONSTRUCTORS
        public Jadwal_film()
        {
            Id = 0;
            Tanggal = DateTime.Now;
            Jam_pemutaran = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public DateTime Tanggal { get => tanggal; set => tanggal = value; }
        public string Jam_pemutaran { get => jam_pemutaran; set => jam_pemutaran = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Jadwal_film jadwalFilm)
        {
            string perintah = $"INSERT INTO jadwal_films (tanggal, jam_pemutaran) VALUES ('{jadwalFilm.Tanggal.ToShortDateString()}', '{jadwalFilm.Jam_pemutaran}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD UPDATE U
        public static void UbahData(Jadwal_film jadwalFilm)
        {
            string perintah = $"UPDATE jadwal_films SET tanggal='{jadwalFilm.Tanggal.ToShortDateString()}', jam_pemutaran='{jadwalFilm.Jam_pemutaran}' WHERE id='{jadwalFilm.Id}';";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus="")
        {
            string perintah = $"DELETE FROM jadwal_films WHERE id='{idHapus}'";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Jadwal_film> BacaData(string filter="", string nilai = "")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM jadwal_films";
            }

            else
            {
                perintah = $"SELECT * FROM jadwal_films WHERE {filter} like '%{nilai}%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Jadwal_film> listJadwalFilm = new List<Jadwal_film>();

            while (hasil.Read() == true)
            {
                Jadwal_film tampung = new Jadwal_film();
                tampung.Id = hasil.GetInt32(0);
                tampung.Tanggal = (DateTime)hasil.GetValue(1);
                tampung.Jam_pemutaran = hasil.GetValue(2).ToString();

                listJadwalFilm.Add(tampung);
            }

            return listJadwalFilm;
        }
        #endregion
    }
}
