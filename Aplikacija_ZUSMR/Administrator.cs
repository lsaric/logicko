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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zaposlenici zaposlenici = new Zaposlenici();
            zaposlenici.Show();
        }

        private void tipZaposlenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tip_zaposlenja tip_zaposlenja = new Tip_zaposlenja();
            tip_zaposlenja.Show();
        }


    }
}
