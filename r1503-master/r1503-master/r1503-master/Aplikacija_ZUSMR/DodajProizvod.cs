using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_ZUSMR
{
    public partial class DodajProizvod : Form
    {
        private int U;
        private List<Proizvodac> proizvodac;
        private List<Tip_proizvoda> tip;
        private List<Skladiste> skladista;
        nmbOd dodajproizvod = null;
        public DodajProizvod(int U)
        {
            this.U = U;
            InitializeComponent();

            string upit = "select * from Proizvodac";
            proizvodac = Proizvodac.selectUpit(upit);
            this.cmbProizvodac.DataSource = proizvodac;
            this.cmbProizvodac.DisplayMember = "Naziv";
            this.cmbProizvodac.ValueMember = "ID_proizvodac";

            upit = "select * from Tip_proizvoda";
            tip = Tip_proizvoda.selectUpit(upit);
            this.cmbTip.DataSource = tip;
            this.cmbTip.DisplayMember = "Tip";
            this.cmbTip.ValueMember = "ID_tip";

            upit = "select * from Skladiste";
            skladista = Skladiste.selectUpit(upit);
            this.cmbSkladiste.DataSource = skladista;
            this.cmbSkladiste.DisplayMember = "Naziv";
            this.cmbSkladiste.ValueMember = "ID_skladista";
        }
        nmbOd nmb;
        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (U == 1)
            {
                string sqlUpit = "insert into Proizvod values ('" + txtNaziv.Text + "','" + txtCijena.Text + "','" + txtKolicina.Text + "'," + proizvodac.ElementAt((cmbProizvodac.SelectedIndex)).ID_proizvodac + "," + tip.ElementAt((cmbTip.SelectedIndex)).ID_tip + "," + skladista.ElementAt((cmbSkladiste.SelectedIndex)).ID_Skladista + ")";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2)
            {
                string upit = "UPDATE Proizvod SET Naziv = '" + txtNaziv.Text + "', Cijena = '" + txtCijena.Text + "', Kolicina= '" + txtKolicina.Text + "',ID_proizvodaca=" + proizvodac.ElementAt((cmbProizvodac.SelectedIndex)).ID_proizvodac + ",ID_tip=" + tip.ElementAt((cmbTip.SelectedIndex)).ID_tip +",ID_Skladista="+skladista.ElementAt((cmbSkladiste.SelectedIndex)).ID_Skladista +" WHERE  ID_proizvoda= " + int.Parse(txtID.Text.ToString());
                Baza.Instance.IzvrsavanjeUpita(upit);
                this.Close();
            }
           
            
            
        }
        
        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
