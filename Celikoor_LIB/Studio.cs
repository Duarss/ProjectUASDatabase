using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Celikoor_LIB
{
    public class Studio
    {
        int id;
        string nama;
        int kapasitas;
        Jenis_Studio jenisStudio;
        Cinema cinema;
        int harga_weekday;
        int harga_weekend;

        public Studio()
        {
            Id = 0;
            Nama = "";
            Kapasitas = 0;
            JenisStudio = new Jenis_Studio();
            Cinema = new Cinema();
            Harga_weekday = 0;
            Harga_weekend = 0;
        }

        public Studio(int id, string nama, int kapasitas, Jenis_Studio jenisStudio, Cinema cinema, int harga_weekday, int harga_weekend)
        {
            Id = id;
            Nama = nama;
            Kapasitas = kapasitas;
            JenisStudio = jenisStudio;
            Cinema = cinema;
            Harga_weekday = harga_weekday;
            Harga_weekend = harga_weekend;
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public int Kapasitas { get => kapasitas; set => kapasitas = value; }
        public Jenis_Studio JenisStudio { get => jenisStudio; set => jenisStudio = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }
        public int Harga_weekday { get => harga_weekday; set => harga_weekday = value; }
        public int Harga_weekend { get => harga_weekend; set => harga_weekend = value; }

        //! METHOD CREATE C
        public static void TambahData(Studio studio)
        {
            string perintah = $"INSERT INTO studios (id, nama, kapasitas, jenis_studios_id, cinemas_id, harga_weekday, harga_weekend)" +
                $"VALUES ('{studio.Id}', '{studio.Nama}', '{studio.Kapasitas}', '{studio.JenisStudio.Nama}', '{studio.Cinema.Nama_cabang}'" +
                $", '{studio.Harga_weekday}', '{studio.Harga_weekend}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD UPDATE U
        public static void UbahData(Studio studio)
        {
            string perintah = $"UPDATE studios SET nama='{studio.Nama}', kapasitas='{studio.Kapasitas}'" +
                $", jenis_studio_id='{studio.JenisStudio.Nama}', cinemas_id='{studio.Cinema.Nama_cabang}'" +
                $", harga_weekday='{studio.Harga_weekday}', harga_weekend='{studio.Harga_weekend}' WHERE id='{studio.Id}';";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD DELETE D
        public static void HapusData(int idHapus)
        {
            string perintah = $"DELETE FROM studios WHERE id='{idHapus}';";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        public static List<Studio> BacaData(string id="", string nama="")
        {
            string perintah;

            if (id == "")
            {
                perintah = $"SELECT * FROM studios";
            }

            else
            {
                perintah = $"SELECT * FROM studios WHERE '{id}' like '%{nama}%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Studio> listStudio = new List<Studio>();

            //selama masih ada data yang dapat dibaca dari datareader
            while (hasil.Read() == true)
            {   
                Studio tampung = new Studio();

                tampung.Id = hasil.GetInt32(0);
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.Kapasitas = int.Parse(hasil.GetValue(2).ToString());
                Jenis_Studio tampungJenisStudio = new Jenis_Studio();
                tampungJenisStudio.Id = hasil.GetInt32(3);
                Cinema tampungCinema = new Cinema();
                tampungCinema.Id = hasil.GetInt32(4);
                tampung.Harga_weekday = int.Parse(hasil.GetValue(5).ToString());
                tampung.Harga_weekend = int.Parse(hasil.GetValue(6).ToString());
                tampungJenisStudio.Nama = hasil.GetValue(7).ToString();
                tampungCinema.Nama_cabang = hasil.GetValue(8).ToString();

                tampung.JenisStudio = tampungJenisStudio;
                tampung.Cinema = tampungCinema;

                listStudio.Add(tampung);
            }

            return listStudio;
        }
    }
}
