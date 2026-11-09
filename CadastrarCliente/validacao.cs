using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using CadastrarCliente.PastaUtil;
using Microsoft.Data.SqlClient;
using static CadastrarCliente.PastaUtil.enviarEmail;

namespace CadastrarCliente
{
    public partial class validacao : Form
    {
        private string email;
        public validacao()
        {
            InitializeComponent();
            email = Util.userSession.Email;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            string codigo =
                textBox1.Text +
                textBox2.Text +
                textBox3.Text +
                textBox4.Text +
                textBox5.Text +
                textBox6.Text;



            int numero = Convert.ToInt32(codigo);
            int userCodigo = pegarEmail.PegarCodigo();



            if (numero == userCodigo)
            {
                string query = "UPDATE clientes SET statusCliente='Validado' WHERE email = @email";


                using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@email", email);
                    command.ExecuteNonQuery();

                }
                this.DialogResult = DialogResult.OK;
                this.Hide();
                MessageBox.Show("Você foi cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Codigo inválido");
            }


        }

        private void validacao_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Focus();
            textBox2.SelectAll();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox3.Focus();
            textBox3.SelectAll();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox4.Focus();
            textBox4.SelectAll();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox5.Focus();
            textBox5.SelectAll();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox6.Focus();
            textBox6.SelectAll();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            button1.Focus();
        }
    }
}
