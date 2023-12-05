using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Aktor_film
    {
        #region FIELDS
        private Aktor namaAktor;
        private Film judulFilm;
        private string peran;
        #endregion

        #region CONSTRUCTORS
        public Aktor_film()
        {
            NamaAktor = new Aktor();
            JudulFilm = new Film();
            Peran = "";
        }
        #endregion

        #region PROPERTIES
        public Aktor NamaAktor { get => namaAktor; set => namaAktor = value; }
        public Film JudulFilm { get => judulFilm; set => judulFilm = value; }
        public string Peran { get => peran; set => peran = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Aktor_film detils)
        {
            string perintah = $"INSERT INTO aktor_film (aktors_id, films_id, peran) VALUES ('{detils.NamaAktor.Id}', '{detils.JudulFilm.Id}', '{detils.Peran}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R
        public static List<Aktor_film> BacaData(int idAktor=0)
        {
            string perintah;

            if (idAktor == 0)
            {
                perintah = $"SELECT * FROM aktor_film";
            }

            else
            {
                perintah = $"SELECT * FROM aktor_film WHERE aktors_id='{idAktor}'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Aktor_film> listAktorFilm = new List<Aktor_film>();

            while (hasil.Read() == true)
            {
                Aktor_film tampung = new Aktor_film();
                tampung.NamaAktor.Id = hasil.GetInt32(0);
                tampung.JudulFilm.Id = hasil.GetInt32(1);
                tampung.Peran = hasil.GetValue(2).ToString();

                listAktorFilm.Add(tampung);
            }

            return listAktorFilm;
        }
        #endregion
    }
}
