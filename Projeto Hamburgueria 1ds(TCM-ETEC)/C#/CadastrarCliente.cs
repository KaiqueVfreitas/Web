using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HamburgueriaElvisBurguer
{
    public partial class CadastrarCliente : Form        
    {
        string caminho = @"C:Users\User\Desktop\HamburgueriaElvisBurguer\dados\clientes.txt";
        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            //SE OS CAMPOS ESTIVEREM VAZIOS
            if (txtNome.Text == "" && txtEmail.Text == "" && txtTelefone.Text == "" && txtEndereco.Text == "")
            {
                //MOSTRA A MENSAGEM
                MessageBox.Show("Obrigatório preenhecer todos os campos");
            }
            //SENÃO
            else
            {
                //BIBLIOTECA QUE AJUDA A GRAVAR OS DADOS NO ARQUIVO.TXT
                StreamWriter sw = new StreamWriter(caminho, true);
                //PEGANDOS OS TEXTBOX PARA SEREM LIDOS E GRAVADOS O QUE DIGITAR
                sw.WriteLine(txtNome.Text);
                sw.WriteLine(txtEmail.Text);
                sw.WriteLine(txtTelefone.Text);
                sw.WriteLine(txtEndereco.Text);
                sw.WriteLine("**************");
                //MENSAGEM SUCESSO
                MessageBox.Show("Cliente cadastrado com sucesso!");
                //FECHA A CONEXÃO PARA PODE ADICONAR OUTRO CONTATO
                sw.Close();

                //LIMPA CAMPOS
                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtEndereco.Clear();
            }
        }
    }
}
