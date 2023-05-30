using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class Form2 : Form
    {
        private int cont;
        string jogador1;
        string jogador2;
        string situacao;
        int pessoa;
        int pontojog1 = 0;
        int pontojog2 = 0;
        int clique =0;
        int sinal;
        Modificar modifica;//Classe responsável por realizar toda a análise do jogo
        Button[,] botoes;

        public Form2(string nome1, string nome2, int usuarios)//Contrutor
        {
            /*Sinal usuario:
             * 1 - Jogador1 é a máquina
             * 2 - Jogador2 é maquina
             * 0 - Não tem máquina
             */
            InitializeComponent();
            jogador1 = nome1; 
            jogador2 = nome2;
            cont = 0;
            sinal = usuarios;///////////
            modifica = new Modificar();
            
        }


        public void message()//Responsável por identificar a vez do proximo jogador
        {//Jogador a jogar quando cont for: impar jogador2 - par jogador1

            cont++;
            if (cont % 2 == 0)
            {
                
                label1.Text = "Sua vez: " + jogador1;//Nome do proximo jogador
                situacao = "X";
                pessoa = 2;

            }
            else
            {
                
                label1.Text = "Sua vez: " + jogador2;//Nome do próximo jogador
                situacao = "O";
                pessoa = 1;//num 1 representa jogador 1
            }
            /*
            StringBuilder sp = new StringBuilder();
            MessageBox.Show((sp.AppendFormat("cont {0}", cont)).ToString());
            */
        }

        public void AnaliseGanhador()//Analisar o ganhador da rodada
        {
            int analise = modifica.Verificar();
            StringBuilder sp = new StringBuilder();

            if (analise == 1) MessageBox.Show((sp.AppendFormat("{0} ganhou", jogador1)).ToString());
            else if (analise == 2) MessageBox.Show((sp.AppendFormat("{0} ganhou", jogador2)).ToString());
            else if (analise == 1010) MessageBox.Show("Empate");//1010 Representa Empate
            placar();
            if(analise !=0) butTroca.Enabled = true;
            else butTroca.Enabled = false;
            //////////////
            if ((sinal == 1 && cont % 2 == 0) && analise != 1 && analise != 2 && analise != 1010) maquina();
            else if ((sinal == 2 && cont % 2 != 0) && analise != 1 && analise != 2 && analise != 1010) maquina();


        }
        public void desativarButton()//Desativar o tabuleiro em caso de empate
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = false;
        }

        public void Pausebutton()//Reiniciar o tabuleiro
        {
            button1.Enabled = button2.Enabled = button3.Enabled = button4.Enabled = button5.Enabled = button6.Enabled = button7.Enabled = button8.Enabled = button9.Enabled = true;
            button1.Text = button2.Text = button3.Text = button4.Text = button5.Text = button6.Text = button7.Text = button8.Text = button9.Text = " ";
        }
        public void placar()//Placar (Contagem de pontos)
        {
            int analise = modifica.Verificar();
            if (analise == 1) pontojog1 += 1;
            else if (analise == 2) pontojog2 += 1;
            labelJog1.Text = jogador1 + ": " + pontojog1;
            labelJog2.Text = jogador2 + ": " + pontojog2;
            if (analise == 1 || analise == 2) desativarButton();
        }
        public void trocarSimbolo()//Para usuário trocar de simbolo (não afeta sua pontuação)
        {
            string nome1 = jogador1;
            jogador1 = jogador2;
            jogador2 = nome1;
            if (sinal == 1) sinal = 2;
            else if (sinal == 2) sinal = 1;
            int pont1 = pontojog1;
            pontojog1 = pontojog2;
            pontojog2 = pont1;
        }
        public void maquina()
        {
            Random random = new Random();
            int linha;
            int coluna;

            botoes = new Button[,] { 
                { button1, button3, button2 },
                { button6, button4, button5 },
                { button9, button7, button8 }
            };
            int qnt = 0;
            do
            {
                linha = random.Next(0, 2);
                coluna = random.Next(0, 2);

                if(qnt == 100)
                {
                    for(int i=0; i<botoes.GetLength(0); i++)
                    {
                        for (int j=0; j<botoes.GetLength(1); j++)
                        {
                            if (botoes[i,j].Enabled == true)
                            {
                                linha = i;
                                coluna = j;
                            }
                        }
                    }
                }
                qnt += 1;
            } while (botoes[linha, coluna].Enabled == false);

            botoes[linha, coluna].Enabled = false;
            botoes[linha, coluna].Text = situacao;
            message();
            modifica.jogada(linha, coluna, pessoa);
            AnaliseGanhador();        
        }
        //Eventos
        private void button1_Click(object sender, EventArgs e)//Botão representa (0,0) na matriz
        { 
            button1.Enabled = false;
            button1.Text = situacao;
            message();
            modifica.jogada(0, 0, pessoa);
            AnaliseGanhador();

        }

        private void button3_Click(object sender, EventArgs e)//Botão representa (0,1) na matriz
        {
            button3.Enabled = false;
            button3.Text = situacao;
            message();
            modifica.jogada(0, 1, pessoa);
            AnaliseGanhador();
        }

        private void button2_Click(object sender, EventArgs e)//Botão representa (0,2) na matriz
        {
            button2.Enabled = false;
            button2.Text = situacao;
            message();
            modifica.jogada(0, 2, pessoa);
            AnaliseGanhador();
        }

        private void button6_Click(object sender, EventArgs e)//Botão representa (1,0) na matriz
        {
            button6.Enabled = false;
            button6.Text = situacao;
            message();
            modifica.jogada(1, 0, pessoa);
            AnaliseGanhador();
        }

        private void button4_Click(object sender, EventArgs e)//Botão representa (1,1) na matriz
        {
            button4.Enabled = false;
            button4.Text = situacao;
            message();
            modifica.jogada(1, 1, pessoa);
            AnaliseGanhador();
        }

        private void button5_Click(object sender, EventArgs e)//Botão representa (1,2) na matriz
        {
            button5.Enabled = false;
            button5.Text = situacao;
            message();
            modifica.jogada(1, 2, pessoa);
            AnaliseGanhador();
        }

        private void button9_Click(object sender, EventArgs e)//Botão representa (2,0) na matriz
        {
            button9.Enabled = false;
            button9.Text = situacao;
            message();
            modifica.jogada(2, 0, pessoa);
            AnaliseGanhador();
        }

        private void button7_Click(object sender, EventArgs e)//Botão representa (2,1) na matriz
        {
            button7.Enabled = false;
            button7.Text = situacao;
            message();
            modifica.jogada(2, 1, pessoa);
            AnaliseGanhador();
        }

        private void button8_Click(object sender, EventArgs e)//Botão representa (2,2) na matriz
        {
            button8.Enabled = false;
            button8.Text = situacao;
            message();
            modifica.jogada(2, 2, pessoa);
            AnaliseGanhador();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cont = -1;
            message();
            modifica.zeraJogada();//zerar partida assim que iniciada
            placar();
            butTroca.Enabled = false;
            if (sinal == 1 && cont % 2 == 0) maquina();
            else if (sinal == 2 && cont % 2 != 0) maquina();
        }
        private void butRestart_Click(object sender, EventArgs e)//Recomeçar o jogo
        {
            cont = -1;
            modifica.zeraJogada();//zerar partida assim que iniciada
            Pausebutton();
            message();
            placar();
            butTroca.Enabled = false;
            if (sinal == 1 && cont % 2 == 0) maquina();
            else if (sinal == 2 && cont % 2 != 0) maquina();
        }

        private void butTroca_Click(object sender, EventArgs e)//Trocar de simbolo
        {
            trocarSimbolo();
            butTroca.Enabled = false;
        }

        private void butFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
