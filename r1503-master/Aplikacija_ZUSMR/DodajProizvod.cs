using System;
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
    public partial class DodajProizvod : Form
    {
        private int U;
        private List<Proizvodac> proizvodac;
        private List<Tip_proizvoda> tip;
        private List<Skladiste> skladista;
        private List<JedinicaMjere> jediniceMjere;
        public DodajProizvod(int U)
        {
            this.U = U;
            InitializeComponent();

            string upit = "select * from Proizvodac";
            proizvodac = Proizvodac.selectUpit(upit);
            this.cmbProizvodac.DataSource = proizvodac;
            this.cmbProizvodac.DisplayMember = "Naziv";
            this.cmbProizvodac.ValueMember = "ID_proizvodac";

            upit = "select * from Tip_proizvoda";
            tip = Tip_proizvoda.selectUpit(upit);
            this.cmbTip.DataSource = tip;
            this.cmbTip.DisplayMember = "Tip";
            this.cmbTip.ValueMember = "ID_tip";

            upit = "select * from Skladiste";
            skladista = Skladiste.selectUpit(upit);
            this.cmbSkladiste.DataSource = skladista;
            this.cmbSkladiste.DisplayMember = "Naziv";
            this.cmbSkladiste.ValueMember = "ID_skladista";

            upit = "select * from Jedinice_Mjere";
            jediniceMjere = JedinicaMjere.selectUpit(upit);
            this.cmbJedinicaMjere.DataSource = jediniceMjere;
            this.cmbJedinicaMjere.DisplayMember = "JMNaziv";
            this.cmbJedinicaMjere.ValueMember = "ID_JediniceMjere";


            if (this.U == 1)
            {
                txtKolicina.Text = "0";
            }
            else if (this.U == 2)
            {
                this.cmbJedinicaMjere.Hide();
                this.label1.Hide();
            }
        }
        private void btnUnos_Click(object sender, EventArgs e)
        {
            bool uneseno = true;
            if (txtNaziv.Text.Length < 3 || txtCijena.Text.Length < 1 || cmbSkladiste.DataSource == null)
            {
                uneseno = false;
            }
            string odgDodavanja = izracunajKapacitetSkladista((int)this.cmbSkladiste.SelectedValue, int.Parse(txtKolicina.Text));
            if (U == 1 && uneseno && odgDodavanja=="OK")
            {
                string sqlUpit = "insert into Proizvod values ('" + txtNaziv.Text + "','" + txtCijena.Text + "','" + txtKolicina.Text + "'," + proizvodac.ElementAt((cmbProizvodac.SelectedIndex)).ID_proizvodac + "," + tip.ElementAt((cmbTip.SelectedIndex)).ID_tip + "," + (int)this.cmbSkladiste.SelectedValue + "," + jediniceMjere.ElementAt((this.cmbJedinicaMjere.SelectedIndex)).ID_JediniceMjere + ")";
                Baza.Instance.IzvrsavanjeUpita(sqlUpit);
                this.Close();
            }
            else if (U == 2 && uneseno && odgDodavanja == "OK")
            {
                string upit = "UPDATE Proizvod SET Naziv = '" + txtNaziv.Text + "', Cijena = '" + txtCijena.Text + "', Kolicina= '" + txtKolicina.Text + "',ID_proizvodaca=" + proizvodac.ElementAt((cmbProizvodac.SelectedIndex)).ID_proizvodac + ",ID_tip=" + tip.ElementAt((cmbTip.SelectedIndex)).ID_tip +",ID_Skladista="+(int)this.cmbSkladiste.SelectedValue +" WHERE  ID_proizvoda= " + int.Parse(txtID.Text.ToString());
                Baza.Instance.IzvrsavanjeUpita(upit);
                this.Close();
            }
            else if (odgDodavanja == "NO")
            {
                MessageBox.Show("Nedostatak kapaciteta odabranog skladišta, molimo vas odaberite drugo skladište!");
            }
            else if (odgDodavanja == "ERR")
            {
                MessageBox.Show("Greška prilikom izračuna mjesta za skladištenje!");
            }
            else if (!uneseno)
            {
                MessageBox.Show("Provjerite jeste li unijeli sve podatke!");
            }
            
            
        }

        private string izracunajKapacitetSkladista(int IDSkladista, int kolicinaProizvoda)
        {
            try
            {
                string upit = "Select s.Kapacitet as Kapacitet, SUM(p.Kolicina) as Kolicina from Proizvod p,Skladiste s where p.ID_skladista = " + IDSkladista + " AND s.ID_skaldista = " + IDSkladista + " GROUP BY Kapacitet";
                DbDataReader dr = Baza.Instance.DohvatiDataReader(upit);
                int kapacitet = 0;
                int trenutnaKolicina = 0;
                while (dr.Read())
                {
                    kapacitet = int.Parse(dr["Kapacitet"].ToString());
                    try
                    {
                        trenutnaKolicina = int.Parse(dr["Kolicina"].ToString());
                    }
                    catch
                    {
                        trenutnaKolicina = 0;
                    }
                    
                }
                dr.Close();

                int novoStanje = trenutnaKolicina + kolicinaProizvoda;
                if (kapacitet >= novoStanje)
                {
                    if (kapacitet != 0)
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
                            return "OK"; //obavijest  + moze dodati
                    }
                    

                        
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

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbJedinicaMjere_SelectedValueChanged(object sender, EventArgs e)
        {

                List<Skladiste> odabirSkladista = new List<Skladiste>();
                try
                {
                    int idJM = (int)(this.cmbJedinicaMjere.SelectedValue);
                    for (int i = 0; i < skladista.Count; i++)
                    {
                        if (skladista[i].ID_JedinicaMjere == idJM)
                        {
                            odabirSkladista.Add(skladista[i]);
                        }
                    }
                    if (odabirSkladista.Count == 0)
                    {
                        this.cmbSkladiste.DataSource = null;
                    }
                    else
                    {
                        this.cmbSkladiste.DataSource = odabirSkladista;
                        this.cmbSkladiste.DisplayMember = "Naziv";
                        this.cmbSkladiste.ValueMember = "ID_skladista";
                    }

                }
                catch
                {

                }
               
            

        }


    }
}
