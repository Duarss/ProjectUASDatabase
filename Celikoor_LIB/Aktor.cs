﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Aktor
    {
        #region FIELDS
        int id;
        string nama;
        DateTime tglLahir;
        string gender;
        string negaraAsal;
        #endregion

        #region CONSTRUCTORS
        public Aktor()
        {
            Id = 0;
            Nama = "";
            TglLahir = DateTime.Now;
            Gender = "";
            NegaraAsal = "";
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public string Gender { get => gender; set => gender = value; }
        public string NegaraAsal { get => negaraAsal; set => negaraAsal = value; }
        #endregion

        #region METHODS
        //! METHOD CREATE C
        public static void TambahData(Aktor aktor)
        {
            string perintah = $"INSERT INTO aktors (nama, tgl_lahir, gender, negara_asal) " +
                $"VALUES ('{aktor.Nama}', '{aktor.TglLahir.ToShortDateString()}', '{aktor.Gender}', '{aktor.NegaraAsal}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD UPDATE U
        public static void UbahData(Aktor aktor)
        {
            string perintah = $"UPDATE aktors SET nama='{aktor.Nama}', tgl_lahir='{aktor.TglLahir.ToShortDateString()}'" +
                $", gender='{aktor.Gender}', negara_asal='{aktor.NegaraAsal}');";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD DELETE D
        public static void HapusData(string idHapus)
        {
            string perintah = $"DELETE FROM aktors WHERE id='{idHapus}';";

            Koneksi.JalankanPerintahQuery(perintah);
        }

        //! METHOD RETRIEVE R dan FILTER F
        public static List<Aktor> BacaData(string id="", string nama ="")
        {
            string perintah;

            if (id == "")
            {
                perintah = $"SELECT * FROM aktors";
            }

            else
            {
                perintah = $"SELECT * FROM aktors WHERE {id} like '%{nama}%'";
            }

            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Aktor> listAktor = new List<Aktor>();

            while (hasil.Read() == true)
            {   
                Aktor tampung = new Aktor();

                tampung.Id = hasil.GetInt32(0);
                tampung.Nama = hasil.GetValue(1).ToString();
                tampung.TglLahir = (DateTime)hasil.GetValue(2);
                tampung.Gender = hasil.GetValue(3).ToString();
                tampung.NegaraAsal = hasil.GetValue(4).ToString();

                listAktor.Add(tampung);
            }
            //kirim list ke pemanggilnya
            return listAktor;
        }
        #endregion
    }
}
