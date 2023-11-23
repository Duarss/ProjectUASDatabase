using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Film
    {
        int id;
        string judul;
        string sinopsis;
        int tahun;
        int durasi;
        string bahasa;
        int is_sub_indo;
        string coverImage;
        double diskon;

        public Film()
        {

        }
        public Film(int id, string judul, string sinopsis, int tahun, int durasi, string bahasa, int is_sub_indo, string coverImage, double diskon)
        {
            Id = id;
            Judul = judul;
            Sinopsis = sinopsis;
            Tahun = tahun;
            Durasi = durasi;
            Bahasa = bahasa;
            Is_sub_indo = is_sub_indo;
            CoverImage = coverImage;
            Diskon = diskon;
        }

        public int Id { get => id; set => id = value; }
        public string Judul { get => judul; set => judul = value; }
        public string Sinopsis { get => sinopsis; set => sinopsis = value; }
        public int Tahun { get => tahun; set => tahun = value; }
        public int Durasi { get => durasi; set => durasi = value; }
        public string Bahasa { get => bahasa; set => bahasa = value; }
        public int Is_sub_indo { get => is_sub_indo; set => is_sub_indo = value; }
        public string CoverImage { get => coverImage; set => coverImage = value; }
        public double Diskon { get => diskon; set => diskon = value; }
    }
}
