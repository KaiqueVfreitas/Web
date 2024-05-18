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
    public partial class fmr_ConsultarViagem : Form
    {
        string caminho = @"C:\Cadastro Sistema Milhas\Cad_Viagem.txt";

        public fmr_ConsultarViagem()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                lb_Lista.DataSource = (linhas);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            fmrMenu menu = new fmrMenu();
            menu.Show();
            this.Hide();

        }
    }
}
