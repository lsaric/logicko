using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacija_ZUSMR
{
    class TipZaposlenja
    {

        public int ID_zaposlenja { get; set; }
        public string Opis { get; set; }

        public static List<TipZaposlenja> selectUpit(string upit)
        {
            List<TipZaposlenja> TipZaposlenja = new List<TipZaposlenja>();
            DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
            while (dr.Read())
            {
                TipZaposlenja db = new TipZaposlenja();
                db.ID_zaposlenja = int.Parse(dr["ID_zaposlenja"].ToString());
                db.Opis = dr["Opis"].ToString();
                TipZaposlenja.Add(db);
            }
            dr.Close();

            return TipZaposlenja;

        }

    }
}
