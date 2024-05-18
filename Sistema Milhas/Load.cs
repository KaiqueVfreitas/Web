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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void prgSplash_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if (prgSplash.Value < 100)
            {
                // o progressbar executa 2 vezes
                prgSplash.Value = prgSplash.Value + 2;
            }
            else
            {
                tmrSplash.Enabled = false;
                this.Visible = false;
                fmrLogin login = new fmrLogin();
                login.Show();
                this.Hide();
            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

            if (prgSplash.Value < 100)
            {
                // o progressbar executa 2 vezes
                prgSplash.Value = prgSplash.Value + 2;
            }
            else
            {
                //inicio e a visibilidade do time false
                tmrSplash.Enabled = false;
                this.Visible = false;

                // instancia da tela login
                fmrLogin login = new fmrLogin();
                //chamando a tela login
                login.Show();
                //ocultando a tela do splash
                this.Hide();

            }
        }
    }
}
