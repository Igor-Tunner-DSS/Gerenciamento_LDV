using lojaDasVariedades;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using CadastrarCliente.PastaUtil;

namespace CadastrarCliente

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Seu usuário hardcoded (pode manter se quiser)
            if (textBox1.Text == "gabtunner" && textBox2.Text == "1234")
            {

                PastaUtil.Util.CreateForm(new Form4(), true);
                this.Hide();
                return;
            }

            string ConnectionString = Util.conexao;
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string query = @"SELECT email, senha, statusCliente FROM clientes WHERE email = @email";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", textBox1.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string email = reader["email"].ToString();
                            string senha = reader["senha"].ToString();
                            string status = reader["statusCliente"].ToString();

                            // Verifica senha
                            if (textBox2.Text != senha)
                            {
                                MessageBox.Show("Senha de usuário incorreta");
                                textBox2.Focus();
                            }
                            // Verifica se está pendente
                            else if (status == "Pendente")
                            {
                                MessageBox.Show("Conta pendente de validação! Verifique seu email.");
                                textBox1.Focus();
                            }
                            // Tudo certo - pode entrar
                            else
                            {
                                PastaUtil.Util.userSession.Email = textBox1.Text;
                                PastaUtil.Util.userSession.Senha = textBox2.Text;


                                PastaUtil.Util.CreateForm(new inicio(), true);
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Email não encontrado");
                            textBox1.Focus();
                        }
                    }
                }
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateDialog(new Form3(), this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateDialog(new Produtos());
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.SpringGreen;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.SpringGreen;  
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
    }
}
