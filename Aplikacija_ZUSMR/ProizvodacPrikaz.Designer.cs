﻿namespace Aplikacija_ZUSMR
{
    partial class ProizvodacPrikaz
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
            this.dgvProizvodac = new System.Windows.Forms.DataGridView();
            this.ID_proizvodac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnOsvjezi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodac)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProizvodac
            // 
            this.dgvProizvodac.AllowUserToDeleteRows = false;
            this.dgvProizvodac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_proizvodac,
            this.Naziv});
            this.dgvProizvodac.Location = new System.Drawing.Point(1, 0);
            this.dgvProizvodac.Name = "dgvProizvodac";
            this.dgvProizvodac.ReadOnly = true;
            this.dgvProizvodac.Size = new System.Drawing.Size(240, 150);
            this.dgvProizvodac.TabIndex = 0;
            // 
            // ID_proizvodac
            // 
            this.ID_proizvodac.HeaderText = "ID";
            this.ID_proizvodac.Name = "ID_proizvodac";
            this.ID_proizvodac.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(12, 170);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(108, 170);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(75, 23);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(207, 170);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 3;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnOsvjezi
            // 
            this.btnOsvjezi.Location = new System.Drawing.Point(12, 227);
            this.btnOsvjezi.Name = "btnOsvjezi";
            this.btnOsvjezi.Size = new System.Drawing.Size(75, 23);
            this.btnOsvjezi.TabIndex = 4;
            this.btnOsvjezi.Text = "Osvjezi";
            this.btnOsvjezi.UseVisualStyleBackColor = true;
            this.btnOsvjezi.Click += new System.EventHandler(this.btnOsvjezi_Click);
            // 
            // ProizvodacPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnOsvjezi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.dgvProizvodac);
            this.Name = "ProizvodacPrikaz";
            this.Text = "ProizvodacPrikaz";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodac;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_proizvodac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnOsvjezi;
    }
}