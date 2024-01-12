using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Konsumen
    {
        #region FIELDS
        private int id;
        private string nama;
        private string email;
        private string noHp;
        private string gender;
        private DateTime tglLahir;
        private double saldo;
        private string username;
        private string password;
        #endregion

        #region CONSTRUCTORS
        public Konsumen()
        {
            Id = 0;
            Nama = "";
            Email = "";
            NoHp = "";
            Gender = "";
            TglLahir = DateTime.Now;
            Saldo = 0;
            Username = "";
            Password = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NoHp { get => noHp; set => noHp = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Konsumen konsumen)
        {
            string perintah = $"INSERT INTO konsumens (nama, email, no_hp, gender, tgl_lahir, saldo, username, password) " +
                $"VALUES ('{konsumen.Nama}', '{konsumen.Email}', '{konsumen.NoHp}', '{konsumen.Gender}'" +
                $", '{konsumen.TglLahir.ToShortDateString()}', '{konsumen.Saldo}', '{konsumen.Username}', '{konsumen.Password}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD UPDATE U
        public static void UbahData(Konsumen konsumen)
        {
            string perintah = $"UPDATE konsumens SET nama='{konsumen.Nama}', email='{konsumen.Email}', no_hp='{konsumen.NoHp}'" +
                $", gender='{konsumen.Gender}', tgl_lahir='{konsumen.TglLahir.ToShortDateString()}', saldo='{konsumen.Saldo}'" +
                $", username='{konsumen.Username}', password='{konsumen.Password}' WHERE id='{konsumen.Id}'";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM konsumens WHERE id='{idHapus}';";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Konsumen> BacaData(string filter="", string nilai="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT id, nama, email, no_hp, gender, tgl_lahir, saldo, username FROM konsumens";
            }

            else
            {
                perintah = $"SELECT id, nama, email, no_hp, gender, tgl_lahir, saldo, username FROM konsumens WHERE {filter} like '%{nilai}%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Konsumen> listKonsumen = new List<Konsumen>();

            while (hasil.Read() == true)
            {
                Konsumen tampung = new Konsumen();

                tampung.Id = hasil.GetInt32(0);
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Email = hasil.GetValue(2).ToString();
                tampung.NoHp = hasil.GetValue(3).ToString();
                tampung.Gender = hasil.GetValue(4).ToString();
                tampung.TglLahir = (DateTime)hasil.GetValue(5);
                tampung.Saldo = double.Parse(hasil.GetValue(6).ToString());
                tampung.Username = hasil.GetValue(7).ToString();

                listKonsumen.Add(tampung);
            }

            return listKonsumen;
        }

        //! METHOD CEK LOGIN KONSUMEN
        public static Konsumen CekLogin(string username, string pswd)
        {
            string perintah = $"SELECT * FROM konsumens k WHERE k.username='{username}' and k.password = '{pswd}'";

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            if (hasil.Read() == true)
            {
                Konsumen tampung = new Konsumen();

                tampung.Id= int.Parse(hasil.GetValue(0).ToString());
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Email = hasil.GetValue(2).ToString();
                tampung.NoHp = hasil.GetValue(3).ToString();
                tampung.Gender = hasil.GetValue(5).ToString(); //password tidak boleh diakses oleh siapapun kecuali pemiliknya
                tampung.TglLahir = (DateTime)hasil.GetValue(5);
                tampung.Saldo = double.Parse(hasil.GetValue(6).ToString());
                tampung.Username = hasil.GetValue(7).ToString();
                tampung.Password = hasil.GetValue(8).ToString();

                return tampung;
            }

            else return null;
        }
        public override string ToString()
        {
            return Nama;
        }
        #endregion
    }
}
