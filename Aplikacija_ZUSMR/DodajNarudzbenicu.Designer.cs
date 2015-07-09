namespace Aplikacija_ZUSMR
{
    partial class DodajNarudzbenicu
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
            this.lblID = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.nmKolicina = new System.Windows.Forms.NumericUpDown();
            this.lblKolicina = new System.Windows.Forms.Label();
            this.lstProizvodi = new System.Windows.Forms.ListView();
            this.lstNarudzba = new System.Windows.Forms.ListView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUkloni = new System.Windows.Forms.Button();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Naziv_ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kolicina = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nmKolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(154, 318);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(249, 318);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(42, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(42, 75);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(38, 13);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Datum";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(124, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(124, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // nmKolicina
            // 
            this.nmKolicina.Location = new System.Drawing.Point(124, 164);
            this.nmKolicina.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmKolicina.Name = "nmKolicina";
            this.nmKolicina.Size = new System.Drawing.Size(120, 20);
            this.nmKolicina.TabIndex = 10;
            // 
            // lblKolicina
            // 
            this.lblKolicina.AutoSize = true;
            this.lblKolicina.Location = new System.Drawing.Point(42, 164);
            this.lblKolicina.Name = "lblKolicina";
            this.lblKolicina.Size = new System.Drawing.Size(44, 13);
            this.lblKolicina.TabIndex = 11;
            this.lblKolicina.Text = "Količina";
            // 
            // lstProizvodi
            // 
            this.lstProizvodi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Naziv});
            this.lstProizvodi.Location = new System.Drawing.Point(45, 202);
            this.lstProizvodi.Name = "lstProizvodi";
            this.lstProizvodi.Size = new System.Drawing.Size(131, 97);
            this.lstProizvodi.TabIndex = 12;
            this.lstProizvodi.UseCompatibleStateImageBehavior = false;
            this.lstProizvodi.View = System.Windows.Forms.View.Details;
            // 
            // lstNarudzba
            // 
            this.lstNarudzba.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_,
            this.Naziv_,
            this.Kolicina});
            this.lstNarudzba.Location = new System.Drawing.Point(306, 202);
            this.lstNarudzba.Name = "lstNarudzba";
            this.lstNarudzba.Size = new System.Drawing.Size(165, 97);
            this.lstNarudzba.TabIndex = 13;
            this.lstNarudzba.UseCompatibleStateImageBehavior = false;
            this.lstNarudzba.View = System.Windows.Forms.View.Details;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(200, 214);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 14;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUkloni
            // 
            this.btnUkloni.Location = new System.Drawing.Point(200, 265);
            this.btnUkloni.Name = "btnUkloni";
            this.btnUkloni.Size = new System.Drawing.Size(75, 23);
            this.btnUkloni.TabIndex = 15;
            this.btnUkloni.Text = "Ukloni";
            this.btnUkloni.UseVisualStyleBackColor = true;
            this.btnUkloni.Click += new System.EventHandler(this.btnUkloni_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // Naziv
            // 
            this.Naziv.Text = "Naziv";
            this.Naziv.Width = 66;
            // 
            // ID_
            // 
            this.ID_.Text = "ID";
            this.ID_.Width = 40;
            // 
            // Naziv_
            // 
            this.Naziv_.Text = "Naziv";
            // 
            // Kolicina
            // 
            this.Kolicina.Text = "Količina";
            // 
            // DodajNarudzbenicu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 353);
            this.Controls.Add(this.btnUkloni);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lstNarudzba);
            this.Controls.Add(this.lstProizvodi);
            this.Controls.Add(this.lblKolicina);
            this.Controls.Add(this.nmKolicina);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnos);
            this.Name = "DodajNarudzbenicu";
            this.Text = "DodajNarudzbenicu";
            ((System.ComponentModel.ISupportInitialize)(this.nmKolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblDatum;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown nmKolicina;
        private System.Windows.Forms.Label lblKolicina;
        private System.Windows.Forms.ListView lstProizvodi;
        private System.Windows.Forms.ListView lstNarudzba;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUkloni;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Naziv;
        private System.Windows.Forms.ColumnHeader ID_;
        private System.Windows.Forms.ColumnHeader Naziv_;
        private System.Windows.Forms.ColumnHeader Kolicina;
    }
}