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
    public partial class DodajSkladiste : Form
    {
        private int U;
        public DodajSkladiste(int U)
        {
            this.U = U;
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {

            if (U == 1)
            {
                string sqlUpit = "insert into Skladiste values ('" + txtNaziv.Text + "'," + int.Parse(txtKapacitet.Text.ToString()) + ")";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2)
            {
                string sqlUpit = "UPDATE Skladiste SET Naziv = '" + txtNaziv.Text + "',Kapacitet =" + int.Parse(txtKapacitet.Text.ToString()) +" WHERE  ID_skaldista = " + int.Parse(txtID.Text.ToString()) + "";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
