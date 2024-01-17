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

        public Jenis_Menu()
        {
            Id = 0;
            Nama = "";
        }

        public int Id { get => id; set => id = value; }
        public string Nama { get => nama; set => nama = value; }
    }
}
