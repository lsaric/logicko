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
    public partial class PoslovniEntitetiPrikaz : Form
    {
        public PoslovniEntitetiPrikaz()
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
            string upit = "Select * from Poslovni_entiteti";
            List<PoslovniEntiteti> PE = PoslovniEntiteti.selectUpit(upit);

            foreach (PoslovniEntiteti a in PE)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvKupci.Rows[0].Clone();
                row.Cells[0].Value = a.ID_PoslovnogEntiteta;
                row.Cells[1].Value = a.Naziv;
                row.Cells[2].Value = a.Kontakt;
                row.Cells[3].Value = Baza.Instance.VrijednostUpita("Select Tip from Tip_poslovnog_entiteta where ID_TipEntiteta = "+a.ID_tip).ToString();
                this.dgvKupci.Rows.Add(row);
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajPoslovniEntitet dKu = new DodajPoslovniEntitet(1);
           // dKu.FormClosed += new FormClosedEventHandler(dKu_FormClosed);
            dKu.ShowDialog();
            dgvRefresh();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count == 1)
            {
                DodajPoslovniEntitet dKu = new DodajPoslovniEntitet(2);

                dKu.txtID.Text = dgvKupci.SelectedRows[0].Cells[0].Value.ToString();
                dKu.txtKontakt.Text = dgvKupci.SelectedRows[0].Cells[2].Value.ToString();
                dKu.txtNaziv.Text = dgvKupci.SelectedRows[0].Cells[1].Value.ToString();

                dKu.FormClosed += new FormClosedEventHandler(dKu_FormClosed);
                dKu.ShowDialog();
                dgvRefresh();
            }
        }

        void dKu_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvRefresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvKupci.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvKupci.SelectedRows[0].Index;

                int rowID = int.Parse(dgvKupci[0, selectedIndex].Value.ToString());

                string Obrisi = "DELETE FROM Poslovni_entiteti WHERE ID_entiteta = " + rowID;
                Baza.Instance.IzvrsavanjeUpita(Obrisi);
                dgvRefresh();
            }
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            dgvRefresh();
        }

        private void KupciPrikaz_Load(object sender, EventArgs e)
        {
            
        }
    }
}
