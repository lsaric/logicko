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
    public partial class KupciPrikaz : Form
    {
        public KupciPrikaz()
        {
            InitializeComponent();
            dgvRefresh();
        }

        private void dgvRefresh()
        {
            if (this.dgvKupci.Rows.Count > 0)
            {
                this.dgvKupci.Rows.Clear();
            }
            string upit = "Select * from Kupac";
            List<Kupac> kupci = Kupac.selectUpit(upit);

            foreach (Kupac a in kupci)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvKupci.Rows[0].Clone();
                row.Cells[0].Value = a.ID_kupca;
                row.Cells[1].Value = a.Kontakt;
                row.Cells[2].Value = a.Naziv;
                this.dgvKupci.Rows.Add(row);
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajKupca DodajKu = new DodajKupca(1);
            DodajKu.Show();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count == 1)
            {
                DodajKupca UrediKupca = new DodajKupca(2);

                UrediKupca.txtID.Text = dgvKupci.SelectedRows[0].Cells[0].Value.ToString();
                UrediKupca.txtKontakt.Text = dgvKupci.SelectedRows[0].Cells[1].Value.ToString();
                UrediKupca.txtNaziv.Text = dgvKupci.SelectedRows[0].Cells[2].Value.ToString();
                UrediKupca.Show();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvKupci.SelectedRows[0].Index;

                int rowID = int.Parse(dgvKupci[0, selectedIndex].Value.ToString());

                string Obrisi = "DELETE FROM Kupac WHERE ID_kupca = " + rowID;
                Baza.Instance.IzvrsavanjeUpita(Obrisi);
                dgvRefresh();
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            dgvRefresh();
        }
    }
}
