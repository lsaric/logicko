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
    public partial class StatistikaNarudzbe : Form
    {
        public StatistikaNarudzbe()
        {
            InitializeComponent();
            List<Proizvod> proizvodi = Proizvod.selectUpit("Select * from Proizvod Order by Kolicina DESC ", 2);
            int broj = proizvodi.Count;
            if (broj > 5)
            {
                broj = 5;
            }
            for (int i = 0; i < broj; i++)
            {
                this.chart1.Series["Proizvod"].Points.AddXY(proizvodi[i].Naziv, int.Parse(proizvodi[i].Kolicina.ToString()));
            }



        }
    }
}
