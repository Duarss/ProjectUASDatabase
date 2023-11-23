using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Invoices
    {
        int id;
        DateTime tanggal;
        double grand_total;
        double diskon_nominal;
        Konsumen konsumen_id;
        Pegawai kasir_id;
        string status;
    }
}
