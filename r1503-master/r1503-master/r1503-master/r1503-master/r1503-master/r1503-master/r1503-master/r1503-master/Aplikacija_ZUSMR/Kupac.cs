using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class Kupac
    {
        public int ID_kupca { get; set; }
        public string Kontakt { get; set; }
        public string Naziv { get; set; }

        public static List<Kupac> selectUpit(string upit)
        {
            List<Kupac> kupci = new List<Kupac>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                Kupac db = new Kupac();
                db.ID_kupca = int.Parse(dr["ID_kupca"].ToString());
                db.Kontakt = dr["Kontakt"].ToString();
                db.Naziv = dr["Naziv"].ToString();
                kupci.Add(db);
            }
            dr.Close();

            return kupci;
        }
    }
}
