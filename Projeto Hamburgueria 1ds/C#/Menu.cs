using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueriaElvisBurguer
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadpro = new CadastrarProduto();
            cadpro.Show();
            this.Hide();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadCli = new CadastrarCliente();
            cadCli.Show();
            this.Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarCliente cadCli = new CadastrarCliente();
            cadCli.Show();
            this.Hide();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastrarProduto cadpro = new CadastrarProduto();
            cadpro.Show();
            this.Hide();
        }

        private void ConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente concli = new ConsultarCliente();
            concli.Show();
            this.Hide();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarCliente concli = new ConsultarCliente();
            concli.Show();
            this.Hide();
        }

        private void btnConsultarProduto_Click(object sender, EventArgs e)
        {
            ConsultarProduto conpro = new ConsultarProduto();
            conpro.Show();
            this.Hide();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarProduto conpro = new ConsultarProduto();
            conpro.Show();
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            /*VAI APARECER A MENSAGEM SE REALMENTE DESEJA SAIR DO SISTEMA*/
            if (MessageBox.Show("Deseja mesmo sair? ", "Mensagem ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //SAI DA APLICAÇÃO
                Application.Exit();
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
