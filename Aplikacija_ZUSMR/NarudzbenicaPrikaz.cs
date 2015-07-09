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
    public partial class NarudzbenicaPrikaz : Form
    {
        public NarudzbenicaPrikaz()
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

            string upit = "select n.ID_narudzbenice as ID_narudzbenice, n.Datum as Datum, z.Ime+z.Prezime as 'Ime Prezime' from Narudzbenica n join Zaposlenici z on n.ID_zaposlenik = z.ID_zaposlenik";
            List<Narudzbenica> narudzbenica = Narudzbenica.selectUpit(upit);

            foreach (Narudzbenica a in narudzbenica)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvNarudzbenica.Rows[0].Clone();
                row.Cells[0].Value = a.ID_narudzbenice;
                row.Cells[1].Value = a.Datum;
                row.Cells[2].Value = a.Ime;
                this.dgvNarudzbenica.Rows.Add(row);
            }

        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvNarudzbenica.SelectedRows.Count == 1)
            {
                DodajNarudzbenicu UrediNarudzbenicu = new DodajNarudzbenicu(2);

                UrediNarudzbenicu.txtID.Text = dgvNarudzbenica.SelectedRows[0].Cells[0].Value.ToString();
                //UrediNarudzbenicu.dateTimePicker1.Value = dgvNarudzbenica.SelectedRows[0].Cells[1].Value;
                /*
                DateTime myDate = DateTime.ParseExact(dgvNarudzbenica.SelectedRows[0].Cells[1].Value.ToString(), "yyyy-MM-dd hh:mm:ss.mmm",
                                       System.Globalization.CultureInfo.InvariantCulture);

                UrediNarudzbenicu.dateTimePicker1.Value = DateTime.ParseExact(
    myDate.ToString(),
    "yyyy-MM-dd hh:mm:ss.mmm",
    CultureInfo.InvariantCulture);
                */ 
                UrediNarudzbenicu.Show();
            }
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajNarudzbenicu DodajNar = new DodajNarudzbenicu(1);
            DodajNar.Show();
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            dgvRefresh();
        }
    }
}
