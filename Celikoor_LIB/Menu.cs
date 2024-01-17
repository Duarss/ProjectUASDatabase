using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Menu
    {
        private int id;
        private string nama;
        private Jenis_Menu jenisMenu;
        private double harga;

        public Menu()
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
    }
}
