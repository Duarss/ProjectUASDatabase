using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.

namespace Celikoor_LIB
{
    public class Koneksi
    {
        private MySqlConnection koneksiDB;

        public MySqlConnection KoneksiDB
        {
            get => koneksiDB; private set =>
                koneksiDB = value;
        }

        public Koneksi(string pS, string pD, string pU, string pP)
        {
            string conString =
                "Server= " + pS + ";Database= " + pD + ";Uid= " + pU + ";Pwd= " + pP;
            //"Server=localhost;Database=jualBeli;Uid=root;Pwd=;";
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = conString;
            KoneksiDB.Open();

            Connect();
        }

        public Koneksi()
        {
            Configuration myC = ConfigurationManager.OpenExeConfiguration
                (ConfigurationUserLevel.None);

            ConfigurationSectionGroup userSettings = myC.SectionGroups["userSettings"];

            var sectionSetting = userSettings.Sections["Celikoor_Tixycket.db"]
                as ClientSettingsSection;

            //ambil data dari file setting - sesuaikan dengan nama parameter di file setting Anda
            string vServer = sectionSetting.Settings.Get("dbServer").Value.ValueXml.InnerText;
            string vDb = sectionSetting.Settings.Get("dbName").Value.ValueXml.InnerText;
            string vUID = sectionSetting.Settings.Get("dbUsername").Value.ValueXml.InnerText;
            string vPWD = sectionSetting.Settings.Get("dbPassword").Value.ValueXml.InnerText;

            //akses ke app config sampai di sini
            //--------------------------------------------------------------------------------

            string conString =
                "Server= " + vServer + ";Database= " + vDb + ";Uid= " + vUID + ";Pwd= " + vPWD;
            //"Server=localhost;Database=jualBeli;Uid=root;Pwd=;";
            KoneksiDB = new MySqlConnection();
            KoneksiDB.ConnectionString = conString;
            KoneksiDB.Open();

            Connect();
        }

        public void Connect()
        {
            //Jika koneksi sedang terbuka, tutup dulu koneksi yang sedang aktif
            if (KoneksiDB.State == System.Data.ConnectionState.Open)
                KoneksiDB.Close();

            KoneksiDB.Open();
        }

        public static void JalankanPerintahQuery(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);
            cmd.ExecuteNonQuery(); //untuk insert update delete

        }

        public static MySqlDataReader JalankanPerintahSelect(string perintah)
        {
            Koneksi k = new Koneksi();
            MySqlCommand cmd = new MySqlCommand(perintah, k.KoneksiDB);
            MySqlDataReader dr = cmd.ExecuteReader(); //untuk insert update delete
            return dr;

        }
    }
}
