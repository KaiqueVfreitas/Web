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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value < 100)
            {
                progressBar1.Value += 1;

            }
            else
            {
                tmrSplash.Enabled = false;
                this.Visible = false;

                // INSTÂNCIA DA TELA DE LOGIN
                Login login = new Login();
                // CHAMANDO A TELA DE LOGIN
                login.Show();
                // OCULTANDO A TELA DO SPLASH
                this.Hide();
                //PARANDO A TELA DO SPLASH
                tmrSplash.Stop();

            }
        }
    }
}
