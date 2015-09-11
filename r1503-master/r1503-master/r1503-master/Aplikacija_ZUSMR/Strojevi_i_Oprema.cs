using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class Strojevi_i_Oprema
    {
        public int ID_strojeva { get; set; }
        public string Tip { get; set; }
        public string Naziv { get; set; }

        public static List<Strojevi_i_Oprema> selectUpit(string upit)
        {
            List<Strojevi_i_Oprema> strojevi = new List<Strojevi_i_Oprema>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                Strojevi_i_Oprema db = new Strojevi_i_Oprema();
                db.ID_strojeva = int.Parse(dr["ID"].ToString());
                db.Tip = dr["Tip"].ToString();
                db.Naziv = dr["Naziv"].ToString();
                strojevi.Add(db);
            }
            dr.Close();

            return strojevi;

        }
    }
}
