
namespace Sistema_Milhas
{
    partial class fmrMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmrMenu));
            this.btn_CadastrarCliente = new System.Windows.Forms.Button();
            this.btn_CadastrarViagem = new System.Windows.Forms.Button();
            this.btn_ConsultarCliente = new System.Windows.Forms.Button();
            this.btn_ConsultarViagem = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viagemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viagemToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viagemToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblViagem = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CadastrarCliente
            // 
            this.btn_CadastrarCliente.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_CadastrarCliente.Location = new System.Drawing.Point(79, 79);
            this.btn_CadastrarCliente.Name = "btn_CadastrarCliente";
            this.btn_CadastrarCliente.Size = new System.Drawing.Size(110, 49);
            this.btn_CadastrarCliente.TabIndex = 0;
            this.btn_CadastrarCliente.Text = "CADASTRAR";
            this.btn_CadastrarCliente.UseVisualStyleBackColor = true;
            this.btn_CadastrarCliente.Click += new System.EventHandler(this.btn_Cadastrar_Click);
            // 
            // btn_CadastrarViagem
            // 
            this.btn_CadastrarViagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_CadastrarViagem.Location = new System.Drawing.Point(279, 79);
            this.btn_CadastrarViagem.Name = "btn_CadastrarViagem";
            this.btn_CadastrarViagem.Size = new System.Drawing.Size(110, 49);
            this.btn_CadastrarViagem.TabIndex = 2;
            this.btn_CadastrarViagem.Text = "CADASTRAR";
            this.btn_CadastrarViagem.UseVisualStyleBackColor = true;
            this.btn_CadastrarViagem.Click += new System.EventHandler(this.btn_CadastrarViagem_Click);
            // 
            // btn_ConsultarCliente
            // 
            this.btn_ConsultarCliente.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btn_ConsultarCliente.Location = new System.Drawing.Point(79, 149);
            this.btn_ConsultarCliente.Name = "btn_ConsultarCliente";
            this.btn_ConsultarCliente.Size = new System.Drawing.Size(110, 49);
            this.btn_ConsultarCliente.TabIndex = 3;
            this.btn_ConsultarCliente.Text = "CONSULTAR";
            this.btn_ConsultarCliente.UseVisualStyleBackColor = true;
            this.btn_ConsultarCliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ConsultarViagem
            // 
            this.btn_ConsultarViagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_ConsultarViagem.Location = new System.Drawing.Point(279, 149);
            this.btn_ConsultarViagem.Name = "btn_ConsultarViagem";
            this.btn_ConsultarViagem.Size = new System.Drawing.Size(110, 49);
            this.btn_ConsultarViagem.TabIndex = 4;
            this.btn_ConsultarViagem.Text = "CONSULTAR";
            this.btn_ConsultarViagem.UseVisualStyleBackColor = true;
            this.btn_ConsultarViagem.Click += new System.EventHandler(this.btn_ConsultarViagem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viagemToolStripMenuItem,
            this.viagemToolStripMenuItem1});
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cadastrosToolStripMenuItem.Text = "CADASTROS:";
            // 
            // viagemToolStripMenuItem
            // 
            this.viagemToolStripMenuItem.Name = "viagemToolStripMenuItem";
            this.viagemToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viagemToolStripMenuItem.Text = "Cliente";
            this.viagemToolStripMenuItem.Click += new System.EventHandler(this.viagemToolStripMenuItem_Click);
            // 
            // viagemToolStripMenuItem1
            // 
            this.viagemToolStripMenuItem1.Name = "viagemToolStripMenuItem1";
            this.viagemToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.viagemToolStripMenuItem1.Text = "Viagem";
            this.viagemToolStripMenuItem1.Click += new System.EventHandler(this.viagemToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.viagemToolStripMenuItem2});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.consultasToolStripMenuItem.Text = "CONSULTAS:";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // viagemToolStripMenuItem2
            // 
            this.viagemToolStripMenuItem2.Name = "viagemToolStripMenuItem2";
            this.viagemToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.viagemToolStripMenuItem2.Text = "Viagem";
            this.viagemToolStripMenuItem2.Click += new System.EventHandler(this.viagemToolStripMenuItem2_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(103, 50);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(55, 13);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "CLIENTE:";
            // 
            // lblViagem
            // 
            this.lblViagem.AutoSize = true;
            this.lblViagem.Location = new System.Drawing.Point(303, 50);
            this.lblViagem.Name = "lblViagem";
            this.lblViagem.Size = new System.Drawing.Size(51, 13);
            this.lblViagem.TabIndex = 8;
            this.lblViagem.Text = "VIAGEM:";
            // 
            // fmrMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(474, 231);
            this.Controls.Add(this.lblViagem);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_ConsultarViagem);
            this.Controls.Add(this.btn_ConsultarCliente);
            this.Controls.Add(this.btn_CadastrarViagem);
            this.Controls.Add(this.btn_CadastrarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmrMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CadastrarCliente;
        private System.Windows.Forms.Button btn_CadastrarViagem;
        private System.Windows.Forms.Button btn_ConsultarCliente;
        private System.Windows.Forms.Button btn_ConsultarViagem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viagemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viagemToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viagemToolStripMenuItem2;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblViagem;
    }
}