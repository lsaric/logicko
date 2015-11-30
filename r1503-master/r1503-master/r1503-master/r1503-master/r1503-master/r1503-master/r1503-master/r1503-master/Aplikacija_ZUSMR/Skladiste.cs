using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class Skladiste
    {
        public int ID_Skladista { get; set; }
        public string Naziv { get; set; }
        public int Kapacitet { get; set; }

        public static List<Skladiste> selectUpit(string upit)
        {
            List<Skladiste> skladiste = new List<Skladiste>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                Skladiste db = new Skladiste();
                db.ID_Skladista = int.Parse(dr["ID_skaldista"].ToString());
                db.Naziv = dr["Naziv"].ToString();
                db.Kapacitet = int.Parse(dr["Kapacitet"].ToString());
                skladiste.Add(db);
            }
            dr.Close();

            return skladiste;

        }
    }
}
