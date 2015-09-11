using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class Tip_proizvoda
    {

        public int ID_tip { get; set; }
        public string Tip { get; set; }

        public static List<Tip_proizvoda> selectUpit(string upit)
        {
            List<Tip_proizvoda> tipProizvoda = new List<Tip_proizvoda>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                Tip_proizvoda db = new Tip_proizvoda();
                db.ID_tip = int.Parse(dr["ID_tip"].ToString());
                db.Tip = dr["Tip"].ToString();
                tipProizvoda.Add(db);
            }
            dr.Close();

            return tipProizvoda;
        }
    }
}
