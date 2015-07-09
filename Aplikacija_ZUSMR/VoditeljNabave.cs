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
        public VoditeljNabave()
        {
            InitializeComponent();
        }

        private void proizvodacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProizvodacPrikaz proizvodacPrikaz = new ProizvodacPrikaz();
            proizvodacPrikaz.Show();
        }

        private void narudzbenicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NarudzbenicaPrikaz narudzbenicaPrikaz = new NarudzbenicaPrikaz();
            narudzbenicaPrikaz.Show();
        }
    }
}
