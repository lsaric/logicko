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
    public partial class DodajKupca : Form
    {
        private int U;
        nmbOd dodajkupca = null;
        public DodajKupca(int U)
        {
            this.U = U;
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (U == 1)
            {
                string sqlUpit = "insert into Kupac values ('" + txtKontakt.Text + "','" + txtNaziv.Text + "')";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2)
            {
                string upit = "UPDATE Kupac SET Kontakt = '" + txtKontakt.Text + "', Naziv = '" + txtNaziv.Text + "' WHERE  ID_kupca = " + int.Parse(txtID.Text.ToString());
                Baza.Instance.IzvrsavanjeUpita(upit);
                this.Close();
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
