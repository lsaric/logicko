using System.Collections.Generic;
using System.Data.Common;

namespace Aplikacija_ZUSMR
{
    class PoslovniEntiteti
    {
        public int ID_PoslovnogEntiteta { get; set; }
        public string Kontakt { get; set; }
        public string Naziv { get; set; }
        public int ID_tip { get; set; }

        public static List<PoslovniEntiteti> selectUpit(string upit)
        {
            List<PoslovniEntiteti> kupci = new List<PoslovniEntiteti>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                PoslovniEntiteti db = new PoslovniEntiteti();
                db.ID_PoslovnogEntiteta = int.Parse(dr["ID_PoslovnogEntiteta"].ToString());
                db.Kontakt = dr["Kontakt"].ToString();
                db.Naziv = dr["Naziv"].ToString();
                db.ID_tip = int.Parse(dr["ID_TipEntiteta"].ToString());
                kupci.Add(db);
            }
            dr.Close();

            return kupci;
        }

        //public object ID_entiteta { get; set; }
    }
}
