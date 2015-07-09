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
    public partial class Dodaj_Tip_Zaposlenja : Form
    {

        private int U;

        public Dodaj_Tip_Zaposlenja(int U)
        {
            this.U = U;
            InitializeComponent();
            
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            if (U == 1)
            {
                string sqlUpit = "insert into Tip_zaposlenja values ('" + txtOpis.Text +"')";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2)
            {
                string upit = "UPDATE Tip_zaposlenja SET Opis = ('" + txtOpis.Text + "') WHERE  ID_zaposlenja = (" + int.Parse(txtID.Text.ToString())+")";
                Baza.Instance.IzvrsavanjeUpita(upit);
                this.Close();
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
