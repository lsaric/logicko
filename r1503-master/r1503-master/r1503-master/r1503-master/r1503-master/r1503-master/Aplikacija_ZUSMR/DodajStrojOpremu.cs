﻿using System;
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
    public partial class DodajStrojOpremu : Form
    {
        private int U;
        private List<Skladiste> Skladista1;
        public DodajStrojOpremu(int U)
        {
            this.U = U;
            InitializeComponent();

            string upit = "select * from Skladiste";
            Skladista1 = Skladiste.selectUpit(upit);
            this.cmbNaziv.DataSource = Skladista1;
            this.cmbNaziv.DisplayMember = "Naziv";
            this.cmbNaziv.ValueMember = "ID_Skladista";
            
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
                string sqlUpit = "insert into Strojevi_i_oprema values ('" + txtTip.Text +"'," + Skladista1.ElementAt((cmbNaziv.SelectedIndex)).ID_Skladista + ")";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2 && uneseno)
            {
                string upit = "UPDATE Strojevi_i_oprema SET Tip = '" + txtTip.Text + "',ID_skladista=" + Skladista1.ElementAt((cmbNaziv.SelectedIndex)).ID_Skladista + " WHERE  ID_strojeva= " + int.Parse(txtID.Text.ToString());
                Baza.Instance.IzvrsavanjeUpita(upit);
                this.Close();
            }
            else if (!uneseno)
            {
                MessageBox.Show("Tip mora imati barem jedan znak za unos!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
