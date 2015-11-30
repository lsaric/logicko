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
    public partial class DodajProizvodaca : Form
    {

        private int U;
        public DodajProizvodaca(int U)
        {
            this.U = U;
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            bool uneseno = true;
            if (txtNaziv.Text.Length < 2)
            {
                uneseno = false;
            }
            if (U == 1 && uneseno)
            {
                string sqlUpit = "insert into Poslovni_entiteti values ('" + txtNaziv.Text + "','" + txtKontakt.Text + "',(Select ID_TipEntiteta from Tip_poslovnog_entiteta WHERE Tip = 'Proizvodac'))";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2 && uneseno)
            {
                string upit = "UPDATE Poslovni_entiteti SET  Naziv = '" + txtNaziv.Text + "', Kontakt = '" + txtKontakt.Text + "' WHERE  ID_PoslovnogEntiteta = " + int.Parse(txtID.Text.ToString());
                Baza.Instance.IzvrsavanjeUpita(upit);
                this.Close();
            }
            else if (!uneseno)
            {
                MessageBox.Show("Naziv proizvodaca treba biti dulji od jednog znaka!");
            }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajProizvodaca_Load(object sender, EventArgs e)
        {

        }
    }
}
