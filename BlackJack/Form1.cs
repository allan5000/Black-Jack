using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form_jogo : Form
    {
        string jog1 = "Jogador 1", jog2 = "Jogador 2";
        public Form_jogo()
        {
            InitializeComponent();
            btn_reiniciar.Enabled = false;
            btn_jogar_2.Enabled = false;
            btn_parar_2.Enabled = false;
        }

        int pontos_A = 0;
        int pontos_B = 0;

        public void resultado()
        {

            /*

                jogador 1   x   jogador 2   resultado
                <= 21           <= 21       maior ponto ganha   REGRA 1
                > 21            <= 21       jogador 2 ganha     REGRA 2
                <= 21           > 21        jogador 1 ganha     REGRA 3
                > 21            > 21        2 perderam          REGRA 4
                jogador 2       jogador 1   EMPATE              REGRA 5

             */

            if (pontos_A > pontos_B && pontos_A <= 21)
            {
                Resultado.Text = jog1 + " Ganhou";
            }

            else if (pontos_A < pontos_B && pontos_B <= 21)
            {
                Resultado.Text = jog2 + " Ganhou";
            }
            else if (pontos_A > 21 && pontos_B <= 21)
            {
                Resultado.Text = jog2 + " Ganhou";
            }
            else if (pontos_A <= 21 && pontos_B <= 21)
            {
                Resultado.Text = "Nenhum Ganhador!";
            }
            else if (pontos_B > 21 && pontos_A > 21)
            {
                Resultado.Text = "A casa ganhou!";
            }
            else if (pontos_B > 21)
            {
                Resultado.Text = jog1 + " Ganhou";
            }

        }

        public void Jogada(PictureBox A, int jogador)
        {
            int x, total_pontos = 0;
            Random sorteio = new Random();
            x = sorteio.Next(1, 14);

            switch (x)
            {
                case 1:
                    A.Image = Properties.Resources.a;
                    total_pontos += 1;

                    break;
                case 2:
                    A.Image = Properties.Resources._2;
                    total_pontos += 2;
                    break;
                case 3:
                    A.Image = Properties.Resources._3;
                    total_pontos += 3;
                    break;
                case 4:
                    A.Image = Properties.Resources._4;
                    total_pontos += 4;
                    break;
                case 5:
                    A.Image = Properties.Resources._5;
                    total_pontos += 5;
                    break;
                case 6:
                    A.Image = Properties.Resources._6;
                    total_pontos += 6;
                    break;
                case 7:
                    A.Image = Properties.Resources._7;
                    total_pontos += 7;
                    break;
                case 8:
                    A.Image = Properties.Resources._8;
                    total_pontos += 8;
                    break;
                case 9:
                    A.Image = Properties.Resources._9;
                    total_pontos += 9;
                    break;
                case 10:
                    A.Image = Properties.Resources._10;
                    total_pontos += 10;
                    break;
                case 11:
                    A.Image = Properties.Resources.J;
                    total_pontos += 11;
                    break;
                case 12:
                    A.Image = Properties.Resources.Q;
                    total_pontos += 12;
                    break;
                case 13:
                    A.Image = Properties.Resources.K;
                    total_pontos += 13;
                    break;
            }

            if (jogador == 1)
                pontos_A += total_pontos;
            else
                pontos_B += total_pontos;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Jogada(pictureBox1, 1);

            if (pontos_A <= 21)
            { // JOGANDO
                lbl_Pontos_A.Text = Convert.ToString(pontos_A);
                if (pontos_A == 21)
                {
                    //lbl_Resultado.Text = "GANHOU!!!";
                    btn_jogar_1.Enabled = false;
                    btn_reiniciar.Enabled = true;
                }
            }
            else
            { // PARTIDA PERDIDA
                lbl_Pontos_A.Text = Convert.ToString(pontos_A);
                //lbl_Resultado.Text = "PERDEU!!!! ";

                btn_jogar_1.Enabled = false;
                btn_parar_1.Enabled = false;

                btn_jogar_2.Enabled = true;
                btn_parar_2.Enabled = true;

                //btn_reiniciar.Enabled = true;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pontos_A = 0;
            pontos_B = 0;
            btn_jogar_1.Enabled = true;
            btn_jogar_2.Enabled = false;
            btn_parar_1.Enabled = true;
            btn_parar_2.Enabled = false;

            btn_reiniciar.Enabled = false;
            lbl_Pontos_A.Text = "0";
            lbl_Pontos_B.Text = "0";
            //lbl_Resultado.Text = "";

            pictureBox1.Image = Properties.Resources._0;
            pictureBox2.Image = Properties.Resources._0;
            Resultado.Text = " ";
        }

        private void btn_jogar_2_Click(object sender, EventArgs e)
        {
            //  ESCOLHER AS CARTAS
            Jogada(pictureBox2, 2);

            if (pontos_B <= 21)
            { // JOGANDO
                lbl_Pontos_B.Text = Convert.ToString(pontos_B);
                if (pontos_B == 21)
                {
                    //lbl_Resultado.Text = "GANHOU!!!";
                    btn_jogar_2.Enabled = false;
                    btn_reiniciar.Enabled = true;
                    resultado();
                }
            }
            else
            { // PARTIDA PERDIDA
                lbl_Pontos_B.Text = Convert.ToString(pontos_B);
                //lbl_Resultado.Text = "PERDEU!!!! ";

                btn_jogar_2.Enabled = false;
                btn_parar_2.Enabled = false;

                btn_jogar_2.Enabled = false;
                btn_parar_2.Enabled = false;

                resultado();
                btn_reiniciar.Enabled = true;
            }
        }

        private void btn_parar_1_Click(object sender, EventArgs e)
        {
            btn_jogar_1.Enabled = false;
            btn_parar_1.Enabled = false;
            btn_jogar_2.Enabled = true;
            btn_parar_2.Enabled = true;
        }

        private void btn_parar_2_Click(object sender, EventArgs e)
        {
            btn_jogar_2.Enabled = false;
            btn_parar_2.Enabled = false;
            btn_reiniciar.Enabled = true;
            resultado();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Nick.Visible == false)
            {
                btn_cadastrar.Visible = true;
                Nick.Visible = true;
            }
            else
            {
                btn_cadastrar.Visible = false;
                Nick.Visible = false;
            }

        }

        private void textBox1_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            if (label_Jogador1.Text == "Jogador 1")
            {
                jog1 = Nick.Text;
                label_Jogador1.Text = jog1;
            }
            else
            {
                jog2 = Nick.Text;
                label_jogador2.Text = jog2;
                btn_cadastrar.Visible = false;
                Nick.Visible = false;
            }
        }

        private void Form_jogo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Jogador1_Click(object sender, EventArgs e)
        {

        }
    }

}