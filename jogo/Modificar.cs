using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    internal class Modificar
    {
        int[,] tabuleiro;
     
        int jogador1;
        int jogador2;
        Maquina maquina;

        
        public Modificar() 
        {
            tabuleiro = new int[3, 3];//matriz
            jogador1 = 0;
            jogador2 = 0;
            maquina = new Maquina();
        }
        
        public void jogada (int i, int j, int valor)//recebe a posicao e identifa o jogador
        {
            tabuleiro[i, j] = valor;
            maquina.jogadas(i, j, valor);
        }
        public void zeraJogada()
        {
            for(int i=0; i< tabuleiro.GetLength(0); i++)
            {
                for(int j=0; j< tabuleiro.GetLength(1); j++)
                {
                    tabuleiro[i, j] = 0;
                }
            }
        }
        public int AnaliseDiagonalPrin()//Diagonal Primária
        {
            jogador1 = 0;
            jogador2 = 0;
            for(int i=0, j=0; i < 3 && j < 3;  i++, j++)
            {
                if (tabuleiro[i, j] == 1) jogador1+=1;
                else if (tabuleiro[i, j] == 2) jogador2+=2;
            }
            if (jogador1 == 3) return jogador1;
            else if (jogador2 == 6) return jogador2;
            else
            {
                jogador1 = jogador2 = 0;
                return 0;
            }

        }
        public int AnaliseDiagonalSecu()//Diagonal secundária
        {
            jogador1 = 0;
            jogador2 = 0;
            for (int i = 0, j = 2; i < 3 && j >=0; i++, j--)
            {
                if (tabuleiro[i, j] == 1) jogador1 += 1;
                else if (tabuleiro[i, j] == 2) jogador2 += 2;
                else jogador1 = jogador2 = 0;
            }
           
            if (jogador1 == 3) return jogador1;
            else if (jogador2 == 6) return jogador2;
            else
            {
                jogador1 = jogador2 = 0;
                return 0;
            }
        }
        public int AnaliseVertical()//Vertical
        {
            jogador1 = 0;
            jogador2 = 0;
            for(int j=0; j<3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (tabuleiro[i, j] == 1)jogador1 += 1;
                    else if (tabuleiro[i, j] == 2)jogador2 += 2;
                }
                if (jogador2 == 6) break;
                else if (jogador1 == 3) break;
                else jogador1 = jogador2 = 0;
            }
            
            if (jogador1 == 3) return jogador1;
            else if (jogador2 == 6) return jogador2;
            else
            {
                jogador1 = jogador2 = 0;
                return 0;
            }

              
        }
        public int AnaliseHorizontal()//Horizontal
        {
            jogador1 = 0;
            jogador2 = 0;
            for(int i=0; i< 3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    if (tabuleiro[i, j] == 1)jogador1 += 1;
                    else if (tabuleiro[i, j] == 2)jogador2 += 2;    
                }
                if (jogador2 == 6) break;
                else if (jogador1 == 3) break;
                else jogador1 = jogador2 = 0;

            }
          
            if (jogador1 == 3) return jogador1;
            else if (jogador2 == 6) return jogador2;
            else
            {
                jogador1 = jogador2 = 0;
                return 0;
            }
        }
        public bool empate()
        {
            int zeros = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[i, j] != 0) zeros += tabuleiro[i, j];
                }
            }
            if (zeros == 13) return true;
            else return false;
        }
        public int Verificar()
        {
            if (AnaliseDiagonalPrin() == 3) return 1;
            else if (AnaliseDiagonalPrin() == 6) return 2;
            else if (AnaliseHorizontal() == 3) return 1;
            else if (AnaliseHorizontal() == 6) return 2;
            else if (AnaliseVertical() == 3) return 1;
            else if (AnaliseVertical() == 6) return 2;
            else if (AnaliseDiagonalSecu() == 3) return 1;
            else if (AnaliseDiagonalSecu() == 6) return 2;
            else if(empate() == true) return 1010;//Empate
            else return 0;
            
        }

    }
}
