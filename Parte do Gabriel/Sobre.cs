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

            description.Text = "Este é um sistema dedicado à rede de lojas Shopping das Variedades. Ele tem o intuito de simular uma experiência virtual de compras na loja física.";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            inicio form = new inicio();
            form.Show();
        }
    }
}
