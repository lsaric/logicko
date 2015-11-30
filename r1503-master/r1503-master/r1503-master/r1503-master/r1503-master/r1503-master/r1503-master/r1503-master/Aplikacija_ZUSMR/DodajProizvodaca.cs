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
            if (U == 1)
            {
                string sqlUpit = "insert into Proizvodac values ('" + txtNaziv.Text + "')";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2)
            {
                string upit = "UPDATE Proizvodac SET  Naziv = '" + txtNaziv.Text + "' WHERE  ID_proizvodac = " + int.Parse(txtID.Text.ToString());
                Baza.Instance.IzvrsavanjeUpita(upit);
                this.Close();
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
