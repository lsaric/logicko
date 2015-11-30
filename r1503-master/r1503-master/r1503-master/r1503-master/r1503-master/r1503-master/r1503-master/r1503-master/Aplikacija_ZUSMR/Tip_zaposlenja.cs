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
    public partial class Tip_zaposlenja : Form
    {
        public Tip_zaposlenja()
        {
            InitializeComponent();
            dgvRefresh();
        }

        private void dgvRefresh()
        {
            if (this.dgvTipZaposlenja.Rows.Count > 0)
            {
                this.dgvTipZaposlenja.Rows.Clear();
            }

            string upit = "select * from Tip_zaposlenja";
            List<TipZaposlenja> tip_zaposlenja = TipZaposlenja.selectUpit(upit);

            foreach (TipZaposlenja a in tip_zaposlenja)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvTipZaposlenja.Rows[0].Clone();
                row.Cells[0].Value = a.ID_zaposlenja;
                row.Cells[1].Value = a.Opis;
                this.dgvTipZaposlenja.Rows.Add(row);
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Dodaj_Tip_Zaposlenja Dodaj_tip = new Dodaj_Tip_Zaposlenja(1);
            Dodaj_tip.FormClosed += new FormClosedEventHandler(Dodaj_tip_FormClosed);
            Dodaj_tip.ShowDialog();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvTipZaposlenja.SelectedRows.Count == 1)
            {
                Dodaj_Tip_Zaposlenja Dodaj_tip = new Dodaj_Tip_Zaposlenja(2);

                Dodaj_tip.txtID.Text = dgvTipZaposlenja.SelectedRows[0].Cells[0].Value.ToString();
                Dodaj_tip.txtOpis.Text = dgvTipZaposlenja.SelectedRows[0].Cells[1].Value.ToString();

                Dodaj_tip.FormClosed += new FormClosedEventHandler(Dodaj_tip_FormClosed);
                Dodaj_tip.ShowDialog();
            }
        }

        void Dodaj_tip_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvRefresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (dgvTipZaposlenja.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvTipZaposlenja.SelectedRows[0].Index;

                int rowID = int.Parse(dgvTipZaposlenja[0, selectedIndex].Value.ToString());

                string Obrisi = "DELETE FROM Tip_zaposlenja WHERE ID_zaposlenja = " + rowID;
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
