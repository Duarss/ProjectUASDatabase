using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Menus
    {
        private int id;
        private string nama;
        private Jenis_Menu jenisMenu;
        private double harga;

        public Menus()
        {
            Id = 0;
            Nama = "";
            JenisMenu = new Jenis_Menu();
            Harga = 0; ;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public Jenis_Menu JenisMenu { get => jenisMenu; set => jenisMenu = value; }
        public double Harga { get => harga; set => harga = value; }

        public static void TambahData(Menus menu)
        {
            string perintah = $"INSERT INTO menus (nama, jenis_menu, harga) VALUES ('{menu.Nama}', '{menu.JenisMenu.Id}', '{menu.Harga}');";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        public static void UbahData(Menus menu)
        {
            string perintah = $"UPDATE menus SET nama='{menu.Nama}', jenis_menu='{menu.JenisMenu.Id}', harga='{menu.Harga} WHERE id='{menu.Id}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM menus WHERE id='{idHapus}';";

            Koneksi conn = new Koneksi();
            conn.JalankanPerintahQuery(perintah);
            conn.KoneksiDB.Close();
        }

        public static List<Menus> BacaData(string filter="", string nilai="")
        {
            string perintah;

            if (filter == "")
            {
                perintah = $"SELECT * FROM menus";
            }
            
            else if (filter == "id")
            {
                perintah = $"SELECT * FROM menus WHERE id = '{nilai}'";
            }

            else
            {
                perintah = $"SELECT * FROM menus WHERE {filter} like '%{nilai}%'";
            }

            List<Menus> listMenu = new List<Menus>();
            Koneksi conn = new Koneksi();
            MySqlDataReader dr = conn.JalankanPerintahSelect(perintah);

            while (dr.Read() == true)
            {
                Menus tampung = new Menus();

                tampung.Id = dr.GetInt32(0);
                tampung.Nama = dr.GetValue(1).ToString();
                
                Jenis_Menu jM = new Jenis_Menu();
                jM.Id = dr.GetInt32(2);
                jM.Nama = dr.GetValue(3).ToString();

                tampung.JenisMenu = jM;
                tampung.Harga = double.Parse(dr.GetValue(4).ToString());

                listMenu.Add(tampung);
            }

            return listMenu;
        }
    }
}
