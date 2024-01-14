using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Aktor_film
    {
        #region FIELDS
        private Aktor aktor;
        private string peran;
        #endregion

        #region CONSTRUCTORS
        public Aktor_film()
        {
            Aktor = new Aktor();
            Peran = "";
        }
        #endregion

        #region PROPERTIES
        public Aktor Aktor { get => aktor; set => aktor = value; }
        public string Peran { get => peran; set => peran = value; }
        #endregion
    }
}
