namespace Aplikacija_ZUSMR
{
    partial class Tip_zaposlenja
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
            this.dgvTipZaposlenja = new System.Windows.Forms.DataGridView();
            this.ID_zaposlenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Opis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipZaposlenja)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipZaposlenja
            // 
            this.dgvTipZaposlenja.AllowUserToDeleteRows = false;
            this.dgvTipZaposlenja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipZaposlenja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_zaposlenja,
            this.Opis});
            this.dgvTipZaposlenja.Location = new System.Drawing.Point(32, 3);
            this.dgvTipZaposlenja.Name = "dgvTipZaposlenja";
            this.dgvTipZaposlenja.ReadOnly = true;
            this.dgvTipZaposlenja.Size = new System.Drawing.Size(278, 150);
            this.dgvTipZaposlenja.TabIndex = 0;
            // 
            // ID_zaposlenja
            // 
            this.ID_zaposlenja.HeaderText = "ID zaposlenja";
            this.ID_zaposlenja.Name = "ID_zaposlenja";
            this.ID_zaposlenja.ReadOnly = true;
            // 
            // Opis
            // 
            this.Opis.HeaderText = "Opis";
            this.Opis.Name = "Opis";
            this.Opis.ReadOnly = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(53, 199);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(134, 199);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(224, 199);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(134, 228);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvjezi.TabIndex = 4;
            this.btnOsvjezi.Text = "Osvjezi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // Tip_zaposlenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 262);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvTipZaposlenja);
            this.Name = "Tip_zaposlenja";
            this.Text = "Tip_zaposlenja";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipZaposlenja)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipZaposlenja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_zaposlenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn Opis;
        private System.Windows.Forms.Button btnOsvjezi;
    }
}