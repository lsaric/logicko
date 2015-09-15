namespace Aplikacija_ZUSMR
{
    partial class DodajSkladiste
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblKapacitet = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtKapacitet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbJedinicaMjere = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(30, 195);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(151, 195);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(108, 33);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(27, 39);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(27, 68);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Location = new System.Drawing.Point(27, 138);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(52, 13);
            this.lblKapacitet.TabIndex = 4;
            this.lblKapacitet.Text = "Kapacitet";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 39);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(157, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(102, 68);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(157, 64);
            this.txtNaziv.TabIndex = 6;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(102, 138);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(157, 20);
            this.txtKapacitet.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Jedinica mjere";
            // 
            // cmbJedinicaMjere
            // 
            this.cmbJedinicaMjere.FormattingEnabled = true;
            this.cmbJedinicaMjere.Location = new System.Drawing.Point(102, 165);
            this.cmbJedinicaMjere.Name = "cmbJedinicaMjere";
            this.cmbJedinicaMjere.Size = new System.Drawing.Size(157, 21);
            this.cmbJedinicaMjere.TabIndex = 9;
            // 
            // DodajSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.cmbJedinicaMjere);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblKapacitet);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnos);
            this.Name = "DodajSkladiste";
            this.Text = "Dodaj skladište";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblKapacitet;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.TextBox txtNaziv;
        public System.Windows.Forms.TextBox txtKapacitet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbJedinicaMjere;

    }
}