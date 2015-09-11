namespace Aplikacija_ZUSMR
{
    partial class VoditeljNabave
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
            this.narudzbenicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodacToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proizvodiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPoruka = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudzbenicaToolStripMenuItem,
            this.proizvodacToolStripMenuItem,
            this.proizvodiToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(403, 261);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // narudzbenicaToolStripMenuItem
            // 
            this.narudzbenicaToolStripMenuItem.AutoSize = false;
            this.narudzbenicaToolStripMenuItem.Name = "narudzbenicaToolStripMenuItem";
            this.narudzbenicaToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.narudzbenicaToolStripMenuItem.Size = new System.Drawing.Size(100, 258);
            this.narudzbenicaToolStripMenuItem.Text = "Narudžbenica";
            this.narudzbenicaToolStripMenuItem.Click += new System.EventHandler(this.narudzbenicaToolStripMenuItem_Click);
            // 
            // proizvodacToolStripMenuItem
            // 
            this.proizvodacToolStripMenuItem.AutoSize = false;
            this.proizvodacToolStripMenuItem.Name = "proizvodacToolStripMenuItem";
            this.proizvodacToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.proizvodacToolStripMenuItem.Size = new System.Drawing.Size(100, 258);
            this.proizvodacToolStripMenuItem.Text = "Proizvođač";
            this.proizvodacToolStripMenuItem.Click += new System.EventHandler(this.proizvodacToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.AutoSize = false;
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(100, 258);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            this.proizvodiToolStripMenuItem.Click += new System.EventHandler(this.proizvodiToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(90, 258);
            this.toolStripMenuItem1.Text = "Odjava";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPoruka});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(403, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPoruka
            // 
            this.statusPoruka.Name = "statusPoruka";
            this.statusPoruka.Size = new System.Drawing.Size(68, 17);
            this.statusPoruka.Text = "Dobrodošli!";
            // 
            // VoditeljNabave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VoditeljNabave";
            this.Text = "Voditelj nabave";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem narudzbenicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPoruka;

    }
}