using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Film_studio
    {
        #region FIELDS
        private Studio namaStudio;
        private Film judulFilm;
        #endregion

        #region CONSTRUCTORS
        public Film_studio()
        {
            NamaStudio = new Studio();
            JudulFilm = new Film();
        }
        #endregion

        #region PROPERTIES
        public Studio NamaStudio { get => namaStudio; set => namaStudio = value; }
        public Film JudulFilm { get => judulFilm; set => judulFilm = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Film_studio detils)
        {
            string perintah = $"INSERT INTO film_studio (studios_id, films_id) VALUES ('{detils.NamaStudio.Id}', '{detils.JudulFilm.Id}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD UPDATE U
        public static void UbahData(Film_studio detils)
        {
            string perintah = $"UPDATE film_studio SET studios_id='{detils.NamaStudio.Id}' WHERE films_id='{detils.JudulFilm.Id}';";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R
        public static List<Film_studio> BacaData(string id="")
        {
            string perintah;

            if (id == "")
            {
                perintah = $"SELECT * FROM film_studio";
            }

            else
            {
                perintah = $"SELECT * FROM film_studio WHERE studios_id='{id}'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Film_studio> listFilmStudio = new List<Film_studio>();

            while (hasil.Read())
            {
                Film_studio tampung = new Film_studio();
                tampung.NamaStudio.Id = hasil.GetInt32(0);
                tampung.JudulFilm.Id = hasil.GetInt32(1);

                listFilmStudio.Add(tampung);
            }

            return listFilmStudio;
        }
        #endregion
    }
}
