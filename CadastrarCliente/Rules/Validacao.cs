using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Org.BouncyCastle.Pqc.Crypto.Cmce;

namespace CadastrarCliente.Rules
{
    internal class Validacao
    {
        public static bool emailIsValid(string email)
        {
            bool valid = false;

            string pattern = @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$";

            Regex regex = new Regex(pattern);

            valid = regex.IsMatch(email);

            return valid;
        }

        public static bool emailExists(string email)
        {
            bool exists = false;

            string querya = @"SELECT COUNT(*) FROM clientes WHERE email = @email";

            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            {
                // Abre a conexão antes de executar o comando
                connection.Open();

                using (SqlCommand command = new SqlCommand(querya, connection))
                {
                    // Adiciona o parâmetro para evitar SQL Injection
                    command.Parameters.AddWithValue("@email", email);

                    // Executa a consulta e obtém o número de registros encontrados
                    int resultado = (int)command.ExecuteScalar();
                    exists = resultado > 0;
                }
            }

            return exists;
        }

        public static bool cpfValidation(string cpf)
        {
            bool valid = false;
            cpf = cpf.Replace("-", "").Replace(".", "").Trim();
            bool onlyDigits = cpf.All(char.IsDigit);

            if (cpf.Length < 11) return false;

            // Verifica se todos os dígitos são iguais (CPF inválido)
            for (int j = 0; j < 10; j++)
                if (new string(j.ToString()[0], 11) == cpf)
                    return false;

            // Calcula o primeiro dígito verificador
            int[] multiplicador1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf += digito;

            // Calcula o segundo dígito verificador
            int[] multiplicador2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito += resto.ToString();

            if (cpf.Length == 11 && onlyDigits && cpf.EndsWith(digito))
            {
                valid = true;
            }

            return valid;
        }
    }
}
