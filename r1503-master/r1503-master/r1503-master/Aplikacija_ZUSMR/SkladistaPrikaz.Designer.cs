namespace Aplikacija_ZUSMR
{
    partial class SkladistaPrikaz
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
            this.dgvSkladista = new System.Windows.Forms.DataGridView();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.ID_skaldista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kapacitet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSkladista
            // 
            this.dgvSkladista.AllowUserToDeleteRows = false;
            this.dgvSkladista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSkladista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_skaldista,
            this.Naziv,
            this.Kapacitet});
            this.dgvSkladista.Location = new System.Drawing.Point(12, 12);
            this.dgvSkladista.MultiSelect = false;
            this.dgvSkladista.Name = "dgvSkladista";
            this.dgvSkladista.ReadOnly = true;
            this.dgvSkladista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSkladista.Size = new System.Drawing.Size(720, 150);
            this.dgvSkladista.TabIndex = 0;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(12, 183);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(139, 183);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(108, 33);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // ID_skaldista
            // 
            this.ID_skaldista.HeaderText = "Šifra skladišta";
            this.ID_skaldista.Name = "ID_skaldista";
            this.ID_skaldista.ReadOnly = true;
            this.ID_skaldista.Width = 150;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 300;
            // 
            // Kapacitet
            // 
            this.Kapacitet.HeaderText = "Kapacitet";
            this.Kapacitet.Name = "Kapacitet";
            this.Kapacitet.ReadOnly = true;
            this.Kapacitet.Width = 200;
            // 
            // SkladistaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 262);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.dgvSkladista);
            this.Name = "SkladistaPrikaz";
            this.Text = "Prikaz skladišta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSkladista)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSkladista;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_skaldista;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kapacitet;
    }
}