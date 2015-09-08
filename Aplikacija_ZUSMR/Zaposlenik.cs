using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class Zaposlenik
    {


        public int ID_zaposlenik { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Opis { get; set; }
        public string Naziv { get; set; }

        public string PunoIme
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }

        public static List<Zaposlenik> selectUpit(string upit, int vrsta)
        {
            List<Zaposlenik> zaposlenici = new List<Zaposlenik>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                Zaposlenik db = new Zaposlenik();
                db.ID_zaposlenik = int.Parse(dr["ID_zaposlenik"].ToString());
                db.Ime = dr["Ime"].ToString();
                db.Prezime = dr["Prezime"].ToString();
                db.KorisnickoIme = dr["KorisnickoIme"].ToString();
                db.Lozinka = dr["Lozinka"].ToString();
                if (vrsta == 2)
                {
                    db.Opis = (dr["Opis"].ToString());
                    db.Naziv = (dr["Naziv"].ToString());
                }
                
                zaposlenici.Add(db);
            }
            dr.Close();

            return zaposlenici;

        }

    }
}
