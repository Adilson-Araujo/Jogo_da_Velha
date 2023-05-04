using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class Form2 : Form
    {
        int cont = 0;
        string jogador1;
        string jogador2;
        string situacao;
        public Form2(string nome1, string nome2)
        {
            InitializeComponent();
            jogador1 = nome1;
            jogador2 = nome2;
        }
        public void analise(int i, int j)
        {
            Analisar analiseJogo = new Analisar();
            int[,] Jogo = new int[3, 3]; 
            

        }
        public void message()
        {
            cont++;
            if (cont % 2 == 0)
            {
                label1.Text = "Sua vez: " + jogador2;
                situacao = "X";
            }
            else
            {
                label1.Text = "Sua vez: " + jogador1;
                situacao = "O";
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            analise(0, 0);
            message();
            button1.Enabled = false;
            button1.Text = situacao;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            analise(0, 1);
            message();
            button3.Enabled = false;
            button3.Text = situacao;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            analise(0, 2);
            message();
            button2.Enabled = false;
            button2.Text = situacao;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            analise(1, 0);
            message();
            button6.Enabled = false;
            button6.Text = situacao;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            analise(1, 1);
            message();
            button4.Enabled = false;
            button4.Text = situacao;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            analise(1, 2);
            message();
            button5.Enabled = false;
            button5.Text = situacao;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            analise(2, 0);
            message();
            button9.Enabled = false;
            button9.Text = situacao;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            analise(2, 1);
            message();
            button7.Enabled = false;
            button7.Text = situacao;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            analise(2, 2);
            message();
            button8.Enabled = false;
            button8.Text = situacao;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            message();
        }
    }
}
