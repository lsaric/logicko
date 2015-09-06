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
            this.btnOsvjezi = new System.Windows.Forms.Button();
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
            this.dgvNarudzbenica.Location = new System.Drawing.Point(0, 0);
            this.dgvNarudzbenica.Name = "dgvNarudzbenica";
            this.dgvNarudzbenica.ReadOnly = true;
            this.dgvNarudzbenica.Size = new System.Drawing.Size(445, 188);
            this.dgvNarudzbenica.TabIndex = 0;
            // 
            // ID_narudzbenica
            // 
            this.ID_narudzbenica.HeaderText = "ID_narudzbenica";
            this.ID_narudzbenica.Name = "ID_narudzbenica";
            this.ID_narudzbenica.ReadOnly = true;
            // 
            // Kontakt
            // 
            this.Kontakt.HeaderText = "Kontakt";
            this.Kontakt.Name = "Kontakt";
            this.Kontakt.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // ImePrezime
            // 
            this.ImePrezime.HeaderText = "Ime Prezime";
            this.ImePrezime.Name = "ImePrezime";
            this.ImePrezime.ReadOnly = true;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(21, 208);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(173, 208);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(108, 33);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(325, 208);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(108, 33);
            this.btnOsvjezi.TabIndex = 3;
            this.btnOsvjezi.Text = "Osvjezi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // NarudzbenicaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 262);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.dgvNarudzbenica);
            this.Name = "NarudzbenicaPrikaz";
            this.Text = "NarudzbenicaPrikaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNarudzbenica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNarudzbenica;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_narudzbenica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kontakt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
    }
}