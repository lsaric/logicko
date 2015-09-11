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
        nmbOd pr = null;
        public VoditeljSkladista()
        {
            InitializeComponent();
            this.statusPoruka.Text = "Dobrodošli " + Login.ime + " " + Login.prezime + " nalazite se na kontrolnoj ploči voditelja skladišta!";
        }

        private void skladišteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (skladista == null || skladista.IsDisposed)
            {
                skladista = new SkladistaPrikaz();
            }
            
            skladista.Show();
        }

        private void strojeviIOpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (strojevi == null || strojevi.IsDisposed)
            {
                strojevi = new Strojevi_i_Oprema_Prikaz();
            }
            strojevi.Show();
        }

        private void tipProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pr == null || pr.IsDisposed)
            {
                pr = new nmbOd();
            }
            pr.Show();
        }

        private void prikazStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdajaProizvodaGraf ppg = new ProdajaProizvodaGraf();
            ppg.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
