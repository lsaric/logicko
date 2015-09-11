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
    public partial class KreirajRacun : Form
    {
        public KreirajRacun()
        {
            InitializeComponent();

            string upit = " SELECT * FROM Kupac";
            List<Kupac> kupci = Kupac.selectUpit(upit);
            this.cmbKupac.DataSource = kupci;
            this.cmbKupac.DisplayMember = "Naziv";
            this.cmbKupac.ValueMember = "ID_kupca";

            string sqlupit = "SELECT * from Proizvod";
            List<Proizvod> proizvodi = Proizvod.selectUpit(sqlupit, 2);

            foreach (Proizvod a in proizvodi)
            {
                ListViewItem listitem = new ListViewItem(a.ID_proizvoda.ToString());
                listitem.SubItems.Add(a.Naziv);
                listitem.SubItems.Add(a.Kolicina.ToString());
                listitem.SubItems.Add(a.Cijena.ToString());
                lstProizvodi.Items.Add(listitem);
            }

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (lstProizvodi.SelectedItems.Count == 1)
            {
                int kolicina = int.Parse(lstProizvodi.SelectedItems[0].SubItems[2].Text);
                if (nmKolicina.Value <= 0)
                {
                    MessageBox.Show("Unesite ispravnu količinu!");
                }
                else
                {
                    if (nmKolicina.Value > kolicina)
                    {
                        MessageBox.Show("Unesena kolicina visa nego zaliha!");
                    }
                    else
                    {
                        string ID = (lstProizvodi.SelectedItems[0].SubItems[0].Text);
                        string naziv = lstProizvodi.SelectedItems[0].SubItems[1].Text;
                        int cijena = int.Parse(lstProizvodi.SelectedItems[0].SubItems[3].Text);
                        bool exsists = false;

                        for (int i = 0; i < lstRacun.Items.Count; i++)
                        {
                            if (lstRacun.Items[i].SubItems[0].Text == ID)
                            {
                                exsists = true;
                            }
                        }

                        if (exsists)
                        {
                            MessageBox.Show("Taj proizvod je dodan u racun!");
                        }
                        else
                        {

                            ListViewItem listitem = new ListViewItem(ID);
                            listitem.SubItems.Add(naziv);
                            listitem.SubItems.Add(nmKolicina.Value.ToString());
                            listitem.SubItems.Add((nmKolicina.Value * cijena).ToString());
                            lstRacun.Items.Add(listitem);
                            nmKolicina.Value = 0;
                            
                            
                            izracunajIznos();
                        }
                    }
                }

            }
        }

        private void btnUkloni_Click(object sender, EventArgs e)
        {
            if (lstRacun.SelectedItems.Count != 1)
            {
                MessageBox.Show("Odaberite jedan prozivod koji zelite ukloniti!");
            }
            else
            {


                lstRacun.SelectedItems[0].Remove();
                izracunajIznos();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (lstRacun.Items.Count > 0) 
            {
                int id = (int) cmbKupac.SelectedValue;

                string sqlupit = "INSERT INTO Racun values (" + int.Parse(txtIznos.Text) + ",SYSDATETIME()," + id + ")";
                Baza.Instance.IzvrsavanjeUpita(sqlupit);

                for (int i = 0; i < lstRacun.Items.Count; i++)
                {
                    sqlupit = "INSERT INTO Proizvod_Racun values (" + int.Parse(lstRacun.Items[i].SubItems[0].Text) + ",(SELECT MAX(ID_racuna) FROM Racun),"+int.Parse(lstRacun.Items[0].SubItems[2].Text)+"  )";
                    Baza.Instance.IzvrsavanjeUpita(sqlupit);

                    sqlupit = "UPDATE Proizvod set Kolicina = Kolicina - " + int.Parse(lstRacun.Items[0].SubItems[2].Text) + " WHERE ID_proizvoda = " + int.Parse(lstRacun.Items[i].SubItems[0].Text);
                    Baza.Instance.IzvrsavanjeUpita(sqlupit);
                }

                slanjeMaila();

                MessageBox.Show("Račun kreiran!");
                this.Close();
                

            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void izracunajIznos()
        {
            int iznos = 0;
            if (lstRacun.Items.Count > 0)
            {
                
                for (int i = 0; i < lstRacun.Items.Count; i++)
                {
                    iznos += int.Parse(lstRacun.Items[i].SubItems[3].Text);
                }

                txtIznos.Text = iznos.ToString();

            }
            else
            {
                txtIznos.Text = iznos.ToString();
            }
        }

        private void slanjeMaila()
        {
            string poruka = "\n \n Poštovani moramo vas obavijestiti da naručite proizvod/e";
            bool salji = false;
            for (int i = 0; i < lstRacun.Items.Count; i++)
            {
                int id_p = int.Parse(lstRacun.Items[i].SubItems[0].Text);
                int kol_p = int.Parse(lstRacun.Items[i].SubItems[2].Text);

                for (int j = 0; j < lstProizvodi.Items.Count; j++)
                {
                    int id_pr = int.Parse(lstProizvodi.Items[j].SubItems[0].Text);
                    int kol_pr = int.Parse(lstProizvodi.Items[j].SubItems[2].Text);

                    if (id_p == id_pr)
                    {
                        int ostalo = kol_pr - kol_p;
                        if (ostalo < 15)
                        {

                            poruka += " \n \n Šifra prozivoda: "
                                      + id_pr + " \n \n Naziv proizvoda: " + lstProizvodi.Items[j].SubItems[1].Text +
                                      " \n \n jer je preostalo " + ostalo + "zaliha na skladištu.";

                            salji = true;
                        } //ako je kolicina manja od 15

                    } //kad nademo proizvod istog ida-

                } //for liste Proizvoda

            } //for liste prozivoda u Racunu

            if (salji)
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

                mm.Subject = "Obavijest o preostalim proizvodima";
                mm.Body = poruka;

                mm.BodyEncoding = UTF8Encoding.UTF8;
                mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                client.Send(mm);
            }

        }

        private void KreirajRacun_Load(object sender, EventArgs e)
        {

        } //kraj metode slanja poruke

    }
}
