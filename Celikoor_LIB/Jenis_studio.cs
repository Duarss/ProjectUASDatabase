using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Jenis_Studio
    {
        #region FIELDS
        int id;
        string nama;
        string deskripsi;
        #endregion

        #region CONSTRUCTORS
        public Jenis_Studio()
        {
            Id = 0;
            Nama = "";
            Deskripsi = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Jenis_Studio jenisStudio)
        {
            string perintah = $"INSERT INTO jenis_studios (nama, deskripsi) VALUES ('{jenisStudio.Nama}', '{jenisStudio.Deskripsi}');";

            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            //susun perintah query
            string perintah = $"DELETE FROM jenis_studios WHERE id='{idHapus}';";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        //! METHOD RETRIEVE R
        public static List<Jenis_Studio> BacaData(string id="")
        {
            string perintah;

            if (id == "")
            {
                perintah = $"SELECT * FROM jenis_studios";
            }

            else
            {
                perintah = $"SELECT * FROM jenis_studios WHERE id='{id}'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Jenis_Studio> listJenisStudio = new List<Jenis_Studio>();

            while (hasil.Read() == true)
            {   
                Jenis_Studio tampung = new Jenis_Studio();
                tampung.Id = hasil.GetInt32(0);
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Deskripsi = hasil.GetValue(2).ToString();

                listJenisStudio.Add(tampung);
            }

            return listJenisStudio;
        }
        #endregion
    }
}
