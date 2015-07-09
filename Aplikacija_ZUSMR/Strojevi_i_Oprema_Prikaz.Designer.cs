namespace Aplikacija_ZUSMR
{
    partial class Strojevi_i_Oprema_Prikaz
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
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            this.dgvStrojevi = new System.Windows.Forms.DataGridView();
            this.ID_strojeva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrojevi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(108, 170);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(189, 170);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 1;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(270, 170);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 2;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(1, 170);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvjezi.TabIndex = 3;
            this.btnOsvjezi.Text = "Osvjezi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // dgvStrojevi
            // 
            this.dgvStrojevi.AllowUserToDeleteRows = false;
            this.dgvStrojevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrojevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_strojeva,
            this.Tip,
            this.Naziv});
            this.dgvStrojevi.Location = new System.Drawing.Point(1, 0);
            this.dgvStrojevi.Name = "dgvStrojevi";
            this.dgvStrojevi.ReadOnly = true;
            this.dgvStrojevi.Size = new System.Drawing.Size(344, 150);
            this.dgvStrojevi.TabIndex = 4;
            // 
            // ID_strojeva
            // 
            this.ID_strojeva.HeaderText = "ID strojeva/opreme";
            this.ID_strojeva.Name = "ID_strojeva";
            this.ID_strojeva.ReadOnly = true;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Strojevi_i_Oprema_Prikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 262);
            this.Controls.Add(this.dgvStrojevi);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Name = "Strojevi_i_Oprema_Prikaz";
            this.Text = "Strojevi_i_Oprema_Prikaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrojevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOsvjezi;
        private System.Windows.Forms.DataGridView dgvStrojevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_strojeva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}