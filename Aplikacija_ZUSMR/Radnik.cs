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
    public partial class Radnik : Form
    {
        nmbOd proizvodprikaz = null;
        public Radnik()
        {
            InitializeComponent();
            this.statusPoruka.Text = "Dobrodošli " + Login.ime + " " + Login.prezime + " nalazite se na kontrolnoj ploči radnika!";
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (proizvodprikaz == null || proizvodprikaz.IsDisposed)
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

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
