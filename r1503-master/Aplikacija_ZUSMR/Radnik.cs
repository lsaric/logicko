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
        nmbOd proizvodprikaz = null;
        public Radnik()
        {
            InitializeComponent();
            this.statusPoruka.Text = "Dobrodošli " + Login.ime + " " + Login.prezime + " nalazite se na kontrolnoj ploči radnika!";
        }
        
        private void proizvodiToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            Login login = new Login();
            login.ShowDialog();
        }

        nmbOd nmb;
        private void pretragaProizvodaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (nmb == null || nmb.IsDisposed)
            {
                nmb = new nmbOd();
                nmb.MdiParent = this;
                nmb.Show();
                nmb.Dock = DockStyle.Fill;
                nmb.WindowState = FormWindowState.Maximized;


            }

            else
            {
                nmb.Activate();
            }   
        }
        StatistikaNarudzbe stNarudzbe;
        private void prikazStanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (stNarudzbe == null || stNarudzbe.IsDisposed)
            {
                stNarudzbe = new StatistikaNarudzbe();
                stNarudzbe.MdiParent = this;
                stNarudzbe.Show();
                stNarudzbe.Dock = DockStyle.Fill;
                stNarudzbe.WindowState = FormWindowState.Maximized;


            }

            else
            {
                stNarudzbe.Activate();
            }  
        }
    }
}
