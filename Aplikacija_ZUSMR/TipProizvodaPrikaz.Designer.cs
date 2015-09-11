namespace Aplikacija_ZUSMR
{
    partial class TipProizvodaPrikaz
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
            this.dgvTipProizvoda = new System.Windows.Forms.DataGridView();
            this.ID_tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipProizvoda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.Location = new System.Drawing.Point(12, 183);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(108, 33);
            this.btnUnos.TabIndex = 0;
            this.btnUnos.Text = "Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.Location = new System.Drawing.Point(139, 183);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(108, 33);
            this.btnUredi.TabIndex = 1;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = true;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // dgvTipProizvoda
            // 
            this.dgvTipProizvoda.AllowUserToDeleteRows = false;
            this.dgvTipProizvoda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipProizvoda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_tip,
            this.Tip});
            this.dgvTipProizvoda.Location = new System.Drawing.Point(12, 15);
            this.dgvTipProizvoda.MultiSelect = false;
            this.dgvTipProizvoda.Name = "dgvTipProizvoda";
            this.dgvTipProizvoda.ReadOnly = true;
            this.dgvTipProizvoda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipProizvoda.Size = new System.Drawing.Size(719, 150);
            this.dgvTipProizvoda.TabIndex = 4;
            // 
            // ID_tip
            // 
            this.ID_tip.HeaderText = "Šifra tipa";
            this.ID_tip.Name = "ID_tip";
            this.ID_tip.ReadOnly = true;
            this.ID_tip.Width = 150;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            this.Tip.Width = 300;
            // 
            // TipProizvodaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 262);
            this.Controls.Add(this.dgvTipProizvoda);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnUnos);
            this.Name = "TipProizvodaPrikaz";
            this.Text = "Prikaz tipa proizvoda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipProizvoda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.DataGridView dgvTipProizvoda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
    }
}