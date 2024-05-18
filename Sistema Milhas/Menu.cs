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
    public partial class fmrMenu : Form
    {
        public fmrMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ConsultarCliente consCli = new frm_ConsultarCliente();
            consCli.Show();
            this.Hide();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();
            cadCli.Show();
            this.Hide();
        }

        private void viagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCli = new CadastroCliente();
            cadCli.Show();
            this.Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ConsultarCliente consCli = new frm_ConsultarCliente();
            consCli.Show();
            this.Hide();
        }

        private void btn_CadastrarViagem_Click(object sender, EventArgs e)
        {
            cad_Viagem menu = new cad_Viagem();
            menu.Show();
            this.Hide();
        }

        private void viagemToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            cad_Viagem menu = new cad_Viagem();
            menu.Show();
            this.Hide();

        }

        private void btn_ConsultarViagem_Click(object sender, EventArgs e)
        {

            fmr_ConsultarViagem menu = new fmr_ConsultarViagem();
            menu.Show();
            this.Hide();

        }

        private void viagemToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fmr_ConsultarViagem menu = new fmr_ConsultarViagem();
            menu.Show();
            this.Hide();
        }
    }
}
