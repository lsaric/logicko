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
    public partial class SkladistaPrikaz : Form
    {
        
        public SkladistaPrikaz()
        {
            InitializeComponent();
            dgvRefresh();
        }
        private void dgvRefresh()
        {
            if (this.dgvSkladista.Rows.Count > 0)
            {
                this.dgvSkladista.Rows.Clear();
            }
            string upit = "Select * from Skladiste";
            List<Skladiste> skladiste = Skladiste.selectUpit(upit);

            foreach (Skladiste a in skladiste)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvSkladista.Rows[0].Clone();
                row.Cells[0].Value = a.ID_Skladista;
                row.Cells[1].Value = a.Naziv;
                row.Cells[2].Value = a.Kapacitet;
                this.dgvSkladista.Rows.Add(row);
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
           DodajSkladiste prikaz = new DodajSkladiste(1);
           prikaz.FormClosed += new FormClosedEventHandler(prikaz_FormClosed);
           prikaz.Show();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
          if (dgvSkladista.SelectedRows.Count == 1)
            {
                DodajSkladiste prikaz = new DodajSkladiste(2);

                prikaz.txtID.Text = dgvSkladista.SelectedRows[0].Cells[0].Value.ToString();
                prikaz.txtNaziv.Text = dgvSkladista.SelectedRows[0].Cells[1].Value.ToString();
                prikaz.txtKapacitet.Text = dgvSkladista.SelectedRows[0].Cells[2].Value.ToString();

                prikaz.FormClosed += new FormClosedEventHandler(prikaz_FormClosed);
                prikaz.Show();
            }
        }

        void prikaz_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvRefresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvSkladista.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvSkladista.SelectedRows[0].Index;

                int rowID = int.Parse(dgvSkladista[0, selectedIndex].Value.ToString());

                string Obrisi = "DELETE FROM Skladiste WHERE ID_skaldista = " + rowID;
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
