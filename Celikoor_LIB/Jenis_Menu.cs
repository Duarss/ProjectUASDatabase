using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Jenis_Menu
    {
        private int id;
        private string nama;
        private string deskripsi;

        public Jenis_Menu()
        {
            Id = 0;
            Nama = "";
            Deskripsi = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }

        public static void TambahData(Jenis_Menu jM)
        {
            string perintah = $"INSERT INTO jenis_menu (nama, deskripsi) VALUES ('{jM.Nama}', '{jM.Deskripsi}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        public static void UbahData(Jenis_Menu jM)
        {
            string perintah = $"UPDATE jenis_menu SET nama='{jM.Nama}', deskripsi='{jM.Deskripsi}' WHERE id='{jM.Id}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM jenis_menu WHERE id='{idHapus}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        public static List<Jenis_Menu> BacaData(string filter="", string nilai="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM jenis_menu";
            }
            else if (filter == "id")
            {
                perintah = $"SELECT * FROM jenis_menu WHERE id = '{nilai}'";
            }
            else
            {
                perintah = $"SELECT * FROM jenis_menu WHERE {filter} like '%{nilai}%'";
            }

            List<Jenis_Menu> listJenisMenu = new List<Jenis_Menu>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Jenis_Menu tampung = new Jenis_Menu();
                tampung.Id = dr.GetInt32(0);
                tampung.Nama = dr.GetValue(1).ToString();
                tampung.Deskripsi = dr.GetValue(2).ToString();

                listJenisMenu.Add(tampung);
            }

            return listJenisMenu;
        }
    }
}
