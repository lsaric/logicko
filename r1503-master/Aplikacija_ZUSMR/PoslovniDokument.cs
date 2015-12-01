using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class PoslovniDokument
    {
        public int ID { get; set; }
        public string Datum { get; set; }
        public string Ime { get; set; }
        public string Kontakt { get; set; }
        public string Naziv { get; set; }
        
        public static List<PoslovniDokument> selectUpit(string upit)
        {
            List<PoslovniDokument> poslovniDokumenti = new List<PoslovniDokument>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                PoslovniDokument db = new PoslovniDokument();
                db.ID = int.Parse(dr["ID"].ToString());
                db.Datum = dr["Datum"].ToString();
                db.Ime = dr["Ime Prezime"].ToString();
                db.Kontakt = dr["Kontakt"].ToString();
                db.Naziv = dr["Naziv"].ToString();
                poslovniDokumenti.Add(db);
            }
            dr.Close();

            return poslovniDokumenti;
        }
    }
}
