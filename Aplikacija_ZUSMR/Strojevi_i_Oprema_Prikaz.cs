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
    public partial class Strojevi_i_Oprema_Prikaz : Form
    {
        public Strojevi_i_Oprema_Prikaz()
        {
            InitializeComponent();
            dgvRefresh();
        }

        private void dgvRefresh()
        {
            if (this.dgvStrojevi.Rows.Count > 0)
            {
                this.dgvStrojevi.Rows.Clear();
            }

            string upit = "select s.ID_strojeva as ID, s.Tip as Tip, sk.Naziv as Naziv from Strojevi_i_oprema s join Skladiste sk on s.ID_skladista=sk.ID_skaldista";
            List<Strojevi_i_Oprema> strojevi = Strojevi_i_Oprema.selectUpit(upit);

            foreach (Strojevi_i_Oprema a in strojevi)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvStrojevi.Rows[0].Clone();
                row.Cells[0].Value = a.ID_strojeva;
                row.Cells[1].Value = a.Tip;
                row.Cells[2].Value = a.Naziv;
                this.dgvStrojevi.Rows.Add(row);
            }

        }



        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            dgvRefresh();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajStrojOpremu stroj = new DodajStrojOpremu(1);
            stroj.FormClosed += new FormClosedEventHandler(stroj_FormClosed);
            stroj.Show();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvStrojevi.SelectedRows.Count == 1)
            {
                DodajStrojOpremu stroj = new DodajStrojOpremu(2);

                stroj.txtID.Text = dgvStrojevi.SelectedRows[0].Cells[0].Value.ToString();
                stroj.txtTip.Text = dgvStrojevi.SelectedRows[0].Cells[1].Value.ToString();

                stroj.FormClosed += new FormClosedEventHandler(stroj_FormClosed);
                stroj.Show();
            }
        }

        void stroj_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvRefresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvStrojevi.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvStrojevi.SelectedRows[0].Index;

                int rowID = int.Parse(dgvStrojevi[0, selectedIndex].Value.ToString());

                string Obrisi = "DELETE FROM Strojevi_i_oprema WHERE ID_strojeva = " + rowID;
                Baza.Instance.IzvrsavanjeUpita(Obrisi);
                dgvRefresh();
            }
        }

    }
}
