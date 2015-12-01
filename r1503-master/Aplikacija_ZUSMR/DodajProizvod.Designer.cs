namespace Aplikacija_ZUSMR
{
    partial class DodajProizvod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cmbProizvodac = new System.Windows.Forms.ComboBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.cmbSkladiste = new System.Windows.Forms.ComboBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.lblNazivProizvodaca = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblSkladiste = new System.Windows.Forms.Label();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJedinicaMjere = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(27, 306);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(163, 306);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(108, 33);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(92, 32);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(180, 20);
            this.txtID.TabIndex = 2;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(92, 80);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(180, 20);
            this.txtNaziv.TabIndex = 3;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(92, 106);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(180, 20);
            this.txtCijena.TabIndex = 4;
            // 
            // cmbProizvodac
            // 
            this.cmbProizvodac.FormattingEnabled = true;
            this.cmbProizvodac.Location = new System.Drawing.Point(92, 182);
            this.cmbProizvodac.Name = "cmbProizvodac";
            this.cmbProizvodac.Size = new System.Drawing.Size(180, 21);
            this.cmbProizvodac.TabIndex = 6;
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(92, 209);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(180, 21);
            this.cmbTip.TabIndex = 7;
            // 
            // cmbSkladiste
            // 
            this.cmbSkladiste.FormattingEnabled = true;
            this.cmbSkladiste.Location = new System.Drawing.Point(92, 236);
            this.cmbSkladiste.Name = "cmbSkladiste";
            this.cmbSkladiste.Size = new System.Drawing.Size(180, 21);
            this.cmbSkladiste.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 32);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(12, 80);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 10;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Location = new System.Drawing.Point(12, 106);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(36, 13);
            this.lblCijena.TabIndex = 11;
            this.lblCijena.Text = "Cijena";
            // 
            // lblNazivProizvodaca
            // 
            this.lblNazivProizvodaca.AutoSize = true;
            this.lblNazivProizvodaca.Location = new System.Drawing.Point(12, 182);
            this.lblNazivProizvodaca.Name = "lblNazivProizvodaca";
            this.lblNazivProizvodaca.Size = new System.Drawing.Size(61, 13);
            this.lblNazivProizvodaca.TabIndex = 13;
            this.lblNazivProizvodaca.Text = "Proizvođač";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(13, 209);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(22, 13);
            this.lblTip.TabIndex = 14;
            this.lblTip.Text = "Tip";
            // 
            // lblSkladiste
            // 
            this.lblSkladiste.AutoSize = true;
            this.lblSkladiste.Location = new System.Drawing.Point(12, 236);
            this.lblSkladiste.Name = "lblSkladiste";
            this.lblSkladiste.Size = new System.Drawing.Size(50, 13);
            this.lblSkladiste.TabIndex = 15;
            this.lblSkladiste.Text = "Skladište";
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(12, 135);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 12;
            this.lblKolicina.Text = "Količina";
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(92, 135);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.ReadOnly = true;
            this.txtKolicina.Size = new System.Drawing.Size(180, 20);
            this.txtKolicina.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Jedinica mjere";
            // 
            // cmbJedinicaMjere
            // 
            this.cmbJedinicaMjere.FormattingEnabled = true;
            this.cmbJedinicaMjere.Location = new System.Drawing.Point(92, 263);
            this.cmbJedinicaMjere.Name = "cmbJedinicaMjere";
            this.cmbJedinicaMjere.Size = new System.Drawing.Size(179, 21);
            this.cmbJedinicaMjere.TabIndex = 17;
            this.cmbJedinicaMjere.SelectedValueChanged += new System.EventHandler(this.cmbJedinicaMjere_SelectedValueChanged);
            // 
            // DodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 351);
            this.Controls.Add(this.cmbJedinicaMjere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSkladiste);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblNazivProizvodaca);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.cmbSkladiste);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.cmbProizvodac);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnos);
            this.Name = "DodajProizvod";
            this.Text = "Dodaj proizvod";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnOdustani;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtNaziv;
        public System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox cmbProizvodac;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.ComboBox cmbSkladiste;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.Label lblNazivProizvodaca;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblSkladiste;
        private System.Windows.Forms.Label lblKolicina;
        public System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJedinicaMjere;
    }
}