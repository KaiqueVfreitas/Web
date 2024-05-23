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
    public partial class ConsultarProduto : Form
    {
        string caminho = @"C:Users\User\Desktop\HamburgueriaElvisBurguer\dados\produtos.txt";

        public ConsultarProduto()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void lbxConsultaProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                /*manda a lista para o listBox*/
                lbxConsultaProduto.DataSource = (caminho);
            }
    }
}
