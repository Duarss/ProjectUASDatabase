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
        #region FIELDS
        private int id;
        private string nama;
        private string email;
        private string username;
        private string password;
        private string role;
        #endregion

        #region CONSTRUCTORS
        public Pegawai()
        {
            Id = 0;
            Nama = "";
            Email = "";
            Username = "";
            Password = "";
            Role = "";
        }

        public Pegawai(int id, string nama, string email, string username, string role)
        {
            this.Id = id;
            this.Nama = nama;
            this.Email = email;
            this.Username = username;
            this.Role = role;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Pegawai pegawai)
        {
            string perintah = $"INSERT INTO pegawais (nama, email, username, password, roles) " +
                $"VALUES ('{pegawai.Nama}', '{pegawai.Email}', '{pegawai.Username}', '{pegawai.Password}'" +
                $", '{pegawai.Role}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM pegawais WHERE id='{idHapus}';";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Pegawai> BacaData(string filter = "", string nilai = "")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT id, nama, email, username, roles FROM pegawais";
            }

            else
            {
                perintah = $"SELECT * FROM pegawais WHERE {filter} like '%{nilai}%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Pegawai> listPegawai = new List<Pegawai>();

            while (hasil.Read() == true)
            {   
                Pegawai tampung = new Pegawai();
                tampung.Id = hasil.GetInt32(0);
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Email = hasil.GetValue(2).ToString();
                tampung.Username = hasil.GetValue(3).ToString();
                tampung.Password = "";
                tampung.Role = hasil.GetValue(4).ToString();

                listPegawai.Add(tampung);
            }

            return listPegawai;
        }

        //! METHOD CEK LOGIN PEGAWAI
        public static Pegawai CekLogin(string username, string pswd)
        {
            string perintah = $"SELECT * FROM pegawais p WHERE p.username='{username}' and p.password = '{pswd}'";
            //eksekusi perintah di atas
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            //selama masih ada data yang dapat dibaca dari datareader
            if (hasil.Read() == true)
            {
                int id = int.Parse(hasil.GetValue(0).ToString());
                string nama = hasil.GetValue(1).ToString();
                string email = hasil.GetValue(2).ToString();
                string usernamePegawai = hasil.GetValue(3).ToString();
                string role = hasil.GetValue(5).ToString();
                Pegawai tampung = new Pegawai(id, nama, email, usernamePegawai, role);
                return tampung;
            }

            else return null;
        }
        #endregion
    }
}
