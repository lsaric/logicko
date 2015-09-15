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
    public partial class VoditeljSkladista : Form
    {
        SkladistaPrikaz skladista = null;
        Strojevi_i_Oprema_Prikaz strojevi = null;
        TipProizvodaPrikaz TipProizvodaPr = null;
        StatistikaNarudzbe statNarudzbe = null;
        nmbOd pr = null;
        public VoditeljSkladista()
        {
            InitializeComponent();
            this.statusPoruka.Text = "Dobrodošli " + Login.ime + " " + Login.prezime + " nalazite se na kontrolnoj ploči voditelja skladišta!";
        }
        SkladistaPrikaz skladiste;
        private void skladišteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (skladiste == null || skladiste.IsDisposed)
            {
                skladiste = new SkladistaPrikaz();
                skladiste.MdiParent = this;
                skladiste.Show();
                skladiste.Dock = DockStyle.Fill;
                skladiste.WindowState = FormWindowState.Maximized;


            }

            else
            {
                skladiste.Activate();
            }   
        }
        Strojevi_i_Oprema_Prikaz stroj;
        private void strojeviIOpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stroj == null || stroj.IsDisposed)
            {
                stroj = new Strojevi_i_Oprema_Prikaz();
                stroj.MdiParent = this;
                stroj.Show();
                stroj.Dock = DockStyle.Fill;
                stroj.WindowState = FormWindowState.Maximized;


            }

            else
            {
                stroj.Activate();
            }   
        }
        TipProizvodaPrikaz tip_proizvoda;
        private void tipProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (tip_proizvoda == null || tip_proizvoda.IsDisposed)
            {
                tip_proizvoda = new TipProizvodaPrikaz();
                tip_proizvoda.MdiParent = this;
                tip_proizvoda.Show();
                tip_proizvoda.Dock = DockStyle.Fill;
                tip_proizvoda.WindowState = FormWindowState.Maximized;


            }

            else
            {
                tip_proizvoda.Activate();
            }   

        }
        nmbOd nmb;
        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nmb == null || nmb.IsDisposed)
            {
                nmb = new nmbOd();
                nmb.MdiParent = this;
                nmb.Show();
                nmb.Dock = DockStyle.Fill;
                nmb.WindowState = FormWindowState.Maximized;


            }

            else
            {
                nmb.Activate();
            }   

        }
        ProdajaProizvodaGraf ppg;
        private void prikazStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ppg == null || ppg.IsDisposed)
            {
                ppg = new ProdajaProizvodaGraf();
                ppg.MdiParent = this;
                ppg.Show();
                ppg.Dock = DockStyle.Fill;
                ppg.WindowState = FormWindowState.Maximized;


            }

            else
            {
                ppg.Activate();
            }   
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        StatistikaNarudzbe stNarudzbe;
        private void statistikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stNarudzbe == null || stNarudzbe.IsDisposed)
            {
                stNarudzbe = new StatistikaNarudzbe();
                stNarudzbe.MdiParent = this;
                stNarudzbe.Show();
                stNarudzbe.Dock = DockStyle.Fill;
                stNarudzbe.WindowState = FormWindowState.Maximized;


            }

            else
            {
                stNarudzbe.Activate();
            }  
        }
    }
}
