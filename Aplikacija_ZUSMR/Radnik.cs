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
    public partial class Radnik : Form
    {
        public Radnik()
        {
            InitializeComponent();
        }

        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nmbOd proizvodprikaz = new nmbOd();
            proizvodprikaz.Show();
        }
    }
}
