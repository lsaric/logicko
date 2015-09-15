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
            string upit = "Select * from Proizvodac";
            List<Proizvodac> proizvodac = Proizvodac.selectUpit(upit);

            foreach (Proizvodac a in proizvodac)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvProizvodac.Rows[0].Clone();
                row.Cells[0].Value = a.ID_proizvodac;
                row.Cells[1].Value = a.Naziv;
                this.dgvProizvodac.Rows.Add(row);
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
           /* if (dPro == null || dPro.IsDisposed)
            {   
                dPro.FormClosed += new FormClosedEventHandler(dPro_FormClosed);
            }
            
            dPro.ShowDialog();
            */
            DodajProizvodaca novi = new DodajProizvodaca(1);
            novi.ShowDialog();
            dgvRefresh();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvProizvodac.SelectedRows.Count == 1)
            {
               // if (dPro1 == null || dPro1.IsDisposed)
                //{
                    dPro1 = new DodajProizvodaca(2);
                    
                //}
                dPro1.txtID.Text = dgvProizvodac.SelectedRows[0].Cells[0].Value.ToString();
                dPro1.txtNaziv.Text = dgvProizvodac.SelectedRows[0].Cells[1].Value.ToString();

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
            if (dgvProizvodac.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvProizvodac.SelectedRows[0].Index;

                int rowID = int.Parse(dgvProizvodac[0, selectedIndex].Value.ToString());

                string Obrisi = "DELETE FROM Proizvodac WHERE ID_proizvodac = " + rowID;
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
