﻿using System;
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
    public partial class nmbOd : Form
    {
        public nmbOd()
        {
            InitializeComponent();

            string upit = "select * from Proizvodac";
            List<Proizvodac> proizvodac = Proizvodac.selectUpit(upit);
            Proizvodac b = new Proizvodac();
            b.ID_proizvodac = 0;
            b.Naziv = "";
            proizvodac.Insert(0,b);
            this.cmbProizvodac.DataSource = proizvodac;
            this.cmbProizvodac.DisplayMember = "Naziv";
            this.cmbProizvodac.ValueMember = "ID_proizvodac";
            this.cmbProizvodac.SelectedIndex = 0;

            upit = "select * from Tip_proizvoda";
            List<Tip_proizvoda> tip = Tip_proizvoda.selectUpit(upit);
            Tip_proizvoda a = new Tip_proizvoda();
            a.ID_tip = 0;
            a.Tip = "";
            tip.Insert(0,a);
            this.cmbTip.DataSource = tip;
            this.cmbTip.DisplayMember = "Tip";
            this.cmbTip.ValueMember = "ID_tip";
            this.cmbTip.SelectedIndex = 0;

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
                row.Cells[4].Value = a.NazivProizvodaca; 
                row.Cells[5].Value = a.NazivSkladista;
                row.Cells[6].Value = a.Tip;
                this.dgvProizvodi.Rows.Add(row);
            }

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            DodajProizvod dProizvod = new DodajProizvod(1);
            dProizvod.FormClosed += new FormClosedEventHandler(dProizvod_FormClosed);
            dProizvod.ShowDialog();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (dgvProizvodi.SelectedRows.Count == 1)
            {
                DodajProizvod dProizvod = new DodajProizvod(2);

                dProizvod.txtID.Text = dgvProizvodi.SelectedRows[0].Cells[0].Value.ToString();
                dProizvod.txtNaziv.Text = dgvProizvodi.SelectedRows[0].Cells[1].Value.ToString();
                dProizvod.txtCijena.Text = dgvProizvodi.SelectedRows[0].Cells[2].Value.ToString();
                dProizvod.txtKolicina.Text = dgvProizvodi.SelectedRows[0].Cells[3].Value.ToString();

                dProizvod.FormClosed += new FormClosedEventHandler(dProizvod_FormClosed);
                dProizvod.ShowDialog();
            }
        }

        void dProizvod_FormClosed(object sender, FormClosedEventArgs e)
        {
            dgvRefresh();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            dgvRefresh();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            if (this.dgvProizvodi.Rows.Count > 0)
            {
                this.dgvProizvodi.Rows.Clear();

            }
            string naziv = "";
            int cijenaOd = 0;
            int cijenaDo = 1000000;
            string proizvodac = "";
            string tip = "";

            if (txtNaziv.Text != null)
            {
                naziv = txtNaziv.Text;
            }
            if (nmbOdC.Value != 0)
            {
                cijenaOd = (int)(nmbOdC.Value);
            }
            if (nmbDo.Value != 0)
            {
                cijenaDo = (int)(nmbDo.Value);
            }
            if ( (int)cmbProizvodac.SelectedValue != 0)
            {
                proizvodac = cmbProizvodac.SelectedValue.ToString();
            }
            if ((int)cmbTip.SelectedValue != 0)
            {
                tip = cmbTip.SelectedValue.ToString();
            }

            string upit = "select p.ID_proizvoda as ID_proizvoda, p.Naziv as Naziv, p.Cijena as Cijena, p.Kolicina as Kolicina, s.Naziv as Skladiste, t.Tip as Tip, pr.Naziv as Proizvodac from Proizvod p join Skladiste s on p.ID_skladista =s.ID_skaldista join Proizvodac pr on p.ID_proizvodaca = pr.ID_proizvodac join Tip_proizvoda t on p.ID_tip = t.ID_tip"
                + " Where (p.Cijena Between " + cijenaOd + " AND " + cijenaDo + ")" + "AND"
                + "(p.Naziv like '%" + naziv + "%')" + "AND"
                + "(p.ID_proizvodaca LIKE '%" + proizvodac + "%')" + "AND"
                + "(p.ID_tip LIKE '%"+tip+"%')";

            List<Proizvod> proizvodi = Proizvod.selectUpit(upit, 1);

            foreach (Proizvod a in proizvodi)
            {
                DataGridViewRow row = (DataGridViewRow)this.dgvProizvodi.Rows[0].Clone();
                row.Cells[0].Value = a.ID_proizvoda;
                row.Cells[1].Value = a.Naziv;
                row.Cells[2].Value = a.Cijena;
                row.Cells[3].Value = a.Kolicina;
                row.Cells[4].Value = a.NazivProizvodaca;
                row.Cells[5].Value = a.NazivSkladista;
                row.Cells[6].Value = a.Tip;
                this.dgvProizvodi.Rows.Add(row);
            }

        }
    }
}
