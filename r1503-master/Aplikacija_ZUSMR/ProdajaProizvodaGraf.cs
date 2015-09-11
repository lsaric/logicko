using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_ZUSMR
{
    public partial class ProdajaProizvodaGraf : Form
    {

        private int[] Data { get; set; }
        private int PreviousState { get; set; }
        private int proizvodID { get; set; }
        private int MAX = 10; //varijabla koliko ce biti vidljivo na grafu
        private List<Proizvod> proizvodi;

        internal class listaIntova
        {

            public int Kolicina { get; set; }

            public static List<listaIntova> selectUpit(string upit)
            {
                List<listaIntova> lista = new List<listaIntova>();
                DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
                while (dr.Read())
                {
                    listaIntova db = new listaIntova();
                    if (DBNull.Value != dr["Kolicina"])
                    {
                        db.Kolicina = int.Parse(dr["Kolicina"].ToString());
                    }
                    else
                    {
                        db.Kolicina = 0;
                    }

                    lista.Add(db);
                }
                dr.Close();

                return lista;

            }

        } //interna klasa

        public ProdajaProizvodaGraf()
        {
            InitializeComponent();

            string upit = "select * from Proizvod";
            proizvodi = Proizvod.selectUpit(upit, 0);
            this.cmbProizvodi.DataSource = proizvodi;
            this.cmbProizvodi.DisplayMember = "Naziv";
            this.cmbProizvodi.ValueMember = "ID_proizvoda";
        }

        private void ProdajaProizvodaGraf_Load(object sender, EventArgs e)
        {

        }

        private void btnOdaberi_Click(object sender, EventArgs e)
        {
            
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (cmbProizvodi.SelectedValue != null)
            {

                proizvodID = (int)cmbProizvodi.SelectedValue;
                PreviousState = 0;
                timer1.Stop();
                graf.Data = null;
                Data = null;

                string upit = "Select Kolicina from Proizvod_Racun where ID_proizvoda = " + proizvodID + " ORDER BY ID_racuna";
                List<listaIntova> lista = listaIntova.selectUpit(upit);

                Data = new int[lista.Count];

                for (int i = 0; i < lista.Count; i++)
                {
                    Data[i] = (int)lista[i].Kolicina;

                }
                graf.Data = Data;
                PreviousState = 0;

                timer1.Interval = 2000;
                timer1.Start();
            }
            

                //iznad je bilo u odaberi

                

            

            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int[] data;
            if (Data.Length < MAX)
            {
                data = new int[Data.Length];
                for (int i = 0; i < Data.Length; i++)
                {
                    data[i] = Data[i + PreviousState];

                }

            }
            else
            {
                data = new int[MAX];

                for (int i = 0; i < MAX; i++)
                {
                    data[i] = Data[i + PreviousState];

                }
            }
            
            
            if (PreviousState >= Data.Length - MAX) timer1.Stop();
            
            PreviousState++;

            graf.Data = data;
            graf.Invalidate();
        }
    }
}
