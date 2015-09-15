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
        private List<JedinicaMjere> jediniceMjere;
        public DodajSkladiste(int U)
        {
            this.U = U;
            InitializeComponent();
            if (U == 1)
            {
                string upit = "select * from Jedinice_Mjere";
                jediniceMjere = JedinicaMjere.selectUpit(upit);
                this.cmbJedinicaMjere.DataSource = jediniceMjere;
                this.cmbJedinicaMjere.DisplayMember = "JMNaziv";
                this.cmbJedinicaMjere.ValueMember = "ID_JediniceMjere";
            }

            else if (U == 2)
            {
                label1.Hide();
                cmbJedinicaMjere.Hide();
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            bool uneseno = true;
            if (txtKapacitet.Text.Length < 1 && txtNaziv.Text.Length < 1)
            {
                uneseno = false;
            }

            if (U == 1 && uneseno)
            {
                string sqlUpit = "insert into Skladiste values ('" + txtNaziv.Text + "'," + int.Parse(txtKapacitet.Text.ToString()) + ", "+ this.cmbJedinicaMjere.SelectedValue +")";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2 && uneseno)
            {
                string sqlUpit = "UPDATE Skladiste SET Naziv = '" + txtNaziv.Text + "',Kapacitet =" + int.Parse(txtKapacitet.Text.ToString()) +" WHERE  ID_skaldista = " + int.Parse(txtID.Text.ToString()) + "";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (!uneseno)
            {
                MessageBox.Show("Sva polja moraju imati više od jednog znaka!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
