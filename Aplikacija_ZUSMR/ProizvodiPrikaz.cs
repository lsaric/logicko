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
    public partial class ProizvodiPrikaz : Form
    {
        public ProizvodiPrikaz()
        {
            InitializeComponent();
            dgvRefresh();
        }
        private void dgvRefresh()
        {
            if (this.dgvProizvodi.Rows.Count > 0)
            {
                this.dgvProizvodi.Rows.Clear();
               
            }

            string upit = "select p.ID_proizvoda as ID_proizvoda, p.Naziv as Naziv, p.Cijena as Cijena, p.Kolicina as Kolicina, s.Naziv as Skladiste, t.Tip as Tip, pr.Naziv as Proizvodac from Proizvod p join Skladiste s on p.ID_skladista =s.ID_skaldista join Proizvodac pr on p.ID_proizvodaca = pr.ID_proizvodac join Tip_proizvoda t on p.ID_tip = t.ID_tip";
            List<Proizvod> proizvodi = Proizvod.selectUpit(upit, 1);

            foreach (Proizvod a in proizvodi)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvProizvodi.Rows[0].Clone();
                row.Cells[0].Value = a.ID_proizvoda;
                row.Cells[1].Value = a.Naziv;
                row.Cells[2].Value = a.Cijena;
                row.Cells[3].Value = a.Kolicina;
                row.Cells[4].Value = a.NazivSkladista;
                row.Cells[5].Value = a.NazivProizvodaca;
                row.Cells[6].Value = a.Tip;
                this.dgvProizvodi.Rows.Add(row);
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajProizvod dodajProizvod = new DodajProizvod(1);
            dodajProizvod.Show();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvProizvodi.SelectedRows.Count == 1)
            {
                DodajProizvod urediProizvod = new DodajProizvod(2);

                urediProizvod.txtID.Text = dgvProizvodi.SelectedRows[0].Cells[0].Value.ToString();
                urediProizvod.txtNaziv.Text = dgvProizvodi.SelectedRows[0].Cells[1].Value.ToString();
                urediProizvod.txtCijena.Text = dgvProizvodi.SelectedRows[0].Cells[2].Value.ToString();
                urediProizvod.txtKolicina.Text = dgvProizvodi.SelectedRows[0].Cells[3].Value.ToString();

                urediProizvod.Show();
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            dgvRefresh();
        }
    }
}
