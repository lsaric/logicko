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
        Zaposlenici zaposlenici = null;
        Tip_zaposlenja tip_zaposlenja = null;
        ProdajaProizvodaGraf ppg = null;
        public Administrator()
        {
            InitializeComponent();
            this.statusPoruka.Text = "Dobrodošli " + Login.ime + " " + Login.prezime + " nalazite se na admin kontrolnoj ploči!";
        }
        Zaposlenici zaposlenik;
        private void zaposleniciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zaposlenik == null || zaposlenik.IsDisposed)
            {
                zaposlenik = new Zaposlenici();
                zaposlenik.MdiParent = this;
                zaposlenik.Show();
                zaposlenik.Dock = DockStyle.Fill;
                zaposlenik.WindowState = FormWindowState.Maximized;
                

            }

            else 
            {
                zaposlenik.Activate();
            }   
        }
        Tip_zaposlenja tipzaposlenja;
        private void tipZaposlenjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tipzaposlenja == null || tipzaposlenja.IsDisposed )
            {
                tipzaposlenja = new Tip_zaposlenja();
                tipzaposlenja.MdiParent = this;
                tipzaposlenja.Show();
                tipzaposlenja.Dock = DockStyle.Fill;
                tipzaposlenja.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                tipzaposlenja.Activate();
            }   
            
        }

        private void grafToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ppg == null || ppg.IsDisposed)
            {
                ppg = new ProdajaProizvodaGraf();
            }

            ppg.Show();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {

        }

        private void Odjava_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }


    }
}
