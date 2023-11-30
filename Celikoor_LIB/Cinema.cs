using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Cinema
    {
        #region FIELDS
        int id;
        string nama_cabang;
        string alamat;
        DateTime tglDibuka;
        string kota;
        #endregion

        #region CONSTRUCTORS
        public Cinema()
        {
            Id = 0;
            Nama_cabang = "";
            Alamat = "";
            TglDibuka = DateTime.Now;
            Kota = "";
        }

        public Cinema(int id, string nama_cabang, string alamat, DateTime tglDibuka, string kota)
        {
            Id = id;
            Nama_cabang = nama_cabang;
            Alamat = alamat;
            TglDibuka = tglDibuka;
            Kota = kota;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama_cabang { get => nama_cabang; set => nama_cabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime TglDibuka { get => tglDibuka; set => tglDibuka = value; }
        public string Kota { get => kota; set => kota = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Cinema cinema)
        {
            string perintah = $"INSERT INTO cinemas (nama_cabang, alamat, tgl_dibuka, kota) " +
                $"VALUES ('{cinema.Nama_cabang}', '{cinema.Alamat}', '{cinema.TglDibuka.ToShortDateString()}'" +
                $", '{cinema.Kota}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM cinemas WHERE id='{idHapus}'";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R
        public static List<Cinema> BacaData(string id="")
        {
            //susun perintah query
            string perintah;

            if (id == "")
            {
                perintah = $"SELECT * FROM cinemas";
            }
            else
            {
                perintah = $"SELECT * FROM cinemas WHERE id='{id}'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Cinema> listCinema = new List<Cinema>();

            while (hasil.Read() == true)
            {   
                Cinema tampung = new Cinema();
                tampung.Id = hasil.GetInt32(0);
                tampung.Nama_cabang = hasil.GetValue(1).ToString();
                tampung.Alamat = hasil.GetValue(2).ToString();
                tampung.TglDibuka = (DateTime)hasil.GetValue(3);
                tampung.Kota = hasil.GetValue(4).ToString();

                listCinema.Add(tampung);
            }
            //kirim list ke pemanggilnya
            return listCinema;
        }
        #endregion
    }
}
