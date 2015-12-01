using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class TipPoslovnogEntiteta
    {

        public int ID_TipEntiteta { get; set; }
        public string Tip { get; set; }

        public static List<TipPoslovnogEntiteta> selectUpit(string upit)
        {
            List<TipPoslovnogEntiteta> tipPoslovnogEntiteta = new List<TipPoslovnogEntiteta>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                TipPoslovnogEntiteta db = new TipPoslovnogEntiteta();
                db.ID_TipEntiteta = int.Parse(dr["ID_TipEntiteta"].ToString());
                db.Tip = dr["Tip"].ToString();
                tipPoslovnogEntiteta.Add(db);
            }
            dr.Close();

            return tipPoslovnogEntiteta;
        }

    }
}
