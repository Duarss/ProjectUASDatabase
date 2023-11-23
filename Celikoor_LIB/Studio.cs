using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Studio
    {
        int id;
        string nama;
        int kapasitas;
        Jenis_studio jenis_studio_id;
        Cinema cinema_id;
        int harga_weekday;
        int harga_weekend;

        public Studio()
        {

        }
        public Studio(int id, string nama, int kapasitas, Jenis_studio jenis_studio_id, Cinema cinema_id, int harga_weekday, int harga_weekend)
        {
            Id = id;
            Nama = nama;
            Kapasitas = kapasitas;
            Jenis_studio_id = jenis_studio_id;
            Cinema_id = cinema_id;
            Harga_weekday = harga_weekday;
            Harga_weekend = harga_weekend;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public Jenis_studio Jenis_studio_id { get => jenis_studio_id; set => jenis_studio_id = value; }
        public Cinema Cinema_id { get => cinema_id; set => cinema_id = value; }
        public int Harga_weekday { get => harga_weekday; set => harga_weekday = value; }
        public int Harga_weekend { get => harga_weekend; set => harga_weekend = value; }

        public static void TambahData(Pegawai k)
        {
            //susun perintah query
            string perintah = " INSERT INTO pegawai " + " (IdPegawai, Nama, Email, Username, Password) VALUES " + "('"
                + k.Id.ToString() + "', '" + k.Nama + "', '" + k.Email + "', '" + k.Username.ToString() + "', '"
                + k.Password.ToString() + "');";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void UbahData(Pegawai k)
        {
            //susun perintah query
            string perintah = " update kategori set Nama='" + k.Nama.Replace("'", "\\'") + "' where Id='" + k.Id + "'";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void HapusData(string kodeHapus)
        {
            //susun perintah query
            string perintah = "delete from kategori where kodekategori='" + kodeHapus + "';";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static List<Pegawai> BacaData(string filter = "", string nilai = "")
        {
            //susun perintah query
            string perintah;
            if (filter == "")
            {
                perintah = "select * from pegawai";
            }
            else
            {
                perintah = "select * from kategori where " + filter + " like '%" + nilai + "%'";
            }
            //eksekusi perintah di atas
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Pegawai> ListData = new List<Pegawai>();

            //selama masih ada data yang dapat dibaca dari datareader
            while (hasil.Read() == true)
            {   //ambil isi datareader
                string tampungKode = hasil.GetValue(0).ToString(); //kolom pertama
                string tampungNama = hasil.GetValue(1).ToString(); //kolom kedua
                //tampung ke sebuah objek kategori
                Pegawai tampung = new Pegawai();
                //tambahkan ke list
                ListData.Add(tampung);
            }
            //kirim list ke pemanggilnya
            return ListData;
        }
    }
}
