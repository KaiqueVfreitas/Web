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
    public partial class frm_ConsultarCliente : Form
    {
        string caminho = @"C:\Cadastro Sistema Milhas\Arquivo.txt";
        public frm_ConsultarCliente()
        {
            InitializeComponent();
        }

        private void lsbLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<string> linhas = new List<string>();

            string linha;

            using (StreamReader sr = new StreamReader(caminho))
            {
                while ((linha = sr.ReadLine()) != null)
                {
                    linhas.Add(linha);
                }
                lsbLista.DataSource = (linhas);
            }

        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            fmrMenu menu = new fmrMenu();
            menu.Show();
            this.Hide();
        }
    }
}
