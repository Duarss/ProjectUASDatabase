using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Sesi_film
    {
        #region FIELDS
        private Jadwal_film jamPemutaran;
        private Studio namaStudio;
        private Film judulFilm;
        #endregion

        #region CONSTRUCTORS
        public Sesi_film()
        {
            JamPemutaran = new Jadwal_film();
            NamaStudio = new Studio();
            JudulFilm = new Film();
        }
        #endregion

        #region PROPERTIES
        public Jadwal_film JamPemutaran { get => jamPemutaran; set => jamPemutaran = value; }
        public Studio NamaStudio { get => namaStudio; set => namaStudio = value; }
        public Film JudulFilm { get => judulFilm; set => judulFilm = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Sesi_film detils)
        {
            string perintah = $"INSERT INTO sesi_films (jadwal_film_id, studios_id, films_id) " +
                $"VALUES ('{detils.JamPemutaran.Id}', '{detils.NamaStudio.Id}', '{detils.JudulFilm.Id}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD UPDATE U
        public static void UbahData(Sesi_film detils)
        {
            string perintah = $"UPDATE sesi_films " +
                $"SET studios_id='{detils.NamaStudio.Id}' OR films_id='{detils.JudulFilm.Id} " +
                $"WHERE jadwal_film_id='{detils.JamPemutaran.Id}';'";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R
        public static List<Sesi_film> BacaData(string id="")
        {
            string perintah;

            if (id == "")
            {
                perintah = $"SELECT * FROM sesi_films";
            }

            else
            {
                perintah = $"SELECT * FROM sesi_films WHERE jadwal_film_id='{id}'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Sesi_film> listSesiFilm = new List<Sesi_film>();

            while (hasil.Read())
            {
                Sesi_film tampung = new Sesi_film();
                tampung.JamPemutaran.Id = hasil.GetInt32(0);
                tampung.NamaStudio.Id = hasil.GetInt32(1);
                tampung.JudulFilm.Id = hasil.GetInt32(2);

                listSesiFilm.Add(tampung);
            }

            return listSesiFilm;
        }
        #endregion
    }
}
