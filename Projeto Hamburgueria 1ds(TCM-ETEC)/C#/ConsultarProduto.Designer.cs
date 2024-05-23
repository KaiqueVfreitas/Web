namespace HamburgueriaElvisBurguer
{
    partial class ConsultarProduto
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConsultarProduto = new System.Windows.Forms.Label();
            this.lbxConsultaProduto = new System.Windows.Forms.ListBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConsultarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HamburgueriaElvisBurguer.Properties.Resources.elvisBurguerBrancoHorizontal_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblConsultarProduto
            // 
            this.lblConsultarProduto.AutoSize = true;
            this.lblConsultarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultarProduto.Location = new System.Drawing.Point(184, 33);
            this.lblConsultarProduto.Name = "lblConsultarProduto";
            this.lblConsultarProduto.Size = new System.Drawing.Size(495, 46);
            this.lblConsultarProduto.TabIndex = 10;
            this.lblConsultarProduto.Text = "CONSULTAR PRODUTO";
            // 
            // lbxConsultaProduto
            // 
            this.lbxConsultaProduto.FormattingEnabled = true;
            this.lbxConsultaProduto.Location = new System.Drawing.Point(230, 127);
            this.lbxConsultaProduto.Name = "lbxConsultaProduto";
            this.lbxConsultaProduto.Size = new System.Drawing.Size(410, 186);
            this.lbxConsultaProduto.TabIndex = 11;
            this.lbxConsultaProduto.SelectedIndexChanged += new System.EventHandler(this.lbxConsultaProduto_SelectedIndexChanged);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(230, 336);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(161, 83);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConsultarProduto
            // 
            this.btnConsultarProduto.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnConsultarProduto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarProduto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultarProduto.Location = new System.Drawing.Point(479, 336);
            this.btnConsultarProduto.Name = "btnConsultarProduto";
            this.btnConsultarProduto.Size = new System.Drawing.Size(161, 83);
            this.btnConsultarProduto.TabIndex = 16;
            this.btnConsultarProduto.Text = "CONSULTAR";
            this.btnConsultarProduto.UseVisualStyleBackColor = false;
            // 
            // ConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(818, 427);
            this.Controls.Add(this.btnConsultarProduto);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lbxConsultaProduto);
            this.Controls.Add(this.lblConsultarProduto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConsultarProduto";
            this.Text = "ConsultarProduto";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConsultarProduto;
        private System.Windows.Forms.ListBox lbxConsultaProduto;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConsultarProduto;
    }
}