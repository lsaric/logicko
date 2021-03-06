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
    public partial class StatistikaNarudzbe : Form
    {
        public StatistikaNarudzbe()
        {
            InitializeComponent();
            List<Proizvod> proizvodi = Proizvod.selectUpit("Select * from Proizvod", 2);
            List<Proizvod> sortiranaLista = proizvodi.OrderByDescending(o => o.Kolicina).ToList();
            int broj = sortiranaLista.Count;
            if (broj > 5)
            {
                broj = 5;
            }
            for (int i = 0; i < broj; i++)
            {
                this.chart1.Series["Proizvod"].Points.AddXY(sortiranaLista[i].Naziv, int.Parse(sortiranaLista[i].Kolicina.ToString()));
            }



        }
    }
}
