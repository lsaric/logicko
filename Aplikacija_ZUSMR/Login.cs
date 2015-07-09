using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_ZUSMR
{
    public partial class Login : Form
    {
        public static string KorisnickoIme;
        public Login()
        {
            InitializeComponent();
            label1.Text = "Username:";
            label2.Text = "Password:";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prijava();
        }
        private void Prijava()
        {
            //Povezivanje na bazu
            string sqlUpit = "select Opis from Tip_zaposlenja,Zaposlenici where KorisnickoIme LIKE'"+this.textBox1.Text+ "'and Lozinka='"+this.textBox2.Text+ "'and Tip_zaposlenja.ID_zaposlenja = Zaposlenici.ID_zaposlenja";
            
            try
            {
                if (Baza.Instance.VrijednostUpita(sqlUpit).Equals("administrator"))
                {
                    KorisnickoIme = textBox1.Text;
                    MessageBox.Show("Uspjesna prijava");
                    Administrator admin = new Administrator();
                    admin.Show();
                    this.Hide();
                }
                else if (Baza.Instance.VrijednostUpita(sqlUpit).Equals("Radnik"))
                {
                    KorisnickoIme = textBox1.Text;
                    MessageBox.Show("Uspjesna prijava");
                    Radnik radnik = new Radnik();
                    radnik.Show();
                    this.Hide();
                }
                else if (Baza.Instance.VrijednostUpita(sqlUpit).Equals("Voditelj skladista"))
                {
                    KorisnickoIme = textBox1.Text;
                    MessageBox.Show("Uspjesna prijava");
                    VoditeljSkladista vs = new VoditeljSkladista();
                    vs.Show();
                    this.Hide();
                }
                else if (Baza.Instance.VrijednostUpita(sqlUpit).Equals("Voditelj nabave"))
                {
                    KorisnickoIme = textBox1.Text;
                    MessageBox.Show("Uspjesna prijava");
                    VoditeljNabave vn = new VoditeljNabave();
                    vn.Show();
                    this.Hide();
                }
                else if (Baza.Instance.VrijednostUpita(sqlUpit).Equals("Referent prodaje"))
                {
                    KorisnickoIme = textBox1.Text;
                    MessageBox.Show("Uspjesna prijava");
                    ReferentProdaje rp = new ReferentProdaje();
                    rp.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Pogresan unos");

            }
        }
    }
}
