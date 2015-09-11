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
            this.dgvStrojevi = new System.Windows.Forms.DataGridView();
            this.ID_strojeva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrojevi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(12, 182);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(138, 182);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(108, 33);
            this.btnUredi.TabIndex = 1;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // dgvStrojevi
            // 
            this.dgvStrojevi.AllowUserToDeleteRows = false;
            this.dgvStrojevi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrojevi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_strojeva,
            this.Tip,
            this.Naziv});
            this.dgvStrojevi.Location = new System.Drawing.Point(12, 12);
            this.dgvStrojevi.MultiSelect = false;
            this.dgvStrojevi.Name = "dgvStrojevi";
            this.dgvStrojevi.ReadOnly = true;
            this.dgvStrojevi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStrojevi.Size = new System.Drawing.Size(720, 150);
            this.dgvStrojevi.TabIndex = 4;
            // 
            // ID_strojeva
            // 
            this.ID_strojeva.HeaderText = "ID strojeva/opreme";
            this.ID_strojeva.Name = "ID_strojeva";
            this.ID_strojeva.ReadOnly = true;
            this.ID_strojeva.Width = 150;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            this.Tip.Width = 250;
            // 
            // Naziv
            // 
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            this.Naziv.Width = 250;
            // 
            // Strojevi_i_Oprema_Prikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 262);
            this.Controls.Add(this.dgvStrojevi);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Name = "Strojevi_i_Oprema_Prikaz";
            this.Text = "Prikaz strojeva i opreme";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrojevi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridView dgvStrojevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_strojeva;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
    }
}