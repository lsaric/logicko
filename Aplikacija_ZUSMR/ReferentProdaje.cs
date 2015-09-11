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
        KupciPrikaz PrikazKupci = null;
        KreirajRacun kr = null;
        public ReferentProdaje()
        {
            InitializeComponent();
            this.statusPoruka.Text = "Dobrodošli " + Login.ime + " " + Login.prezime + " nalazite se na kontrolnoj ploči refrenta prodaje!";
        }

        private void kupacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PrikazKupci == null || PrikazKupci.IsDisposed)
            {
                PrikazKupci = new KupciPrikaz();
            }
            PrikazKupci.Show();
        }

        private void računiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (kr == null || kr.IsDisposed)
            {
                kr = new KreirajRacun();
            }
            
            kr.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
