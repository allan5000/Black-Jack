using System;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class form_apresentacao : Form
    {
        public form_apresentacao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            Form jogo = new Form_jogo();
            jogo.Show();
            this.Visible = false;
        }
    }
}
