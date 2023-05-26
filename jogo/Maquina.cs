using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo
{
    internal class Maquina
    {
        int[,] tabuleiro;
        public Maquina() 
        {
            tabuleiro = new int[3, 3];
        }

        public void jogadas(int i, int j, int valor)
        {
            for (int ii = 0; ii < tabuleiro.GetLength(0); ii++)
            {
                for (int jj = 0; jj < tabuleiro.GetLength(1); jj++)
                {
                    if(i == ii && j == jj)tabuleiro[i, j] = valor;
                }
            }
        }
        public void zeraJogada()
        {
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    tabuleiro[i, j] = 0;
                }
            }
        }
        public int realizarJogadaLinha()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 3);
            return numeroAleatorio;
        }
        public int realizarJogadaColuna()
        {
            Random random = new Random();
            int numeroAleatorio = random.Next(1, 3);
            return numeroAleatorio;
        }


    }
}
