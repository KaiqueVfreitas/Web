using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueriaElvisBurguer
{
    public partial class CadastrarProduto : Form        
    {
        string caminho = @"C:\Users\User\Desktop\HamburgueriaElvisBurguer\produtos.txt";
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void lblCodigoProduto_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            if (txtNomeProduto.Text == "" && txtCodigoProduto.Text == "")
            {
                MessageBox.Show("Obrigatório preenhecer todos os campos");
            }
            else
            {
                StreamWriter sw = new StreamWriter(caminho, true);
                sw.WriteLine(txtNomeProduto.Text);
                sw.WriteLine(txtCodigoProduto.Text);
                sw.WriteLine("**************");
                MessageBox.Show("Produto cadastrado com sucesso!");
                sw.Close();
                                
                txtNomeProduto.Clear();
                txtCodigoProduto.Clear();
            }
        }
    }
}
