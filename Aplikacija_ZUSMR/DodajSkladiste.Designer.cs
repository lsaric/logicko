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
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(63, 191);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(75, 23);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(171, 191);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 1;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(39, 54);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(39, 96);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(34, 13);
            this.lblNaziv.TabIndex = 3;
            this.lblNaziv.Text = "Naziv";
            // 
            // lblKapacitet
            // 
            this.lblKapacitet.AutoSize = true;
            this.lblKapacitet.Location = new System.Drawing.Point(39, 135);
            this.lblKapacitet.Name = "lblKapacitet";
            this.lblKapacitet.Size = new System.Drawing.Size(52, 13);
            this.lblKapacitet.TabIndex = 4;
            this.lblKapacitet.Text = "Kapacitet";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 54);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 5;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(114, 96);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(100, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // txtKapacitet
            // 
            this.txtKapacitet.Location = new System.Drawing.Point(114, 135);
            this.txtKapacitet.Name = "txtKapacitet";
            this.txtKapacitet.Size = new System.Drawing.Size(100, 20);
            this.txtKapacitet.TabIndex = 7;
            // 
            // DodajSkladiste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtKapacitet);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblKapacitet);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnUnos);
            this.Name = "DodajSkladiste";
            this.Text = "DodajSkladiste";
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

    }
}