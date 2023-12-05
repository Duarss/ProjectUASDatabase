using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Genre_film
    {
        #region FIELDS
        private Film judulFilm;
        private Genre genreFilm;
        #endregion

        #region CONSTRUCTORS
        public Genre_film()
        {
            JudulFilm = new Film();
            GenreFilm = new Genre();
        }
        #endregion

        #region PROPERTIES
        public Film JudulFilm { get => judulFilm; set => judulFilm = value; }
        public Genre GenreFilm { get => genreFilm; set => genreFilm = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Genre_film detils)
        {
            string perintah = $"INSERT INTO genre_film (films_id, genres_id) VALUES ('{detils.JudulFilm.Id}', '{detils.GenreFilm.Id}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R
        public static List<Genre_film> BacaData(int id = 0)
        {
            string perintah;

            if (id == 0)
            {
                perintah = $"SELECT * FROM genre_film";
            }

            else
            {
                perintah = $"SELECT * FROM genre_film WHERE films_id='{id}'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Genre_film> listGenreFilm = new List<Genre_film>();

            while (hasil.Read())
            {
                Genre_film tampung = new Genre_film();
                tampung.JudulFilm.Id = hasil.GetInt32(0);
                tampung.GenreFilm.Id = hasil.GetInt32(1);

                listGenreFilm.Add(tampung);
            }

            return listGenreFilm;
        }
        #endregion
    }
}
