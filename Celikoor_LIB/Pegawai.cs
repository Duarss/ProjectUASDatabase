using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Pegawai
    {
        private int id;
        private string nama;
        private string email;
        private string username;
        private string password;
        private string role;

        public Pegawai()
        {
            Nama = "";
            Email = "";
            Username = "";
            Password = "";
            Role = "";
        }
        public Pegawai(int id, string nama, string email, string username, string password, string role)
        {
            Id = id;
            Nama = nama;
            Email = email;
            Username = username;
            Password = password;
            Role = role;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }

        public static void TambahData(Pegawai p)
        {
            //susun perintah query
            string perintah = " INSERT INTO pegawais " + " (id, nama, email, username, password) VALUES " + "('"
                + p.Id.ToString() + "', '" + p.Nama + "', '" + p.Email + "', '" + p.Username.ToString() + "', '"
                + p.Password.ToString() + "');";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void HapusData(int idHapus)
        {
            //susun perintah query
            string perintah = "delete from pegawais where id='" + idHapus + "';";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static List<Pegawai> BacaData(string filter = "", string nilai = "")
        {
            //susun perintah query
            string perintah;
            if (filter == "")
            {
                perintah = "select * from pegawais";
            }
            else
            {
                perintah = "select * from pegawais where " + filter + " like '%" + nilai + "%'";
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
        public static Pegawai CekLogin(string id, string pwd)
        {
            string perintah = "SELECT * from pegawais p where p.id='"
                    + id + "' and p.password = '" + pwd + "'";
            //eksekusi perintah di atas
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            //selama masih ada data yang dapat dibaca dari datareader
            if (hasil.Read() == true)
            {
                Pegawai tampung = new Pegawai();
                tampung.Id = int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Email = hasil.GetValue(2).ToString();
                tampung.Username = hasil.GetValue(3).ToString();
                tampung.Role = hasil.GetValue(5).ToString();
                return tampung;
            }
            else return null;
        }
    }
}
