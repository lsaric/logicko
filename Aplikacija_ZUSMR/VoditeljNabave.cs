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

        private void proizvodacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proizvodacPrikaz == null || proizvodacPrikaz.IsDisposed)
            {
                proizvodacPrikaz = new ProizvodacPrikaz();
            }
            
            proizvodacPrikaz.Show();
        }

        private void narudzbenicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (narudzbenicaPrikaz == null || narudzbenicaPrikaz.IsDisposed)
            {
                narudzbenicaPrikaz = new NarudzbenicaPrikaz();
            }
            narudzbenicaPrikaz.Show();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proizvodacPrikaz == null || proizvodacPrikaz.IsDisposed)
            {
                proizvodprikaz = new nmbOd();
            }
            proizvodprikaz.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
