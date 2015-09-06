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
        public VoditeljSkladista()
        {
            InitializeComponent();
        }

        private void skladišteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SkladistaPrikaz skladista = new SkladistaPrikaz();
            skladista.Show();
        }

        private void strojeviIOpremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Strojevi_i_Oprema_Prikaz strojevi = new Strojevi_i_Oprema_Prikaz();
            strojevi.Show();
        }

        private void tipProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TipProizvodaPrikaz TipProizvodaPr = new TipProizvodaPrikaz();
            TipProizvodaPr.Show();
        }

        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nmbOd pr = new nmbOd();
            pr.Show();
        }

        private void prikazStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdajaProizvodaGraf ppg = new ProdajaProizvodaGraf();
            ppg.Show();
        }
    }
}
