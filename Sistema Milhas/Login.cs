using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Milhas
{
    public partial class fmrLogin : Form
    {
        public fmrLogin()
        {
            InitializeComponent();
        }

        private void fmrLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_User_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txt_User_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if(txt_User.Text =="Admin" && txt_Senha.Text == "39981342")
            {
                fmrMenu menu = new fmrMenu();
                menu.Show();
                MessageBox.Show("Seja bem Vindo ao Sistema");
                this.Hide();
            }
            else
                // se o usuario e senha forem errrada aparece essa mensagem
                MessageBox.Show("Usuario e senha Inválidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //colocando cusor na caixinha
                txt_User.Focus();
                txt_Senha.Focus();
                //limpando informaçoes
                txt_Senha.Clear();
        }

        private void ptbViagemMilhas_Click(object sender, EventArgs e)
        {

        }
    }
}
