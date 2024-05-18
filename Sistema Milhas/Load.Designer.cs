
namespace Sistema_Milhas
{
    partial class Splash
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.prgSplash = new System.Windows.Forms.ProgressBar();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.lblCarregando = new System.Windows.Forms.Label();
            this.ptb_Avião = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avião)).BeginInit();
            this.SuspendLayout();
            // 
            // prgSplash
            // 
            this.prgSplash.Location = new System.Drawing.Point(28, 265);
            this.prgSplash.Name = "prgSplash";
            this.prgSplash.Size = new System.Drawing.Size(687, 23);
            this.prgSplash.TabIndex = 1;
            this.prgSplash.Click += new System.EventHandler(this.prgSplash_Click);
            // 
            // tmrSplash
            // 
            this.tmrSplash.Enabled = true;
            this.tmrSplash.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblCarregando
            // 
            this.lblCarregando.AutoSize = true;
            this.lblCarregando.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblCarregando.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblCarregando.Location = new System.Drawing.Point(332, 291);
            this.lblCarregando.Name = "lblCarregando";
            this.lblCarregando.Size = new System.Drawing.Size(81, 15);
            this.lblCarregando.TabIndex = 2;
            this.lblCarregando.Text = "Carregando...";
            // 
            // ptb_Avião
            // 
            this.ptb_Avião.Image = global::Sistema_Milhas.Properties.Resources.Splash_Aviao;
            this.ptb_Avião.Location = new System.Drawing.Point(-2, -2);
            this.ptb_Avião.Name = "ptb_Avião";
            this.ptb_Avião.Size = new System.Drawing.Size(742, 400);
            this.ptb_Avião.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_Avião.TabIndex = 0;
            this.ptb_Avião.TabStop = false;
            this.ptb_Avião.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 395);
            this.Controls.Add(this.lblCarregando);
            this.Controls.Add(this.prgSplash);
            this.Controls.Add(this.ptb_Avião);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form";
            ((System.ComponentModel.ISupportInitialize)(this.ptb_Avião)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_Avião;
        private System.Windows.Forms.ProgressBar prgSplash;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Label lblCarregando;
    }
}

