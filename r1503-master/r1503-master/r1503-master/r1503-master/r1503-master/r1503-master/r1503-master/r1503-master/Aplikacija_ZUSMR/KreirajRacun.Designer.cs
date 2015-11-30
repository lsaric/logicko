namespace Aplikacija_ZUSMR
{
    partial class KreirajRacun
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
            this.lstProizvodi = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cijena = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstRacun = new System.Windows.Forms.ListView();
            this.ID_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kolicina_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Iznos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmKolicina = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lstProizvodi
            // 
            this.lstProizvodi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Naziv,
            this.Kolicina,
            this.Cijena});
            this.lstProizvodi.FullRowSelect = true;
            this.lstProizvodi.Location = new System.Drawing.Point(307, 12);
            this.lstProizvodi.MultiSelect = false;
            this.lstProizvodi.Name = "lstProizvodi";
            this.lstProizvodi.Size = new System.Drawing.Size(375, 107);
            this.lstProizvodi.TabIndex = 0;
            this.lstProizvodi.UseCompatibleStateImageBehavior = false;
            this.lstProizvodi.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 47;
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 150;
            // 
            // Kolicina
            // 
            this.Kolicina.Text = "Količina";
            this.Kolicina.Width = 81;
            // 
            // Cijena
            // 
            this.Cijena.Text = "Cijena";
            this.Cijena.Width = 80;
            // 
            // lstRacun
            // 
            this.lstRacun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_,
            this.Naziv_,
            this.Kolicina_,
            this.Iznos});
            this.lstRacun.FullRowSelect = true;
            this.lstRacun.Location = new System.Drawing.Point(307, 164);
            this.lstRacun.MultiSelect = false;
            this.lstRacun.Name = "lstRacun";
            this.lstRacun.Size = new System.Drawing.Size(375, 112);
            this.lstRacun.TabIndex = 1;
            this.lstRacun.UseCompatibleStateImageBehavior = false;
            this.lstRacun.View = System.Windows.Forms.View.Details;
            // 
            // ID_
            // 
            this.ID_.Text = "ID";
            this.ID_.Width = 45;
            // 
            // Naziv_
            // 
            this.Naziv_.Text = "Naziv";
            this.Naziv_.Width = 148;
            // 
            // Kolicina_
            // 
            this.Kolicina_.Text = "Količina";
            this.Kolicina_.Width = 75;
            // 
            // Iznos
            // 
            this.Iznos.Text = "Iznos";
            this.Iznos.Width = 90;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(307, 125);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 33);
            this.btnDodaj.TabIndex = 2;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(421, 125);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(108, 33);
            this.btnUkloni.TabIndex = 3;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(24, 218);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(108, 33);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(150, 218);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(108, 33);
            this.btnOdustani.TabIndex = 5;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // cmbKupac
            // 
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.Location = new System.Drawing.Point(86, 12);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(199, 21);
            this.cmbKupac.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kupac";
            // 
            // nmKolicina
            // 
            this.nmKolicina.Location = new System.Drawing.Point(86, 50);
            this.nmKolicina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmKolicina.Name = "nmKolicina";
            this.nmKolicina.Size = new System.Drawing.Size(199, 20);
            this.nmKolicina.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Količina";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ukupno";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(86, 164);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(199, 20);
            this.txtIznos.TabIndex = 12;
            // 
            // KreirajRacun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 337);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmKolicina);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKupac);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lstRacun);
            this.Controls.Add(this.lstProizvodi);
            this.Name = "KreirajRacun";
            this.Text = "Kreiraj račun";
            this.Load += new System.EventHandler(this.KreirajRacun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstProizvodi;
        private System.Windows.Forms.ListView lstRacun;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.ComboBox cmbKupac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader ID_;
        private System.Windows.Forms.ColumnHeader Naziv_;
        private System.Windows.Forms.ColumnHeader Kolicina_;
        private System.Windows.Forms.NumericUpDown nmKolicina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Kolicina;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.ColumnHeader Cijena;
        private System.Windows.Forms.ColumnHeader Iznos;
    }
}