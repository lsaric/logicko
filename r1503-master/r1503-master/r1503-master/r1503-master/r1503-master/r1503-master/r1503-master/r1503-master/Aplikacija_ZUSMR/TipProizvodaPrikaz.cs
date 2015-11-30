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
    public partial class TipProizvodaPrikaz : Form
    {
        public TipProizvodaPrikaz()
        {
            InitializeComponent();
            dgvRefresh();
        }

        private void dgvRefresh()
        {
            if (this.dgvTipProizvoda.Rows.Count > 0)
            {
                this.dgvTipProizvoda.Rows.Clear();
            }
            string upit = "Select * from Tip_proizvoda";
            List<Tip_proizvoda> tipProizvoda = Tip_proizvoda.selectUpit(upit);

            foreach (Tip_proizvoda a in tipProizvoda)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvTipProizvoda.Rows[0].Clone();
                row.Cells[0].Value = a.ID_tip;
                row.Cells[1].Value = a.Tip;
                this.dgvTipProizvoda.Rows.Add(row);
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajTipProizvoda DodajTipPr = new DodajTipProizvoda(1);
            DodajTipPr.FormClosed += new FormClosedEventHandler(DodajTipPr_FormClosed);
            DodajTipPr.ShowDialog();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvTipProizvoda.SelectedRows.Count == 1)
            {
                DodajTipProizvoda DodajTipPr = new DodajTipProizvoda(2);

                DodajTipPr.txtID.Text = dgvTipProizvoda.SelectedRows[0].Cells[0].Value.ToString();
                DodajTipPr.txtTip.Text = dgvTipProizvoda.SelectedRows[0].Cells[1].Value.ToString();

                DodajTipPr.FormClosed += new FormClosedEventHandler(DodajTipPr_FormClosed);
                DodajTipPr.ShowDialog();
            }
        }

        void DodajTipPr_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvRefresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvTipProizvoda.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTipProizvoda.SelectedRows[0].Index;

                int rowID = int.Parse(dgvTipProizvoda[0, selectedIndex].Value.ToString());

                string Obrisi = "DELETE FROM Tip_proizvoda WHERE ID_tip = " + rowID;
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
