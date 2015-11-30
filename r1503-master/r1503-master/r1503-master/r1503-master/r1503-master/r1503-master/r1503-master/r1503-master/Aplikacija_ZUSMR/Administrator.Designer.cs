namespace Aplikacija_ZUSMR
{
    partial class Administrator
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
            this.zaposleniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipZaposlenjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Odjava = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusPoruka = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniciToolStripMenuItem,
            this.tipZaposlenjaToolStripMenuItem,
            this.Odjava});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            this.zaposleniciToolStripMenuItem.Click += new System.EventHandler(this.zaposleniciToolStripMenuItem_Click);
            // 
            // tipZaposlenjaToolStripMenuItem
            // 
            this.tipZaposlenjaToolStripMenuItem.Name = "tipZaposlenjaToolStripMenuItem";
            this.tipZaposlenjaToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.tipZaposlenjaToolStripMenuItem.Text = "Tip zaposlenja";
            this.tipZaposlenjaToolStripMenuItem.Click += new System.EventHandler(this.tipZaposlenjaToolStripMenuItem_Click);
            // 
            // Odjava
            // 
            this.Odjava.Name = "Odjava";
            this.Odjava.Size = new System.Drawing.Size(56, 20);
            this.Odjava.Text = "Odjava";
            this.Odjava.Click += new System.EventHandler(this.Odjava_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusPoruka});
            this.statusStrip1.Location = new System.Drawing.Point(0, 290);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusPoruka
            // 
            this.statusPoruka.Name = "statusPoruka";
            this.statusPoruka.Size = new System.Drawing.Size(68, 17);
            this.statusPoruka.Text = "Dobrodošli!";
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 312);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipZaposlenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Odjava;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusPoruka;

    }
}