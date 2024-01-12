using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Celikoor_LIB
{
    public class Film
    {
        #region FIELDS
        int id;
        string judul;
        string sinopsis;
        int tahun;
        int durasi;
        Kelompok kelompokUsia;
        string bahasa;
        int is_sub_indo;
        string coverImage;
        double diskon;
        List<Aktor_film> listAktorFilm;
        #endregion

        #region CONSTRUCTORS
        public Film()
        {
            Id = 0;
            Judul = "";
            Sinopsis = "";
            Tahun = DateTime.Now.Year;
            Durasi = 0;
            KelompokUsia = new Kelompok();
            Bahasa = "";
            Is_sub_indo = 0;
            CoverImage = "";
            Diskon = 0;
            ListAktorFilm = new List<Aktor_film>();
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        
        public double Diskon { get => diskon; set => diskon = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public Kelompok KelompokUsia { get => kelompokUsia; set => kelompokUsia = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public int Is_sub_indo { get => is_sub_indo; set => is_sub_indo = value; }
        public string CoverImage { get => coverImage; set => coverImage = value; }
        public List<Aktor_film> ListAktorFilm { get => listAktorFilm; set => listAktorFilm = value; }
        #endregion

        #region METHODS
        
        //! METHOD CREATE C
        public static void TambahData(Film film)
        {
            string perintah = $"INSERT INTO films (id, judul, sinopsis, tahun, durasi, kelompoks_id, bahasa, is_sub_indo, coverimage, diskon_nominal)" +
                $"VALUES ('{film.Id}', '{film.Judul}', '{film.Sinopsis}', '{film.Tahun}', '{film.Durasi}', '{film.KelompokUsia.Id}', '{film.Bahasa}', '{film.Is_sub_indo}', '{film.CoverImage}', '{film.Diskon}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD UPDATE U
        public static void UbahData(Film film)
        {
            string perintah = $"UPDATE films SET judul= '{film.Judul}', sinopsis='{film.Sinopsis}', tahun='{film.Tahun}', durasi='{film.Durasi}', kelompoks_id='{film.KelompokUsia.Id}', '{film.Bahasa}', '{film.Is_sub_indo}', '{film.CoverImage}', '{film.Diskon}'" +
                $"WHERE id = '{film.Id}'";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM films WHERE id = '{idHapus}';";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Film> BacaData(string filter="", string nilai="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM films";
            }

            else
            {
                perintah = $"SELECT * FROM films WHERE {filter} like '%{nilai}%'";
            }

            //MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Film> listFilm = new List<Film>();
            Koneksi conn = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, conn.KoneksiDB);
            MySqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read() == true)
            {
                Film tampung = new Film();
                tampung.Id = dr.GetInt32(0);
                tampung.Judul = dr.GetValue(1).ToString();
                tampung.Sinopsis = dr.GetValue(2).ToString();
                tampung.Tahun = int.Parse(dr.GetValue(3).ToString());
                tampung.Durasi = int.Parse(dr.GetValue(4).ToString());
                
                tampung.KelompokUsia = new Kelompok();
                if (dr.GetValue(5).ToString() != "")
                {
                    tampung.KelompokUsia.Id = int.Parse(dr.GetValue(5).ToString());
                    int num = tampung.KelompokUsia.Id;
                    List<Kelompok> listKel = Kelompok.BacaData(tampung.KelompokUsia.Id.ToString());
                    tampung.KelompokUsia = listKel[0];
                }
                tampung.Bahasa = dr.GetValue(6).ToString();
                tampung.Is_sub_indo = int.Parse(dr.GetValue(7).ToString());
                tampung.CoverImage = dr.GetValue(8).ToString();
                tampung.Diskon = double.Parse(dr.GetValue(9).ToString());

                listFilm.Add(tampung);
            }
            conn.KoneksiDB.Close();
            return listFilm;
        }
        public override string ToString()
        {
            return Judul;
        }
        #endregion
    }
}
