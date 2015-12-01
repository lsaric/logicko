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
    public partial class ReferentProdaje : Form
    {
        PoslovniEntitetiPrikaz PrikazKupci = null;
        KreirajIzdatnicu kr = null;
        public ReferentProdaje()
        {
            InitializeComponent();
            this.statusPoruka.Text = "Dobrodošli " + Login.ime + " " + Login.prezime + " nalazite se na kontrolnoj ploči refrenta prodaje!";
        }
        PoslovniEntitetiPrikaz kupac;
        private void kupacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kupac == null || kupac.IsDisposed)
            {
                kupac = new PoslovniEntitetiPrikaz();
                kupac.MdiParent = this;
                kupac.Show();
                kupac.Dock = DockStyle.Fill;
                kupac.WindowState = FormWindowState.Maximized;


            }

            else
            {
                kupac.Activate();
            }   
        }
        KreirajIzdatnicu racun;
        private void računiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (racun == null || racun.IsDisposed)
            {
                racun = new KreirajIzdatnicu();
                racun.MdiParent = this;
                racun.Show();
                racun.Dock = DockStyle.Fill;
                racun.WindowState = FormWindowState.Maximized;


            }

            else
            {
                racun.Activate();
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
