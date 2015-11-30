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
    public partial class Zaposlenici : Form
    {
        public Zaposlenici()
        {
            InitializeComponent();
            dgvRefresh();
        }

        private void dgvRefresh()
        {
            if (this.dgvZaposlenici.Rows.Count > 0)
            {
                this.dgvZaposlenici.Rows.Clear();
            }

            string upit = "select z.ID_zaposlenik as ID_zaposlenik, z.Ime as Ime, z.Prezime as Prezime, z.KorisnickoIme as KorisnickoIme, z.Lozinka as Lozinka, t.Opis as Opis, s.Naziv as Naziv from Zaposlenici z join Tip_zaposlenja t on z.ID_zaposlenja=t.ID_zaposlenja join Skladiste s on z.ID_skladista = s.ID_skaldista";
            List<Zaposlenik> zaposlenici = Zaposlenik.selectUpit(upit,2);

            foreach (Zaposlenik a in zaposlenici)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvZaposlenici.Rows[0].Clone();
                row.Cells[0].Value = a.ID_zaposlenik;
                row.Cells[1].Value = a.Ime;
                row.Cells[2].Value = a.Prezime;
                row.Cells[3].Value = a.KorisnickoIme;
                row.Cells[4].Value = a.Lozinka;
                row.Cells[5].Value = a.Opis;
                row.Cells[6].Value = a.Naziv;
                this.dgvZaposlenici.Rows.Add(row);
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            DodajZaposlenika dodaj = new DodajZaposlenika(1);
            dodaj.FormClosed += new FormClosedEventHandler(dodaj_FormClosed);
            dodaj.ShowDialog();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            dgvRefresh();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count == 1)
            {
                DodajZaposlenika dodaj = new DodajZaposlenika(2);

                dodaj.txtID.Text = dgvZaposlenici.SelectedRows[0].Cells[0].Value.ToString();
                dodaj.txtIme.Text = dgvZaposlenici.SelectedRows[0].Cells[1].Value.ToString();
                dodaj.txtPrezime.Text = dgvZaposlenici.SelectedRows[0].Cells[2].Value.ToString();
                dodaj.txtKorisnicko.Text = dgvZaposlenici.SelectedRows[0].Cells[3].Value.ToString();
                dodaj.txtLozinka.Text = dgvZaposlenici.SelectedRows[0].Cells[4].Value.ToString();

                dodaj.FormClosed += new FormClosedEventHandler(dodaj_FormClosed);
                dodaj.ShowDialog();
            }
        }

        void dodaj_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvRefresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvZaposlenici.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvZaposlenici.SelectedRows[0].Index;

                int rowID = int.Parse(dgvZaposlenici[0, selectedIndex].Value.ToString());

                string Obrisi = "DELETE FROM Zaposlenici WHERE ID_zaposlenik = " + rowID;
                Baza.Instance.IzvrsavanjeUpita(Obrisi);
                dgvRefresh();
            }
        }

        private void Zaposlenici_Load(object sender, EventArgs e)
        {

        }

    }
}
