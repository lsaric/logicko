namespace Aplikacija_ZUSMR
{
    partial class ProdajaProizvodaGraf
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
            this.components = new System.ComponentModel.Container();
            this.btnPlay = new System.Windows.Forms.Button();
            this.cmbProizvodi = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.graf = new Aplikacija_ZUSMR.ucGraph();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(22, 40);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(162, 33);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Prikaz";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cmbProizvodi
            // 
            this.cmbProizvodi.FormattingEnabled = true;
            this.cmbProizvodi.Location = new System.Drawing.Point(22, 108);
            this.cmbProizvodi.Name = "cmbProizvodi";
            this.cmbProizvodi.Size = new System.Drawing.Size(162, 21);
            this.cmbProizvodi.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // graf
            // 
            this.graf.Data = null;
            this.graf.Location = new System.Drawing.Point(233, 40);
            this.graf.Name = "graf";
            this.graf.Size = new System.Drawing.Size(486, 210);
            this.graf.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Proizvod";
            // 
            // ProdajaProizvodaGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbProizvodi);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.graf);
            this.Name = "ProdajaProizvodaGraf";
            this.Text = "Graf prodaje proizvoda";
            this.Load += new System.EventHandler(this.ProdajaProizvodaGraf_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ucGraph graf;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cmbProizvodi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}