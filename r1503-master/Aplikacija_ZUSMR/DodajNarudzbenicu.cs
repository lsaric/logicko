﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_ZUSMR
{
    public partial class DodajNarudzbenicu : Form
    {
        private int U;
        
        public DodajNarudzbenicu(int U)
        {
            this.U = U;
            InitializeComponent();

            string sqlupit = "SELECT * from Proizvod";
            List<Proizvod> proizvodi = Proizvod.selectUpit(sqlupit, 2);

            foreach(Proizvod a in proizvodi)
            {
                ListViewItem listitem = new ListViewItem(a.ID_proizvoda.ToString());
                listitem.SubItems.Add(a.Naziv);
                lstProizvodi.Items.Add(listitem);
            }

            
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            bool uneseno = true;
            if (txtKontakt.Text.Length < 2)
            {
                uneseno = false;
            }
           if (U == 1 && uneseno)
            {
                string sadrzaj = "Poštovani, \n \n Ovo je automatski generirana poruka prilikom narudžbe proizvoda. \n \n";
                if (lstNarudzba.Items.Count > 0)
                {
                    string sqlUpit = "insert into Narudzbenica values ('" + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.mmm") + "',(Select ID_zaposlenik from Zaposlenici where KorisnickoIme ='" + Login.KorisnickoIme + "' ),'" + txtKontakt.Text + "')";
                    Baza.Instance.IzvrsavanjeUpita(sqlUpit);

                    sadrzaj += " \n Rok : " + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.mmm");
                    sadrzaj += " \n Ukupno naručeno proizvoda je : " + lstNarudzba.Items.Count;
                    for (int i = 0; i < lstNarudzba.Items.Count; i++)
                    {
                        int id = int.Parse(lstNarudzba.Items[i].SubItems[0].Text);
                        string naziv = lstNarudzba.Items[i].SubItems[1].Text;
                        int kol = int.Parse(lstNarudzba.Items[i].SubItems[2].Text);

                        sadrzaj += "\n \n" + (i + 1) + ". proizvod: ";
                        sadrzaj += "\n ID : " + id;
                        sadrzaj += "\n Naziv : " + naziv;
                        sadrzaj += "\n Količine: " + kol;

                        string upit = "insert into Narudzbenica_Proizvod values((SELECT MAX(ID_narudzbenice) FROM Narudzbenica)," + id + "," + kol + ")";
                        Baza.Instance.IzvrsavanjeUpita(upit);
                        upit = "UPDATE Proizvod set Kolicina = Kolicina + " + kol + " where ID_proizvoda = " + id;
                        Baza.Instance.IzvrsavanjeUpita(upit);
                    }

                    sadrzaj += "\n \n Kreirano : " + System.DateTime.Now;

                    slanjeMaila(sadrzaj, txtKontakt.Text);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Treba postojati barem jedan proizvod na narudzbenici!");
                }
            }
           else if (U == 2 && uneseno)
           {

               string upit = "UPDATE Narudzbenica SET Datum = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.mmm") + "', ID_zaposlenik = (Select ID_zaposlenik from Zaposlenici where KorisnickoIme ='" + Login.KorisnickoIme + "' ), Kontakt_dobavljvaca = '"+txtKontakt.Text+"' WHERE  ID_narudzbenice= " + int.Parse(txtID.Text.ToString());
               Baza.Instance.IzvrsavanjeUpita(upit);
               this.Close();
           }
           else if (!uneseno)
           {
               MessageBox.Show("Unesite kontakt dobavljača!");
           }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (nmKolicina.Value <= 0)
            {
                MessageBox.Show("Unesite kolicinu");
            }
            else
            {
                string ID = (lstProizvodi.SelectedItems[0].SubItems[0].Text);
                string naziv = lstProizvodi.SelectedItems[0].SubItems[1].Text;
                bool exsists = false;

                for (int i = 0; i < lstNarudzba.Items.Count; i++)
                {
                    if (lstNarudzba.Items[i].SubItems[0].Text == ID)
                    {
                        exsists = true;
                    }
                }

                if (exsists)
                {
                    MessageBox.Show("Taj prozivod je dodan u narudzbenicu!");
                }
                else
                {
                    string odgDodavanja = izracunajKapacitetSkladista(int.Parse(ID), (int)(nmKolicina.Value));
                    if(odgDodavanja == "OK")
                    {
                        lstProizvodi.SelectedItems[0].Remove();

                    ListViewItem listitem = new ListViewItem(ID);
                    listitem.SubItems.Add(naziv);
                    listitem.SubItems.Add(nmKolicina.Value.ToString()); //string kolicina u listi
                    lstNarudzba.Items.Add(listitem);
                    nmKolicina.Value = 0;
                    }
                    else if(odgDodavanja == "NO")
                    {
                        MessageBox.Show("Skladište u kojem je smješten proizvod kojeg naručujete je popunjen!");
                    }
                    else if(odgDodavanja == "ERR")
                    {
                        MessageBox.Show("Greška prilikom izračunavanja kapaciteta!");
                    }
    
                }
            }


        }

        private string izracunajKapacitetSkladista(int IDproizvoda, int kolicinaProizvoda)
        {
            //PROMINIT UPITE
            try
            {
                string upit = "Select s.Kapacitet as Kapacitet,p.ID_skladista as ID, SUM(p.Kolicina) as Kolicina from Proizvod p,Skladiste s where p.ID_skladista = (SELECT ID_skladista from Proizvod where ID_proizvoda = " + IDproizvoda + ") AND s.ID_skaldista = (SELECT ID_skladista from Proizvod where ID_proizvoda = " + IDproizvoda + ") GROUP BY Kapacitet,p.ID_skladista";
                DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
                int kapacitet = 0;
                int trenutnaKolicina = 0;
                int IDSkladista = 0;
                while (dr.Read())
                {
                    kapacitet = int.Parse(dr["Kapacitet"].ToString());
                    trenutnaKolicina = int.Parse(dr["Kolicina"].ToString());
                    IDSkladista = int.Parse(dr["ID"].ToString());
                }
                dr.Close();

                int novoStanje = trenutnaKolicina + kolicinaProizvoda;
                if (kapacitet >= novoStanje)
                {
                    float postotakPopunjenosti = (novoStanje / kapacitet) * 100;
                    if (postotakPopunjenosti >= 90f)
                    {
                        try
                        {
                            SmtpClient client = new SmtpClient();
                            client.Port = 587;
                            client.Host = "smtp.gmail.com";
                            client.EnableSsl = true;
                            client.Timeout = 10000;
                            client.DeliveryMethod = SmtpDeliveryMethod.Network;
                            client.UseDefaultCredentials = false;
                            client.Credentials = new System.Net.NetworkCredential("AplikacijaZUSMR@gmail.com", "aplikacija");


                            MailMessage mm = new MailMessage("donotreply@domain.com", "AplikacijaZUSMR@gmail.com");

                            mm.Subject = "Obavijest o popunjenosti skladišta";
                            mm.Body = "Skladište šifre: " + IDSkladista + " je popunjen + " + postotakPopunjenosti + "% !";

                            mm.BodyEncoding = UTF8Encoding.UTF8;
                            mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                            client.Send(mm);
                        }
                        catch
                        {

                        }

                        return "OK"; //obavijest + moze dodati
                    }
                    return "OK"; //uredu moze dodati
                }
                else
                {
                    return "NO"; //nema mjesta
                }

            }
            catch
            {
                return "ERR";//greska s radom
            }


        }


        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (lstNarudzba.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite jedan prozivod koji zelite ukloniti!");
            }
            else
            {

                ListViewItem listitem = new ListViewItem(lstNarudzba.SelectedItems[0].SubItems[0].Text);
                listitem.SubItems.Add(lstNarudzba.SelectedItems[0].SubItems[1].Text);
                lstProizvodi.Items.Add(listitem);

                lstNarudzba.SelectedItems[0].Remove();
            }

        }

        private void slanjeMaila(string sadrzaj, string primatelj)
        {

            try
            {
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("AplikacijaZUSMR@gmail.com", "aplikacija");


                MailMessage mm = new MailMessage("donotreply@domain.com", primatelj);

                mm.Subject = "Obavijest narudžbi!";
                mm.Body = sadrzaj;

                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);
            }
            catch (Exception)
            {

            }

        } //kraj metode slanja poruke


    }
}
