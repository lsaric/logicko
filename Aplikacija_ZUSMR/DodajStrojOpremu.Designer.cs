﻿namespace Aplikacija_ZUSMR
{
    partial class DodajStrojOpremu
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
            this.cmbNaziv = new System.Windows.Forms.ComboBox();
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbNaziv
            // 
            this.cmbNaziv.FormattingEnabled = true;
            this.cmbNaziv.Location = new System.Drawing.Point(130, 148);
            this.cmbNaziv.Name = "cmbNaziv";
            this.cmbNaziv.Size = new System.Drawing.Size(121, 21);
            this.cmbNaziv.TabIndex = 0;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(43, 196);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(157, 196);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 2;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tip ";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(31, 151);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(78, 13);
            this.lblNaziv.TabIndex = 5;
            this.lblNaziv.Text = "Naziv skladista";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(130, 94);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(121, 20);
            this.txtTip.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 54);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 7;
            // 
            // DodajStrojOpremu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.cmbNaziv);
            this.Name = "DodajStrojOpremu";
            this.Text = "DodajStrojOpremu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNaziv;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNaziv;
        public System.Windows.Forms.TextBox txtTip;
        public System.Windows.Forms.TextBox txtID;
    }
}