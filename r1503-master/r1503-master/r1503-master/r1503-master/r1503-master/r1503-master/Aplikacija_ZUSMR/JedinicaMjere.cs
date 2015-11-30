using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class JedinicaMjere
    {
        public int ID_JediniceMjere { get; set; }
        public string JMNaziv { get; set; }

        public static List<JedinicaMjere> selectUpit(string upit)
        {
            List<JedinicaMjere> jediniceMjere = new List<JedinicaMjere>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                JedinicaMjere db = new JedinicaMjere();
                db.ID_JediniceMjere = int.Parse(dr["ID_JediniceMjere"].ToString());
                db.JMNaziv = dr["JedinicaMjere"].ToString();
                jediniceMjere.Add(db);
            }
            dr.Close();

            return jediniceMjere;
        }

    }
}
