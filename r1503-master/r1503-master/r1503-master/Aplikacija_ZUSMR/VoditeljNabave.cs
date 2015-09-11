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
    public partial class VoditeljNabave : Form
    {
        ProizvodacPrikaz proizvodacPrikaz = null;
        NarudzbenicaPrikaz narudzbenicaPrikaz = null;
        nmbOd proizvodprikaz = null;
        public VoditeljNabave()
        {
            InitializeComponent();
            this.statusPoruka.Text = "Dobrodošli " + Login.ime + " " + Login.prezime + " nalazite se na kontrolnoj ploči voditelja nabave!";
        }
        ProizvodacPrikaz proizvodjac;
        private void proizvodacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proizvodjac == null || proizvodjac.IsDisposed)
            {
                proizvodjac = new ProizvodacPrikaz();
                proizvodjac.MdiParent = this;
                proizvodjac.Show();
                proizvodjac.Dock = DockStyle.Fill;
                proizvodjac.WindowState = FormWindowState.Maximized;


            }

            else
            {
                proizvodjac.Activate();
            }   
        }
        NarudzbenicaPrikaz narudzbenica;
        private void narudzbenicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (narudzbenica == null || narudzbenica.IsDisposed)
            {
                narudzbenica = new NarudzbenicaPrikaz();
                narudzbenica.MdiParent = this;
                narudzbenica.Show();
                narudzbenica.Dock = DockStyle.Fill;
                narudzbenica.WindowState = FormWindowState.Maximized;


            }

            else
            {
                narudzbenica.Activate();
            }   
        }
        nmbOd proizvodi;
        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proizvodi == null || proizvodi.IsDisposed)
            {
                proizvodi = new nmbOd();
                proizvodi.MdiParent = this;
                proizvodi.Show();
                proizvodi.Dock = DockStyle.Fill;
                proizvodi.WindowState = FormWindowState.Maximized;


            }

            else
            {
                proizvodi.Activate();
            }   
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
