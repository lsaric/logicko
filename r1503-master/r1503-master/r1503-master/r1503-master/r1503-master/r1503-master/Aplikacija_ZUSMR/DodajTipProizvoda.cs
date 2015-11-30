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
    public partial class DodajTipProizvoda : Form
    {
        private int U;
        public DodajTipProizvoda(int U)
        {
            this.U = U;
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            bool uneseno = true;
            if (txtTip.Text.Length < 1)
            {
                uneseno = false;
            }
            if (U == 1 && uneseno)
            {
                string sqlUpit = "insert into Tip_proizvoda values ('" + txtTip.Text + "')";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2 && uneseno)
            {
                string sqlUpit = "UPDATE Tip_proizvoda SET Tip = '" + txtTip.Text + "' WHERE  ID_tip = " + int.Parse(txtID.Text.ToString()) + "";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if(!uneseno)
            {
                MessageBox.Show("Tip treba imati unesen barem jedan znak!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
