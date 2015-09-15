namespace Aplikacija_ZUSMR
{
    partial class DodajZaposlenika
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.cmbTipZaposlenja = new System.Windows.Forms.ComboBox();
            this.cmbSkladiste = new System.Windows.Forms.ComboBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblKorisnicko = new System.Windows.Forms.Label();
            this.lblLozinka = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblSkladiste = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 23);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(167, 20);
            this.txtID.TabIndex = 0;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(97, 63);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(167, 20);
            this.txtIme.TabIndex = 1;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(97, 89);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(167, 20);
            this.txtPrezime.TabIndex = 2;
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.Location = new System.Drawing.Point(97, 115);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(167, 20);
            this.txtKorisnicko.TabIndex = 3;
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(97, 141);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(167, 20);
            this.txtLozinka.TabIndex = 4;
            // 
            // cmbTipZaposlenja
            // 
            this.cmbTipZaposlenja.FormattingEnabled = true;
            this.cmbTipZaposlenja.Location = new System.Drawing.Point(110, 204);
            this.cmbTipZaposlenja.Name = "cmbTipZaposlenja";
            this.cmbTipZaposlenja.Size = new System.Drawing.Size(154, 21);
            this.cmbTipZaposlenja.TabIndex = 5;
            // 
            // cmbSkladiste
            // 
            this.cmbSkladiste.FormattingEnabled = true;
            this.cmbSkladiste.Location = new System.Drawing.Point(110, 232);
            this.cmbSkladiste.Name = "cmbSkladiste";
            this.cmbSkladiste.Size = new System.Drawing.Size(154, 21);
            this.cmbSkladiste.TabIndex = 6;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(25, 287);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 7;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(156, 287);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(108, 33);
            this.btnOdustani.TabIndex = 8;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 23);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "ID";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(13, 63);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 10;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(12, 89);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 11;
            this.lblPrezime.Text = "Prezime";
            // 
            // lblKorisnicko
            // 
            this.lblKorisnicko.AutoSize = true;
            this.lblKorisnicko.Location = new System.Drawing.Point(12, 115);
            this.lblKorisnicko.Name = "lblKorisnicko";
            this.lblKorisnicko.Size = new System.Drawing.Size(75, 13);
            this.lblKorisnicko.TabIndex = 12;
            this.lblKorisnicko.Text = "Korisničko ime";
            // 
            // lblLozinka
            // 
            this.lblLozinka.AutoSize = true;
            this.lblLozinka.Location = new System.Drawing.Point(13, 141);
            this.lblLozinka.Name = "lblLozinka";
            this.lblLozinka.Size = new System.Drawing.Size(44, 13);
            this.lblLozinka.TabIndex = 13;
            this.lblLozinka.Text = "Lozinka";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(13, 204);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(75, 13);
            this.lblTip.TabIndex = 14;
            this.lblTip.Text = "Tip zaposlenja";
            // 
            // lblSkladiste
            // 
            this.lblSkladiste.AutoSize = true;
            this.lblSkladiste.Location = new System.Drawing.Point(13, 232);
            this.lblSkladiste.Name = "lblSkladiste";
            this.lblSkladiste.Size = new System.Drawing.Size(78, 13);
            this.lblSkladiste.TabIndex = 15;
            this.lblSkladiste.Text = "Naziv skladišta";
            // 
            // DodajZaposlenika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 332);
            this.Controls.Add(this.lblSkladiste);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblLozinka);
            this.Controls.Add(this.lblKorisnicko);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.cmbSkladiste);
            this.Controls.Add(this.cmbTipZaposlenja);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.txtID);
            this.Name = "DodajZaposlenika";
            this.Text = "Dodaj zaposlenika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtIme;
        public System.Windows.Forms.TextBox txtPrezime;
        public System.Windows.Forms.TextBox txtKorisnicko;
        public System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.ComboBox cmbTipZaposlenja;
        private System.Windows.Forms.ComboBox cmbSkladiste;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblKorisnicko;
        private System.Windows.Forms.Label lblLozinka;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblSkladiste;
    }
}