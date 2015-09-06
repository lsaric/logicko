using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private List<Zaposlenik> zaposlenici;
        
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
           if (U == 1)
            {
                string sadrzaj = "Poštovani, \n \n Ovo je automatski generirana poruka prilikom narudžbe proizvoda. \n \n";
                if (lstNarudzba.Items.Count > 0)
                {
                    string sqlUpit = "insert into Narudzbenica values ('" + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.mmm") + "',(Select ID_zaposlenik from Zaposlenici where KorisnickoIme ='"+Login.KorisnickoIme+"' ),'"+txtKontakt.Text+"')";
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
            }
           else if (U == 2)
           {

               string upit = "UPDATE Narudzbenica SET Datum = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd hh:mm:ss.mmm") + "', ID_zaposlenik = (Select ID_zaposlenik from Zaposlenici where KorisnickoIme ='" + Login.KorisnickoIme + "' ), Kontakt_dobavljvaca = '"+txtKontakt.Text+"' WHERE  ID_narudzbenice= " + int.Parse(txtID.Text.ToString());
               Baza.Instance.IzvrsavanjeUpita(upit);
               this.Close();
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
                    lstProizvodi.SelectedItems[0].Remove();

                    ListViewItem listitem = new ListViewItem(ID);
                    listitem.SubItems.Add(naziv);
                    listitem.SubItems.Add(nmKolicina.Value.ToString()); //string kolicina u listi
                    lstNarudzba.Items.Add(listitem);
                    nmKolicina.Value = 0;
    
                }
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
