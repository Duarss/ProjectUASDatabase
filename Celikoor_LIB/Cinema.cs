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
        int id;
        string nama_cabang;
        string alamat;
        DateTime tglDibuka;
        string kota;

        public Cinema()
        {

        }
        public Cinema(int id, string nama_cabang, string alamat, DateTime tglDibuka, string kota)
        {
            Id = id;
            Nama_cabang = nama_cabang;
            Alamat = alamat;
            TglDibuka = tglDibuka;
            Kota = kota;
        }

        public int Id { get => id; set => id = value; }
        public string Nama_cabang { get => nama_cabang; set => nama_cabang = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public DateTime TglDibuka { get => tglDibuka; set => tglDibuka = value; }
        public string Kota { get => kota; set => kota = value; }

        public static void TambahData(Cinema k)
        {
            //susun perintah query
            string perintah = " INSERT INTO cinema " + " (Id, Nama_cabang, Alamat, TglDibuka, Kota) VALUES " + "('"
                + k.Id.ToString() + "', '" + k.Nama_cabang + "', '" + k.Alamat + "', '" + k.TglDibuka.ToString("yyyy-MM-dd") + "', '"
                + k.Kota + "');";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void HapusData(int idHapus)
        {
            //susun perintah query
            string perintah = "delete from cinema where id='" + idHapus + "';";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static List<Pegawai> BacaData(string filter = "", string nilai = "")
        {
            //susun perintah query
            string perintah;
            if (filter == "")
            {
                perintah = "select * from cinema";
            }
            else
            {
                perintah = "select * from cinema where " + filter + " like '%" + nilai + "%'";
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
