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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butstar_Click(object sender, EventArgs e)
        {
            Form2 Jogo = new Form2(textJog1.Text, textJog2.Text);
            Jogo.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textJog1.TabStop = true;
        }

        private void textJog1_TextChanged(object sender, EventArgs e)
        {
            textJog2.TabStop = true;
            textJog1.TabStop = false;
        }

        private void textJog2_TextChanged(object sender, EventArgs e)
        {
            butstar.TabStop = true;
        }
    }
}
