using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Aktor
    {
        int id;
        string nama;
        DateTime tglLahir;
        string gender;
        string negaraAsal;

        public Aktor()
        {

        }
        public Aktor(int id, string nama, DateTime tglLahir, string gender, string negaraAsal)
        {
            Id = id;
            Nama = nama;
            TglLahir = tglLahir;
            Gender = gender;
            NegaraAsal = negaraAsal;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NegaraAsal { get => negaraAsal; set => negaraAsal = value; }

        public static void TambahData(Aktor a)
        {
            //susun perintah query
            string perintah = " INSERT INTO aktors " + " (Nama, TglLahir, Gender, NegaraAsal) VALUES " + "('"
                + a.Nama + "', '" + a.TglLahir.ToString("yyyy-MM-dd") + "', '" + a.Gender + "', '"
                + a.NegaraAsal + "');";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void UbahData(Aktor a)
        {
            //susun perintah query
            string perintah = "update aktors set nama='" + a.Nama + " 'where id='"
                + a.Id + "';";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void HapusData(int idHapus)
        {
            //susun perintah query
            string perintah = "delete from kategori where kodekategori='" + idHapus + "';";
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
