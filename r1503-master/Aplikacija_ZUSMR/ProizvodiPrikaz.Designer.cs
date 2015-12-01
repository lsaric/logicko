namespace Aplikacija_ZUSMR
{
    partial class nmbOd
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
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.cmbProizvodac = new System.Windows.Forms.ComboBox();
            this.cmbTip = new System.Windows.Forms.ComboBox();
            this.nmbOdC = new System.Windows.Forms.NumericUpDown();
            this.nmbDo = new System.Windows.Forms.NumericUpDown();
            this.ID_proizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jedinica_mjere = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivSkladista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivProizvodaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbOdC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_proizvoda,
            this.Naziv,
            this.Jedinica_mjere,
            this.Cijena,
            this.Kolicina,
            this.NazivSkladista,
            this.NazivProizvodaca,
            this.Tip});
            this.dgvProizvodi.Location = new System.Drawing.Point(16, 12);
            this.dgvProizvodi.MultiSelect = false;
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodi.Size = new System.Drawing.Size(717, 150);
            this.dgvProizvodi.TabIndex = 0;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(625, 225);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(625, 172);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(108, 33);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(315, 224);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(108, 33);
            this.btnPretraga.TabIndex = 5;
            this.btnPretraga.Text = "Pretraži";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cijena od:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Naziv:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Proizvođač:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tip:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(92, 172);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(155, 20);
            this.txtNaziv.TabIndex = 12;
            // 
            // cmbProizvodac
            // 
            this.cmbProizvodac.FormattingEnabled = true;
            this.cmbProizvodac.Location = new System.Drawing.Point(92, 198);
            this.cmbProizvodac.Name = "cmbProizvodac";
            this.cmbProizvodac.Size = new System.Drawing.Size(155, 21);
            this.cmbProizvodac.TabIndex = 13;
            // 
            // cmbTip
            // 
            this.cmbTip.FormattingEnabled = true;
            this.cmbTip.Location = new System.Drawing.Point(92, 225);
            this.cmbTip.Name = "cmbTip";
            this.cmbTip.Size = new System.Drawing.Size(155, 21);
            this.cmbTip.TabIndex = 14;
            // 
            // nmbOdC
            // 
            this.nmbOdC.Location = new System.Drawing.Point(315, 172);
            this.nmbOdC.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbOdC.Name = "nmbOdC";
            this.nmbOdC.Size = new System.Drawing.Size(108, 20);
            this.nmbOdC.TabIndex = 15;
            // 
            // nmbDo
            // 
            this.nmbDo.Location = new System.Drawing.Point(315, 198);
            this.nmbDo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmbDo.Name = "nmbDo";
            this.nmbDo.Size = new System.Drawing.Size(108, 20);
            this.nmbDo.TabIndex = 16;
            // 
            // ID_proizvoda
            // 
            this.ID_proizvoda.HeaderText = "Šifra proizvoda";
            this.ID_proizvoda.Name = "ID_proizvoda";
            this.ID_proizvoda.ReadOnly = true;
            this.ID_proizvoda.Width = 60;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 130;
            // 
            // Jedinica_mjere
            // 
            this.Jedinica_mjere.HeaderText = "Jedinica mjere";
            this.Jedinica_mjere.Name = "Jedinica_mjere";
            this.Jedinica_mjere.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            this.Cijena.Width = 70;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Količina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // NazivSkladista
            // 
            this.NazivSkladista.HeaderText = "Skladište";
            this.NazivSkladista.Name = "NazivSkladista";
            this.NazivSkladista.ReadOnly = true;
            this.NazivSkladista.Width = 90;
            // 
            // NazivProizvodaca
            // 
            this.NazivProizvodaca.HeaderText = "Proizvođač";
            this.NazivProizvodaca.Name = "NazivProizvodaca";
            this.NazivProizvodaca.ReadOnly = true;
            this.NazivProizvodaca.Width = 140;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            this.Tip.Width = 110;
            // 
            // nmbOd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 262);
            this.Controls.Add(this.nmbDo);
            this.Controls.Add(this.nmbOdC);
            this.Controls.Add(this.cmbTip);
            this.Controls.Add(this.cmbProizvodac);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.dgvProizvodi);
            this.Name = "nmbOd";
            this.Text = "Prikaz proizvoda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbOdC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmbDo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.ComboBox cmbProizvodac;
        private System.Windows.Forms.ComboBox cmbTip;
        private System.Windows.Forms.NumericUpDown nmbOdC;
        private System.Windows.Forms.NumericUpDown nmbDo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_proizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jedinica_mjere;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivSkladista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivProizvodaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
    }
}