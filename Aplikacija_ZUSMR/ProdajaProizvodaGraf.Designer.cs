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
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(259, 31);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(136, 33);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Prikaz";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cmbProizvodi
            // 
            this.cmbProizvodi.FormattingEnabled = true;
            this.cmbProizvodi.Location = new System.Drawing.Point(27, 31);
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
            this.graf.Location = new System.Drawing.Point(27, 82);
            this.graf.Name = "graf";
            this.graf.Size = new System.Drawing.Size(368, 237);
            this.graf.TabIndex = 0;
            // 
            // ProdajaProizvodaGraf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 331);
            this.Controls.Add(this.cmbProizvodi);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.graf);
            this.Name = "ProdajaProizvodaGraf";
            this.Text = "Graf prodaje proizvoda";
            this.Load += new System.EventHandler(this.ProdajaProizvodaGraf_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ucGraph graf;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ComboBox cmbProizvodi;
        private System.Windows.Forms.Timer timer1;
    }
}