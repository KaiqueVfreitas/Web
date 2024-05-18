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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Elvis Burguer" && txtSenha.Text == "12345")
            {
                Menu men = new Menu();
                men.Show();
                // SE O USUÁRIO OU SENHA ESTIVEREM CORRETOS,APARECERÁ ESTA MENSAGEM
                MessageBox.Show("Sejam bem-vindos ao Sistema");
                this.Hide();
            }
            else
                // SE O USUÁRIO OU SENHA ESTIVEREM INCORRETOS,APARECERÁ ESTA MENSAGEM
                MessageBox.Show("Usuário ou senha inválidos.");
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
