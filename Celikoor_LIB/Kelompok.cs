﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Kelompok
    {
        #region FIELDS
        int id;
        string nama;
        #endregion

        #region CONSTRUCTORS
        public Kelompok()
        {
            Id = 0;
            Nama = "";
        }
        public Kelompok(int id, string nama)
        {
            Id = id;
            Nama = nama;
        }
        #endregion

        #region PROPERTIES
        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region METHODS
        public static void TambahData(Kelompok kelompok)
        {
            //susun perintah query
            string perintah = $"INSERT INTO kelompoks (id, nama) VALUES ('{kelompok.Id}', '{kelompok.Nama}');"; 

            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void HapusData(string idHapus)
        {
            //susun perintah query
            string perintah = $"DELETE FROM kelompoks WHERE id='{idHapus}';";

            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static List<Kelompok> BacaData(string id="", string nama="")
        {
            //susun perintah query
            string perintah;

            if (id == "")
            {
                perintah = $"SELECT * FROM kelompoks";
            }

            else
            {
                perintah = $"SELECT * FROM kelompoks WHERE '{id}' like '%{nama}%'";
            }

            //eksekusi perintah di atas
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);

            List<Kelompok> listKelompok = new List<Kelompok>();

            //selama masih ada data yang dapat dibaca dari datareader
            while (hasil.Read() == true)
            { 
                Kelompok tampung = new Kelompok();
                tampung.Id = int.Parse(hasil.GetValue(0).ToString()); //kolom pertama
                tampung.Nama = hasil.GetValue(1).ToString(); //kolom kedua

                listKelompok.Add(tampung);
            }

            return listKelompok;
        }
        #endregion
    }
}
