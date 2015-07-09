namespace Aplikacija_ZUSMR
{
    partial class VoditeljSkladista
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.strojeviIOpremaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladišteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prikazStanjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strojeviIOpremaToolStripMenuItem,
            this.skladišteToolStripMenuItem,
            this.proizvodiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // strojeviIOpremaToolStripMenuItem
            // 
            this.strojeviIOpremaToolStripMenuItem.Name = "strojeviIOpremaToolStripMenuItem";
            this.strojeviIOpremaToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.strojeviIOpremaToolStripMenuItem.Text = "Strojevi i oprema";
            this.strojeviIOpremaToolStripMenuItem.Click += new System.EventHandler(this.strojeviIOpremaToolStripMenuItem_Click);
            // 
            // skladišteToolStripMenuItem
            // 
            this.skladišteToolStripMenuItem.Name = "skladišteToolStripMenuItem";
            this.skladišteToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.skladišteToolStripMenuItem.Text = "Skladište";
            this.skladišteToolStripMenuItem.Click += new System.EventHandler(this.skladišteToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipProizvodaToolStripMenuItem,
            this.pretragaProizvodaToolStripMenuItem,
            this.prikazStanjaToolStripMenuItem});
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            // 
            // tipProizvodaToolStripMenuItem
            // 
            this.tipProizvodaToolStripMenuItem.Name = "tipProizvodaToolStripMenuItem";
            this.tipProizvodaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.tipProizvodaToolStripMenuItem.Text = "Tip proizvoda";
            this.tipProizvodaToolStripMenuItem.Click += new System.EventHandler(this.tipProizvodaToolStripMenuItem_Click);
            // 
            // pretragaProizvodaToolStripMenuItem
            // 
            this.pretragaProizvodaToolStripMenuItem.Name = "pretragaProizvodaToolStripMenuItem";
            this.pretragaProizvodaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.pretragaProizvodaToolStripMenuItem.Text = "Pretraga proizvoda";
            // 
            // prikazStanjaToolStripMenuItem
            // 
            this.prikazStanjaToolStripMenuItem.Name = "prikazStanjaToolStripMenuItem";
            this.prikazStanjaToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.prikazStanjaToolStripMenuItem.Text = "Prikaz stanja";
            // 
            // VoditeljSkladista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VoditeljSkladista";
            this.Text = "VoditeljSkladista";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem strojeviIOpremaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skladišteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prikazStanjaToolStripMenuItem;
    }
}