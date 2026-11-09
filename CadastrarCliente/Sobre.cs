using CadastrarCliente;
using CadastrarCliente.PastaUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojaDasVariedades
{
    public partial class sobre : Form
    {
        public sobre()
        {
            InitializeComponent();

        }
        private void sobre_Load(object sender, EventArgs e)
        {
            description.Text = "Este é um sistema dedicado à rede de lojas Shopping das Variedades. Ele tem o intuito de simular uma experiência virtual de compras na loja física.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.CreateForm(new inicio(), true);
            this.Hide();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.CreateForm(new Form1());
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.CreateForm(new Produtos());
            this.Hide();
        }

        private void carrinhoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Util.CreateForm(new Carrinho());
            this.Hide();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void sobre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
