﻿namespace Aplikacija_ZUSMR
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.narudzbenicaToolStripMenuItem,
            this.proizvodacToolStripMenuItem,
            this.proizvodiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // narudzbenicaToolStripMenuItem
            // 
            this.narudzbenicaToolStripMenuItem.Name = "narudzbenicaToolStripMenuItem";
            this.narudzbenicaToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.narudzbenicaToolStripMenuItem.Text = "Narudzbenica";
            this.narudzbenicaToolStripMenuItem.Click += new System.EventHandler(this.narudzbenicaToolStripMenuItem_Click);
            // 
            // proizvodacToolStripMenuItem
            // 
            this.proizvodacToolStripMenuItem.Name = "proizvodacToolStripMenuItem";
            this.proizvodacToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.proizvodacToolStripMenuItem.Text = "Proizvodac";
            this.proizvodacToolStripMenuItem.Click += new System.EventHandler(this.proizvodacToolStripMenuItem_Click);
            // 
            // proizvodiToolStripMenuItem
            // 
            this.proizvodiToolStripMenuItem.Name = "proizvodiToolStripMenuItem";
            this.proizvodiToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.proizvodiToolStripMenuItem.Text = "Proizvodi";
            // 
            // VoditeljNabave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VoditeljNabave";
            this.Text = "VoditeljNabave";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem narudzbenicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodacToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proizvodiToolStripMenuItem;

    }
}