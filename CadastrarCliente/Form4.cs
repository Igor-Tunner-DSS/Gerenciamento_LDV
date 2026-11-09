using CadastrarCliente.PastaUtil.DAO;
using iTextSharp.text.pdf;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.util;
using System.Windows.Forms;

namespace CadastrarCliente
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            Pessoa user = GetUserValues();
            if (!user.IsValid())
            {
                return;
            }

            string query = "UPDATE clientes SET nome=@nome, cpf=@cpf, senha=@senha, email=@email, cidade=@cidade, bairro=@bairro, estado=@estado, rua=@rua WHERE id = @id";

            if (dataGridView1.CurrentRow != null)
            {
                using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
                    string nome = (string)dataGridView1.CurrentRow.Cells["nome"].Value;

                    connection.Open();
                    command.Parameters.AddWithValue("@nome", user.Nome);
                    command.Parameters.AddWithValue("@cpf", user.CPF);
                    command.Parameters.AddWithValue("@senha", user.senha);
                    command.Parameters.AddWithValue("@email", user.email);
                    command.Parameters.AddWithValue("@cidade", user.cidade);
                    command.Parameters.AddWithValue("@bairro", user.bairro);
                    command.Parameters.AddWithValue("@estado", user.estado);
                    command.Parameters.AddWithValue("@rua", user.rua);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();

                }
            }

            ShowTableData();
        }
      
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cycleNext_Click(object sender, EventArgs e)
        {

        }

        private void fazer_Click(object sender, EventArgs e)
        {

        }

        private bool CheckForEmptyValues(List<TextBox> elements)
        {
            foreach (TextBox element in elements)
            {
                if (element.Text == null || element.Text == "") return true;
            }
            return false;
        }

        private void gerar_Click(object sender, EventArgs e)
        {
        }

        private List<Pessoa> GetUsers()
        {
            var users = new List<Pessoa>();
            string query = @"SELECT nome, cpf, senha, email, rua, bairro, cidade, estado FROM clientes";

            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new Pessoa
                        {
                            Nome = reader.IsDBNull(0) ? null : reader.GetString(0),
                            CPF = reader.IsDBNull(1) ? null : reader.GetString(1),
                            senha = reader.IsDBNull(2) ? null : reader.GetString(2),
                            email = reader.IsDBNull(2) ? null : reader.GetString(3),
                            rua = reader.IsDBNull(2) ? null : reader.GetString(4),
                            bairro = reader.IsDBNull(2) ? null : reader.GetString(5),
                            cidade = reader.IsDBNull(2) ? null : reader.GetString(6),
                            estado = reader.IsDBNull(2) ? null : reader.GetString(7),
                        });

                    }
                }
            }

            return users;
        }

        private Pessoa GetUserValues()
        {
            var user = new Pessoa();

            if (CheckForEmptyValues([Nome, CPF, Senha, Email, Rua, Bairro, Cidade, Complemento]))
            {
                MessageBox.Show("Preencha todos os campos");
                return user;
            }
            ;

            string valorNome = Nome.Text;
            string valorCPF = CPF.Text;
            string valorSenha = Senha.Text;
            string valorEmail = Email.Text;
            string valorRua = Rua.Text;
            string valorBairro = Bairro.Text;
            string valorCidade = Cidade.Text;
            string valorEstado = Complemento.Text;

            user.Nome = valorNome;
            user.CPF = valorCPF;
            user.senha = valorSenha;
            user.email = valorEmail;
            user.rua = valorRua;
            user.bairro = valorBairro;
            user.cidade = valorCidade;
            user.estado = valorEstado;


            return user;
        }

        private void gerarTable_Click(object sender, EventArgs e)
        {
            ShowTableData();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void ShowTableData()
        {
            string query = @"SELECT * FROM clientes";

            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            {
                connection.Open();

                using (SqlDataAdapter da = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;


                }
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void fazer_Click_1(object sender, EventArgs e)
        {
            Pessoa userPessoa = GetUserValues();

            // conversão de Pessoa pra Usuario
            // pagaremos por nossos pecados
            Usuario user = new Usuario();
            user.Nome = userPessoa.Nome;
            user.email = userPessoa.email;
            user.senha = userPessoa.senha;
            user.senha2 = userPessoa.senha2; // por que bulhufas nós temos dois campos idênticos ?????
            user.rua = userPessoa.rua;
            user.bairro = userPessoa.bairro;
            user.cidade = userPessoa.cidade;
            user.estado = userPessoa.estado;
            user.complemento = ""; // a classe Pessoa não tem complemento
            user.CPF = userPessoa.CPF;
            if (!user.IsValid())
            {
                return;
            }

            ClienteDAO.insertCliente(
                user,
                123456,
                DateTime.Now.ToString("yyyy-MM-dd"),
                "validado"
            );

            MessageBox.Show("Cliente adicionado com sucesso");

            ShowTableData();
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            ClienteDAO.removeCliente( id );
            ShowTableData();
        }

        private void gerar_Click_1(object sender, EventArgs e)
        {

        }

        private void gerar_Click_2(object sender, EventArgs e)
        {


        }

        private void gerarTable_Click_1(object sender, EventArgs e)
        {
            ShowTableData();
        }

        private void Nota_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Form1());
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                FileName = "Arquivo PDF",
                Filter = "Arquivo *.pdf|*.pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    List<Pessoa> pessoas = GetUsers();
                    var doc = new iTextSharp.text.Document();
                    PdfWriter.GetInstance(doc, stream);
                    doc.Open();
                    doc.Add(new iTextSharp.text.Paragraph("Tabela de clientes\n"));
                    PdfPTable table = new PdfPTable(4);
                    table.AddCell("Nome");
                    table.AddCell("CPF");
                    table.AddCell("Senha");
                    table.AddCell("Email");

                    foreach (Pessoa usuario in pessoas)
                    {
                        table.AddCell(usuario.Nome);
                        table.AddCell(usuario.CPF);
                        table.AddCell(usuario.senha);
                        table.AddCell(usuario.email);

                    }
                    doc.Add(table);
                    doc.Close();
                    stream.Close();
                    MessageBox.Show("PDF Criado com sucesso");
                }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
