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
    public partial class cad_Viagem : Form
    {
        string caminho = @"C:\Cadastro Sistema Milhas\Cad_Viagem.txt";
        public cad_Viagem()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {

            if (txt_Nome.Text == "" && txt_RG.Text == "" && txt_NumViagem.Text == "" && txt_Passagens.Text == "")
            {
                MessageBox.Show("dados invalidos");

            }
            else
            {

                StreamWriter sw = new StreamWriter(caminho, true);
                sw.WriteLine(txt_Nome.Text);
                sw.WriteLine(txt_RG.Text);
                sw.WriteLine(txt_NumViagem.Text);
                sw.WriteLine(txt_Passagens.Text);
                sw.WriteLine("__________________________________");
                MessageBox.Show("cadastro realizado com sucesso");
                sw.Close(); // Fechamos o arquivo (o salvando). 

                txt_Nome.Clear();
                txt_RG.Clear();
                txt_NumViagem.Clear();
                txt_Passagens.Clear();
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
