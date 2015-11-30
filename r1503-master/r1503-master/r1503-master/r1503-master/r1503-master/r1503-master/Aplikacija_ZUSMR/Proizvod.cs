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
        public string JedinicaMjere { get; set; }

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
                //db.Kolicina = int.Parse(dr["Kolicina"].ToString());
                //db.Kolicina = izracunajKolicinuProizvoda(db.ID_proizvoda);
                db.Kolicina = 0;
                if (tip == 1)
                {
                    db.NazivProizvodaca = dr["Skladiste"].ToString();
                    db.Tip = dr["Tip"].ToString();
                    db.NazivSkladista = dr["Proizvodac"].ToString();
                    db.JedinicaMjere = dr["JedinicaMjere"].ToString();
                }

                proizvod.Add(db);
               
            }
            dr.Close();

            foreach (Proizvod a in proizvod)
            {
                a.Kolicina = izracunajKolicinuProizvoda(a.ID_proizvoda);
            }

            return proizvod;

        }

        private static int izracunajKolicinuProizvoda(int id)
        {
            int zaprimljenaKolicina;
            int otpremljenaKolicina;
            try
            {
                zaprimljenaKolicina = (int)(Baza.Instance.VrijednostUpita("Select SUM(Kolicina) as Kolicina from Stavke_dokumenta join Poslovni_dokumenti pd on Stavke_dokumenta.ID_dokumenta=pd.ID_dokumenta where Stavke_dokumenta.ID_proizvoda = "+id+" AND pd.ID_TipDokumenta = (Select ID_TipDokumenta from Tip_poslovnog_dokumenta WHERE Tip = 'Primka')"));
            }
            catch(Exception e){
                zaprimljenaKolicina = 0;
            }

            try
            {
                otpremljenaKolicina = (int)Baza.Instance.VrijednostUpita("Select SUM(Kolicina) as Kolicina from Stavke_dokumenta join Poslovni_dokumenti pd on Stavke_dokumenta.ID_dokumenta=pd.ID_dokumenta where Stavke_dokumenta.ID_proizvoda = "+id+" AND pd.ID_TipDokumenta = (Select ID_TipDokumenta from Tip_poslovnog_dokumenta WHERE Tip = 'Otpremnica')");
            }
            catch (Exception e)
            {
                otpremljenaKolicina = 0;
            }



            return (zaprimljenaKolicina - otpremljenaKolicina);
        }

    }
}
