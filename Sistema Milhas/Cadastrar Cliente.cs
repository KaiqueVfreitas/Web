using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_Milhas
{
    public partial class CadastroCliente : Form
    {
        string caminho = @"C:\Cadastro Sistema Milhas\Arquivo.txt";
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            if (txt_Nome.Text == "" && txt_Email.Text == "" && msk_Telefone.Text == "" && txt_RG.Text == "" && txt_Senha.Text == "")
            {
                MessageBox.Show("Dados Invalidos");

            }
            else
            {

                StreamWriter sw = new StreamWriter(caminho, true);
                sw.WriteLine(txt_Nome.Text);
                sw.WriteLine(txt_Email.Text);
                sw.WriteLine(msk_Telefone.Text);
                sw.WriteLine(txt_RG.Text);
                sw.WriteLine(txt_Senha.Text);
                sw.WriteLine("_________________________________");
                MessageBox.Show("cadastro realizado com sucesso");
                
                sw.Close();

                txt_Senha.Clear();
                txt_Nome.Clear();
                txt_Email.Clear();
                msk_Telefone.Clear();
                txt_Email.Clear();
                txt_RG.Clear();
            }

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            fmrMenu menu = new fmrMenu();
            menu.Show();
            this.Hide();
        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
