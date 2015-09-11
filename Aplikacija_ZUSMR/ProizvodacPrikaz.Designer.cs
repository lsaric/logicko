namespace Aplikacija_ZUSMR
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
            this.dgvProizvodac.MultiSelect = false;
            this.dgvProizvodac.Name = "dgvProizvodac";
            this.dgvProizvodac.ReadOnly = true;
            this.dgvProizvodac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProizvodac.Size = new System.Drawing.Size(281, 150);
            this.dgvProizvodac.TabIndex = 0;
            // 
            // ID_proizvodac
            // 
            this.ID_proizvodac.HeaderText = "Šifra proizvođača";
            this.ID_proizvodac.Name = "ID_proizvodac";
            this.ID_proizvodac.ReadOnly = true;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 130;
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(21, 170);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 1;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(151, 217);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(108, 33);
            this.btnUredi.TabIndex = 2;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // ProizvodacPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Controls.Add(this.dgvProizvodac);
            this.Name = "ProizvodacPrikaz";
            this.Text = "Prikaz proizvođača";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProizvodac;
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_proizvodac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}