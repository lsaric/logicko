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
    public partial class DodajZaposlenika : Form
    {

        private int U;
        private List<TipZaposlenja> Tip;
        private List<Skladiste> Skladista;
        public DodajZaposlenika()
        {
            InitializeComponent();
        }

        public DodajZaposlenika(int U)
        {
            this.U = U;
            
                InitializeComponent();
                string upit = "select * from Tip_zaposlenja";
                Tip = TipZaposlenja.selectUpit(upit);
                this.cmbTipZaposlenja.DataSource = Tip;
                this.cmbTipZaposlenja.DisplayMember = "Opis";
                this.cmbTipZaposlenja.ValueMember = "ID_zaposlenja";

                upit = "select * from Skladiste";
                Skladista = Skladiste.selectUpit(upit);
                this.cmbSkladiste.DataSource = Skladista;
                this.cmbSkladiste.DisplayMember = "Naziv";
                this.cmbSkladiste.ValueMember = "ID_Skladista";
            
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (U == 1)
            {
                string sqlUpit = "insert into Zaposlenici values ('" + txtIme.Text + "','" + txtPrezime.Text + "','" + txtKorisnicko.Text + "','" + txtLozinka.Text + "'," + Tip.ElementAt((cmbTipZaposlenja.SelectedIndex)).ID_zaposlenja + "," + Skladista.ElementAt((cmbSkladiste.SelectedIndex)).ID_Skladista+")";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2)
            {
                string upit = "UPDATE Zaposlenici SET Ime = '" + txtIme.Text + "', Prezime = '" + txtPrezime.Text + "', KorisnickoIme= '" + txtKorisnicko.Text + "',Lozinka='" + txtLozinka.Text + "',ID_zaposlenja=" + Tip.ElementAt((cmbTipZaposlenja.SelectedIndex)).ID_zaposlenja + ",ID_skladista=" + Skladista.ElementAt((cmbSkladiste.SelectedIndex)).ID_Skladista + " WHERE  ID_zaposlenik= " + int.Parse(txtID.Text.ToString());
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
