using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CadastrarCliente.PastaUtil.DAO
{
    internal class ClienteDAO
    {
        public static void removeCliente(int id)
        {
            string query = @"DELETE FROM clientes WHERE id = @id";
            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();

            }
        }
        public static void insertCliente(Usuario user, int codVal, string dataVal, string status)
        {
            string insertQuery = @"INSERT INTO clientes(nome, email, senha, rua, bairro , cidade, estado, cpf, codigoValidacao, dataValidacao, statusCliente) VALUES (@Nome, @email, @Senha, @rua, @bairro, @cidade,@estado,@cpf, @codigoValidacao, @dataValidacao, @statusCliente)";

            using (SqlConnection connectionb = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand commandB = new SqlCommand(insertQuery, connectionb))
            {
                connectionb.Open();

                commandB.Parameters.AddWithValue("@Nome", user.Nome);
                commandB.Parameters.AddWithValue("@email", user.email);
                commandB.Parameters.AddWithValue("@Senha", user.senha);
                commandB.Parameters.AddWithValue("@rua", user.rua);
                commandB.Parameters.AddWithValue("@bairro", user.bairro);
                commandB.Parameters.AddWithValue("@cidade", user.cidade);
                commandB.Parameters.AddWithValue("@estado", user.estado);
                commandB.Parameters.AddWithValue("@cpf", user.CPF);

                commandB.Parameters.AddWithValue("@codigoValidacao", codVal);
                commandB.Parameters.AddWithValue("@dataValidacao", dataVal);
                commandB.Parameters.AddWithValue("@statusCliente", status);
                commandB.ExecuteNonQuery();


            }
        }
        public static int getUserID()
        {
            int userID = -1;
            string email = Util.userSession.Email;
            string senha = Util.userSession.Senha;
            string query = @"SELECT id FROM clientes WHERE email = @email AND senha = @senha";

            using (SqlConnection connectiona = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand commanda = new SqlCommand(query, connectiona))
            {
                connectiona.Open();

                commanda.Parameters.AddWithValue("@email", email);
                commanda.Parameters.AddWithValue("@senha", senha);

                using (SqlDataReader reader = commanda.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userID = Convert.ToInt32(reader["ID"]);
                    }
                }
            }

            return userID;
        }

        public static int getUserID(string email, string senha)
        {
            int userID = -1;
            string query = @"SELECT id FROM clientes WHERE email = @email AND senha = @senha";
            using (SqlConnection connectiona = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand commanda = new SqlCommand(query, connectiona))
            {
                connectiona.Open();

                commanda.Parameters.AddWithValue("@email", email);
                commanda.Parameters.AddWithValue("@senha", senha);

                using (SqlDataReader reader = commanda.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userID = Convert.ToInt32(reader["ID"]);
                    }
                }
            }

            return userID;
        }
    }
}
