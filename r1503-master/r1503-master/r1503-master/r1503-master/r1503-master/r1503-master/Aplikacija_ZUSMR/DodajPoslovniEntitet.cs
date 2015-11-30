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
    public partial class DodajPoslovniEntitet : Form
    {
        private int U;
        private List<TipPoslovnogEntiteta> tpe;
        public DodajPoslovniEntitet(int U)
        {
            this.U = U;
            InitializeComponent();

            string upit = "select * from Tip_poslovnog_entiteta ";
            tpe = TipPoslovnogEntiteta.selectUpit(upit);
            this.cmbTipPoslovnogEntiteta.DataSource = tpe;
            this.cmbTipPoslovnogEntiteta.DisplayMember = "Tip";
            this.cmbTipPoslovnogEntiteta.ValueMember = "ID_TipEntiteta";
            if (U == 2)
            {
                //cmb locked
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            bool uneseno = true;
            if (txtKontakt.Text.Length < 2 || txtNaziv.Text.Length < 2)
            {
                uneseno = false;
            }

            if (U == 1 && uneseno)
            {
                string sqlUpit = "insert into Poslovni_entiteti values ('" + txtNaziv.Text + "','" + txtKontakt.Text + "'," + this.tpe.ElementAt((this.cmbTipPoslovnogEntiteta.SelectedIndex)).ID_TipEntiteta + ")";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2 && uneseno)
            {
                string upit = "UPDATE Poslovni_entiteti SET Naziv = '" + txtNaziv.Text + "', Kontakt = '" + txtKontakt.Text + "' WHERE  ID_PoslovnogEntiteta = " + int.Parse(txtID.Text.ToString());
                Baza.Instance.IzvrsavanjeUpita(upit);
                this.Close();
            }
            else if (!uneseno)
            {
                MessageBox.Show("Sva polja moraju biti popunjena!");
            }
           
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNaziv_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
