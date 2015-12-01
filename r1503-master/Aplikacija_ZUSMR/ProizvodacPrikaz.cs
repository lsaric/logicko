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
    public partial class ProizvodacPrikaz : Form
    {
        DodajProizvodaca dPro = null;
        DodajProizvodaca dPro1 = null;
        public ProizvodacPrikaz()
        {
            InitializeComponent();
            dgvRefresh();
        }
        private void dgvRefresh()
        {
            if (this.dgvProizvodac.Rows.Count > 0)
            {
                this.dgvProizvodac.Rows.Clear();
            }
            string upit = "select * from Poslovni_entiteti WHERE ID_TipEntiteta = (Select ID_TipEntiteta from Tip_poslovnog_entiteta WHERE Tip = 'Proizvodac')";
            List<PoslovniEntiteti> proizvodac = PoslovniEntiteti.selectUpit(upit);

            foreach (PoslovniEntiteti a in proizvodac)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvProizvodac.Rows[0].Clone();
                row.Cells[0].Value = a.ID_PoslovnogEntiteta;
                row.Cells[1].Value = a.Naziv;
                row.Cells[2].Value = a.Kontakt;
                this.dgvProizvodac.Rows.Add(row);
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajProizvodaca novi = new DodajProizvodaca(1);
            novi.ShowDialog();
            dgvRefresh();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvProizvodac.SelectedRows.Count == 1)
            {

                dPro1 = new DodajProizvodaca(2);
                dPro1.txtID.Text = dgvProizvodac.SelectedRows[0].Cells[0].Value.ToString();
                dPro1.txtNaziv.Text = dgvProizvodac.SelectedRows[0].Cells[1].Value.ToString();
                dPro1.txtKontakt.Text = dgvProizvodac.SelectedRows[0].Cells[2].Value.ToString();
                dPro1.FormClosed += new FormClosedEventHandler(dPro_FormClosed);

                dPro1.ShowDialog();
            }
        }

        void dPro_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvRefresh();
        }//i

        private void btnObrisi_Click(object sender, EventArgs e)
        {
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            dgvRefresh();
        }
    }
}
