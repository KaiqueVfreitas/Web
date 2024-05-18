namespace HamburgueriaElvisBurguer
{
    partial class ConsultarCliente
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
            this.lbxConsultarCliente = new System.Windows.Forms.ListBox();
            this.lblConsultaCliente = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
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
            // lbxConsultarCliente
            // 
            this.lbxConsultarCliente.FormattingEnabled = true;
            this.lbxConsultarCliente.Location = new System.Drawing.Point(231, 122);
            this.lbxConsultarCliente.Name = "lbxConsultarCliente";
            this.lbxConsultarCliente.Size = new System.Drawing.Size(410, 186);
            this.lbxConsultarCliente.TabIndex = 12;
            this.lbxConsultarCliente.SelectedIndexChanged += new System.EventHandler(this.lbxConsultaProduto_SelectedIndexChanged);
            // 
            // lblConsultaCliente
            // 
            this.lblConsultaCliente.AutoSize = true;
            this.lblConsultaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultaCliente.Location = new System.Drawing.Point(191, 33);
            this.lblConsultaCliente.Name = "lblConsultaCliente";
            this.lblConsultaCliente.Size = new System.Drawing.Size(463, 46);
            this.lblConsultaCliente.TabIndex = 13;
            this.lblConsultaCliente.Text = "CONSULTAR CLIENTE";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnVoltar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnVoltar.Location = new System.Drawing.Point(231, 332);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(161, 83);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.Text = "VOLTAR";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnConsultarCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnConsultarCliente.Location = new System.Drawing.Point(480, 332);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(161, 83);
            this.btnConsultarCliente.TabIndex = 16;
            this.btnConsultarCliente.Text = "CONSULTAR";
            this.btnConsultarCliente.UseVisualStyleBackColor = false;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // ConsultarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.ClientSize = new System.Drawing.Size(818, 427);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblConsultaCliente);
            this.Controls.Add(this.lbxConsultarCliente);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ConsultarCliente";
            this.Text = "ConsultarCliente";
            this.Load += new System.EventHandler(this.ConsultarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox lbxConsultarCliente;
        private System.Windows.Forms.Label lblConsultaCliente;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnConsultarCliente;
    }
}