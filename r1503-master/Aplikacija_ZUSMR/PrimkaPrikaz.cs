using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_ZUSMR
{
    public partial class PrimkaPrikaz : Form
    {
        public PrimkaPrikaz()
        {
            InitializeComponent();
            dgvRefresh();
        }

        private void dgvRefresh()
        {
            if (this.dgvNarudzbenica.Rows.Count > 0)
            {
                this.dgvNarudzbenica.Rows.Clear();
            }

            string upit = "select p.ID_dokumenta as ID, p.Datum as Datum,pe.Kontakt as Kontakt,pe.Naziv as Naziv, z.Ime+z.Prezime as 'Ime Prezime' from Poslovni_dokumenti p join Zaposlenici z on p.ID_zaposlenik = z.ID_zaposlenik join Poslovni_entiteti as pe on p.ID_PoslovnogEntiteta = pe.ID_PoslovnogEntiteta WHERE p.ID_TipDokumenta = (Select ID_TipDokumenta from Tip_poslovnog_dokumenta where Tip = 'Primka')";
            List<PoslovniDokument> primke = PoslovniDokument.selectUpit(upit);

            foreach (PoslovniDokument a in primke)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvNarudzbenica.Rows[0].Clone();
                row.Cells[0].Value = a.ID;
                row.Cells[1].Value = a.Naziv;
                row.Cells[2].Value = a.Kontakt;
                row.Cells[3].Value = a.Datum;
                row.Cells[4].Value = a.Ime;
                this.dgvNarudzbenica.Rows.Add(row);
            }

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvNarudzbenica.SelectedRows.Count == 1)
            {
                DodajPrimku DodajNar = new DodajPrimku(2);

                DodajNar.txtID.Text = dgvNarudzbenica.SelectedRows[0].Cells[0].Value.ToString();
                DodajNar.FormClosed += new FormClosedEventHandler(DodajNar_FormClosed);
                DodajNar.ShowDialog();
            }
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajPrimku DodajNar = new DodajPrimku(1);
            DodajNar.FormClosed += new FormClosedEventHandler(DodajNar_FormClosed);
            DodajNar.ShowDialog();
            
        }

        void DodajNar_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvRefresh();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            
        }

        private void NarudzbenicaPrikaz_Load(object sender, EventArgs e)
        {

        }

        private void btnOsvjezi_Click_1(object sender, EventArgs e)
        {
            dgvRefresh();
        }
    }
}
