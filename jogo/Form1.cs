using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butstar_Click(object sender, EventArgs e)//Iniciar jogo
        {
            Form2 Jogo = new Form2(textJog1.Text, textJog2.Text,usuarios());//passar parametro: nome dos jogadores
            Jogo.Show();
            
        }
        public int usuarios()
        {
            /*Sinal usuario:
             * 1 - Jogador1 é a máquina
             * 2 - Jogador2 é maquina
             * 0 - Não tem máquina
             */
            if (comboBMaq.Text == "Jogador 2(O)") return 2;
            else if (comboBMaq.Text == "Jogador 1(X)") return 1;
            else return 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textJog1.TabStop = true;
            radioBut2Play.Checked = true;
            radioBut1Play.TabStop = radioBut2Play.TabStop = false;
            comboBMaq.Text = "Adversário";
            comboBMaq.Visible = false;
        }

        private void textJog1_TextChanged(object sender, EventArgs e)//Nome do jogador 1
        {
            textJog2.TabStop = true;
            textJog1.TabStop = false;
            
        }

        private void textJog2_TextChanged(object sender, EventArgs e)//Nome do jogador 2
        {
            butstar.TabStop = true;
        }

        private void radioBut1Play_CheckedChanged(object sender, EventArgs e)//Jogar com o computador
        {
            butstar.Enabled = false;
            comboBMaq.Visible = true;
        }

        private void radioBut2Play_CheckedChanged(object sender, EventArgs e)//jogar com outro jogador
        {
            butstar.Enabled = true;
            comboBMaq.Visible = false;
        }

        private void comboBMaq_SelectedIndexChanged(object sender, EventArgs e)//Escolher quem vai ser o computador(Jogado1 ou jogador2)
        {
            if(comboBMaq.Text == "Jogador 1(X)")
            {
                textJog1.Enabled = false;
                textJog1.Text = "Máquina";
                textJog2.Enabled = true;
                textJog2.Text = " ";

            }
            else if(comboBMaq.Text == "Jogador 2(O)")
            {
                textJog2.Enabled = false;
                textJog2.Text = "Máquina";
                textJog1.Enabled = true;
                textJog1.Text = " ";
            }
            else
            {
                textJog1.Enabled = textJog2.Enabled = true;
                textJog1.Text = textJog2.Text = " ";
            }
            if ((comboBMaq.Text == "Jogador 2(O)") || (comboBMaq.Text == "Jogador 1(X)")) butstar.Enabled = true;
        }
    }
}
