namespace Aplikacija_ZUSMR
{
    partial class NarudzbenicaPrikaz
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
            this.dgvNarudzbenica = new System.Windows.Forms.DataGridView();
            this.ID_narudzbenica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kontakt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenica)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNarudzbenica
            // 
            this.dgvNarudzbenica.AllowUserToDeleteRows = false;
            this.dgvNarudzbenica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNarudzbenica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_narudzbenica,
            this.Kontakt,
            this.Datum,
            this.ImePrezime});
            this.dgvNarudzbenica.Location = new System.Drawing.Point(12, 12);
            this.dgvNarudzbenica.MultiSelect = false;
            this.dgvNarudzbenica.Name = "dgvNarudzbenica";
            this.dgvNarudzbenica.ReadOnly = true;
            this.dgvNarudzbenica.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNarudzbenica.Size = new System.Drawing.Size(721, 173);
            this.dgvNarudzbenica.TabIndex = 0;
            // 
            // ID_narudzbenica
            // 
            this.ID_narudzbenica.HeaderText = "Šifra narudžbenice";
            this.ID_narudzbenica.Name = "ID_narudzbenica";
            this.ID_narudzbenica.ReadOnly = true;
            this.ID_narudzbenica.Width = 150;
            // 
            // Kontakt
            // 
            this.Kontakt.HeaderText = "Kontakt";
            this.Kontakt.Name = "Kontakt";
            this.Kontakt.ReadOnly = true;
            this.Kontakt.Width = 200;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            this.Datum.Width = 120;
            // 
            // ImePrezime
            // 
            this.ImePrezime.HeaderText = "Ime Prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            this.ImePrezime.Width = 200;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(12, 203);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(143, 203);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(108, 33);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // NarudzbenicaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 262);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.dgvNarudzbenica);
            this.Name = "NarudzbenicaPrikaz";
            this.Text = "Prikaz narudžbenice";
            this.Load += new System.EventHandler(this.NarudzbenicaPrikaz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbenica;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_narudzbenica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
    }
}