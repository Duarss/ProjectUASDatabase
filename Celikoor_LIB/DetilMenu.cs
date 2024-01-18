using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class DetilMenu
    {
        private string jenis_menu;
        private double harga;
        private string status_kirim;
        private Cinema cinema;
        private Pegawai pelayan;
        private Menus menu;
        private Invoices invoices;
        private int jumlah;

        public DetilMenu()
        {
            Jenis_menu = "";
            Harga = 0;
            Status_kirim = "0";
            Cinema = new Cinema();
            Pelayan = new Pegawai();
            Menu = new Menus();
            Invoices = new Invoices();
            Jumlah = 0;
        }

        public string Jenis_menu { get => jenis_menu; set => jenis_menu = value; }
        public double Harga { get => harga; set => harga = value; }
        public string Status_kirim { get => status_kirim; set => status_kirim = value; }
        public Cinema Cinema { get => cinema; set => cinema = value; }
        public Pegawai Pelayan { get => pelayan; set => pelayan = value; }
        public Menus Menu { get => menu; set => menu = value; }
        public Invoices Invoices { get => invoices; set => invoices = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
    }
}
