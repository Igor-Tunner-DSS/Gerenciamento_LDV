using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;
using CadastrarCliente.PastaUtil;
using lojaDasVariedades;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using CadastrarCliente.PastaUtil.DAO;



namespace CadastrarCliente
{
    public partial class Produtos : Form
    {


        ProdutosLista PRODUTOS = new ProdutosLista();

        private void AdicionarProduto(string nome, string valor, int quantidade)
        {
            int userID = ClienteDAO.getUserID();
            string insertQuery = @"INSERT INTO Carrinho(Nome, Valor, Quantidade, IdUsuario) VALUES (@Nome, @Valor, @Quantidade, @IdUsuario)";

            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand command = new SqlCommand(insertQuery, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Valor", valor);
                command.Parameters.AddWithValue("@Quantidade", quantidade);
                command.Parameters.AddWithValue("@IdUsuario", userID);
                command.ExecuteNonQuery();
            }
        }

        private void DadosProdutos(Label LabelNome, Label LabelNome2, Label LabelNome4, produto Produto)
        {
            LabelNome.Text = "Nome: " + Produto.Nome;
            LabelNome2.Text = "Valor: " + Produto.Valor;
            LabelNome4.Text = "Quantidade:  " + Produto.Quantidade.ToString();

        }

        public Produtos()
        {



            InitializeComponent();

            DadosProdutos(label1, label4, label12, PRODUTOS.Bic);

            DadosProdutos(label8, label9, label11, PRODUTOS.Caderno);

            DadosProdutos(label13, label5, label7, PRODUTOS.Xicara);

            DadosProdutos(label16, label15, label2, PRODUTOS.Fita);

            DadosProdutos(label20, label19, label17, PRODUTOS.Semente);


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void AdicionarBic_Click(object sender, EventArgs e)
        {

            AdicionarProduto(PRODUTOS.Bic.Nome, PRODUTOS.Bic.Valor, PRODUTOS.Bic.Quantidade);
            MessageBox.Show("Produto Adicionado com sucesso");
        }

        private void AdicionarCaderno_Click(object sender, EventArgs e)
        {

            AdicionarProduto(PRODUTOS.Caderno.Nome, PRODUTOS.Caderno.Valor, PRODUTOS.Caderno.Quantidade);
            MessageBox.Show("Produto Adicionado com sucesso");
        }

        private void AdicionarXicara_Click_1(object sender, EventArgs e)
        {
            AdicionarProduto(PRODUTOS.Xicara.Nome, PRODUTOS.Xicara.Valor, PRODUTOS.Xicara.Quantidade);
            MessageBox.Show("Produtos Adicionado com sucesso");
        }

        private void aToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void carrinhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Carrinho());
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AdicionarProduto(PRODUTOS.Fita.Nome, PRODUTOS.Fita.Valor, PRODUTOS.Fita.Quantidade);
            MessageBox.Show("Produtos Adicionado com sucesso");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdicionarProduto(PRODUTOS.Semente.Nome, PRODUTOS.Semente.Valor, PRODUTOS.Semente.Quantidade);
            MessageBox.Show("Produtos Adicionado com sucesso");
        }





        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Carrinho());
            this.Hide();
        }


        private void inícioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new inicio(), true);
            this.Hide();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new sobre());
            this.Hide();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Form1());
            this.Hide();
        }   

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Produtos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
