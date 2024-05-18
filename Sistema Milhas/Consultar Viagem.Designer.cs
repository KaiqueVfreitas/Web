
namespace Sistema_Milhas
{
    partial class fmr_ConsultarViagem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmr_ConsultarViagem));
            this.lb_Lista = new System.Windows.Forms.CheckedListBox();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Lista
            // 
            this.lb_Lista.FormattingEnabled = true;
            this.lb_Lista.Location = new System.Drawing.Point(80, 12);
            this.lb_Lista.Name = "lb_Lista";
            this.lb_Lista.Size = new System.Drawing.Size(578, 274);
            this.lb_Lista.TabIndex = 0;
            this.lb_Lista.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Consultar.Location = new System.Drawing.Point(80, 292);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(115, 47);
            this.btn_Consultar.TabIndex = 1;
            this.btn_Consultar.Text = "CONSULTAR";
            this.btn_Consultar.UseVisualStyleBackColor = true;
            this.btn_Consultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_Voltar.Location = new System.Drawing.Point(543, 292);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(115, 47);
            this.btn_Voltar.TabIndex = 2;
            this.btn_Voltar.Text = "VOLTAR";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // fmr_ConsultarViagem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 351);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Consultar);
            this.Controls.Add(this.lb_Lista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fmr_ConsultarViagem";
            this.Text = "Consultar Viagem:";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lb_Lista;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Voltar;
    }
}