namespace Aplikacija_ZUSMR
{
    partial class ProizvodiPrikaz
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
            this.ID_proizvoda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivSkladista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NazivProizvodaca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToDeleteRows = false;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_proizvoda,
            this.Naziv,
            this.Cijena,
            this.Kolicina,
            this.NazivSkladista,
            this.NazivProizvodaca,
            this.Tip});
            this.dgvProizvodi.Location = new System.Drawing.Point(0, 0);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.ReadOnly = true;
            this.dgvProizvodi.Size = new System.Drawing.Size(745, 150);
            this.dgvProizvodi.TabIndex = 0;
            // 
            // ID_proizvoda
            // 
            this.ID_proizvoda.HeaderText = "ID";
            this.ID_proizvoda.Name = "ID_proizvoda";
            this.ID_proizvoda.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // NazivSkladista
            // 
            this.NazivSkladista.HeaderText = "Skladiste";
            this.NazivSkladista.Name = "NazivSkladista";
            this.NazivSkladista.ReadOnly = true;
            // 
            // NazivProizvodaca
            // 
            this.NazivProizvodaca.HeaderText = "Proizvodac";
            this.NazivProizvodaca.Name = "NazivProizvodaca";
            this.NazivProizvodaca.ReadOnly = true;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(577, 197);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(658, 197);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(658, 227);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvjezi.TabIndex = 4;
            this.btnOsvjezi.Text = "Osvjezi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // ProizvodiPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 262);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.dgvProizvodi);
            this.Name = "ProizvodiPrikaz";
            this.Text = "ProizvodiPrikaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_proizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivSkladista;
        private System.Windows.Forms.DataGridViewTextBoxColumn NazivProizvodaca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnOsvjezi;
    }
}