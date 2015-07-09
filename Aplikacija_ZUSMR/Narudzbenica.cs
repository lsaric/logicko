using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class Narudzbenica
    {
        public int ID_narudzbenice { get; set; }
        public string Datum { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        //lipo ti makni uredi i eto ga rjesen problem. bogati. a s
        public static List<Narudzbenica> selectUpit(string upit)
        {
            List<Narudzbenica> narudzbenica = new List<Narudzbenica>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                Narudzbenica db = new Narudzbenica();
                db.ID_narudzbenice = int.Parse(dr["ID_narudzbenice"].ToString());
                db.Datum = dr["Datum"].ToString();
                db.Ime = dr["Ime Prezime"].ToString();
                //db.Prezime = dr["Prezime"].ToString();
                //triba mi i ime i prezime od istog lika u cmb, da ne stavljan ime od jednog a prezime od drugog
                narudzbenica.Add(db);
            }
            dr.Close();

            return narudzbenica;
        }
    }
}
