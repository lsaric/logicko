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
            this.grafToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zaposleniciToolStripMenuItem,
            this.tipZaposlenjaToolStripMenuItem,
            this.grafToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 264);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zaposleniciToolStripMenuItem
            // 
            this.zaposleniciToolStripMenuItem.AutoSize = false;
            this.zaposleniciToolStripMenuItem.Name = "zaposleniciToolStripMenuItem";
            this.zaposleniciToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.zaposleniciToolStripMenuItem.Size = new System.Drawing.Size(94, 258);
            this.zaposleniciToolStripMenuItem.Text = "Zaposlenici";
            this.zaposleniciToolStripMenuItem.Click += new System.EventHandler(this.zaposleniciToolStripMenuItem_Click);
            // 
            // tipZaposlenjaToolStripMenuItem
            // 
            this.tipZaposlenjaToolStripMenuItem.Name = "tipZaposlenjaToolStripMenuItem";
            this.tipZaposlenjaToolStripMenuItem.Size = new System.Drawing.Size(94, 260);
            this.tipZaposlenjaToolStripMenuItem.Text = "Tip zaposlenja";
            this.tipZaposlenjaToolStripMenuItem.Click += new System.EventHandler(this.tipZaposlenjaToolStripMenuItem_Click);
            // 
            // grafToolStripMenuItem
            // 
            this.grafToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.grafToolStripMenuItem.AutoSize = false;
            this.grafToolStripMenuItem.Name = "grafToolStripMenuItem";
            this.grafToolStripMenuItem.Size = new System.Drawing.Size(90, 258);
            this.grafToolStripMenuItem.Text = "Graf";
            this.grafToolStripMenuItem.Click += new System.EventHandler(this.grafToolStripMenuItem_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Administrator";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zaposleniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipZaposlenjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafToolStripMenuItem;

    }
}