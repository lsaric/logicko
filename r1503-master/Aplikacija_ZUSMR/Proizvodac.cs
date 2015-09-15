using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class Proizvodac
    {
        public int ID_proizvodac { get; set; }
        public string Naziv { get; set; }

        public static List<Proizvodac> selectUpit(string upit)
        {
            List<Proizvodac> proizvodac = new List<Proizvodac>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())

            {
                Proizvodac db = new Proizvodac();
                db.ID_proizvodac = int.Parse(dr["ID_proizvodac"].ToString());
                db.Naziv = dr["Naziv"].ToString();
                proizvodac.Add(db);
            }
            dr.Close();

            return proizvodac;
        }

    }
}
