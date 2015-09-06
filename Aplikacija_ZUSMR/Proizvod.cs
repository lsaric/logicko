using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class Proizvod
    {
        public int ID_proizvoda { get; set; }
        public string Naziv { get; set; }
        public int Cijena { get; set; }
        public int Kolicina{get; set;}
        public string NazivProizvodaca { get; set; }
        public string Tip { get; set; }
        public string NazivSkladista { get; set; }

        public static List<Proizvod> selectUpit(string upit, int tip)
        {
            List<Proizvod> proizvod = new List<Proizvod>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                Proizvod db = new Proizvod();
                db.ID_proizvoda = int.Parse(dr["ID_proizvoda"].ToString());
                db.Naziv = dr["Naziv"].ToString();
                db.Cijena = int.Parse(dr["Cijena"].ToString());
                db.Kolicina = int.Parse(dr["Kolicina"].ToString());
                if (tip == 1)
                {
                    db.NazivProizvodaca = dr["Skladiste"].ToString();
                    db.Tip = dr["Tip"].ToString();
                    db.NazivSkladista = dr["Proizvodac"].ToString();
                    
                }

                proizvod.Add(db);
               
            }
            dr.Close();

            return proizvod;

        }
    }
}
