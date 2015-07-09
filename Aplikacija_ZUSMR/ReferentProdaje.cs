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
        public ReferentProdaje()
        {
            InitializeComponent();
        }

        private void kupacToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KupciPrikaz PrikazKupci = new KupciPrikaz();
            PrikazKupci.Show();
        }

        private void računiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreirajRacun kr = new KreirajRacun();
            kr.Show();
        }
    }
}
