using CadastrarCliente.PastaUtil.DAO;
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
using System.Windows.Forms;

namespace CadastrarCliente
{
    public partial class PosCarrinho : Form
    {
        public PosCarrinho()
        {
            InitializeComponent();
            ShowTableData();
            AtualizarTotalCarrinho();
        }

        private List<PastaUtil.produto> GetCarrinhoUsuario()
        {
            var produtos = new List<PastaUtil.produto>();
            int userId = ClienteDAO.getUserID();
            if (userId == -1) return produtos;

            string query = @"SELECT Id, IdUsuario, Nome, Quantidade, Valor FROM Carrinho WHERE IdUsuario = @ID_U";
            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID_U", userId);
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        produtos.Add(new PastaUtil.produto()
                        {
                            ID = reader.GetInt32(0),
                            Nome = reader.GetString(2),
                            Valor = reader.GetString(4),
                            Quantidade = reader.GetInt32(3)
                        });
                    }
                }
            }
            return produtos;
        }

        private void ShowTableData()
        {
            string query = @"SELECT Nome, Quantidade, Valor FROM Carrinho WHERE IdUsuario = @ID_U";

            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID_U", ClienteDAO.getUserID());

                using (SqlDataAdapter da = new SqlDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    da.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private decimal CalcularTotalCarrinho()
        {
            decimal total = 0;
            var produtos = GetCarrinhoUsuario();

            foreach (var produto in produtos)
            {
                try
                {
                    // Remove R$, espaços e converte vírgula para ponto
                    string valorLimpo = produto.Valor.Replace("R$", "")
                                                  .Replace(" ", "")
                                                  .Replace(",", ".")
                                                  .Trim();

                    if (decimal.TryParse(valorLimpo, System.Globalization.NumberStyles.Any,
                        System.Globalization.CultureInfo.InvariantCulture, out decimal valorUnitario))
                    {
                        total += valorUnitario;
                    }
                    else
                    {
                        MessageBox.Show($"Valor inválido: {produto.Valor} do produto: {produto.Nome}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro no produto: {produto.Nome}\nErro: {ex.Message}");
                }
            }

            return total;
        }


        private void AtualizarTotalCarrinho()
        {
            decimal total = CalcularTotalCarrinho();
            label1.Text = $"Total do Carrinho: R$ {total.ToString()}";


        }

        private void button5_Click(object sender, EventArgs e)
        {
            PastaUtil.Util.CreateForm(new Carrinho());
            this.Hide();
        }

        // Atualiza quando o formulário fica visível novamente
        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (this.Visible)
            {
                ShowTableData();
                AtualizarTotalCarrinho();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Evento do label
        }

        private void PosCarrinho_Load(object sender, EventArgs e)
        {
            string name = null, address = null;

            int ID = ClienteDAO.getUserID();
            if (ID == -1)
            {
                return;
            }

            string query = "SELECT Nome, rua, bairro, cidade, estado FROM clientes WHERE ID = @ID";
            using (SqlConnection connection = new SqlConnection(PastaUtil.Util.conexao))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ID", ID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = Convert.ToString(reader["Nome"]);
                        name = CapitalizeWords(name);
                        
                        string rua = Convert.ToString(reader["rua"]);
                        string bairro = Convert.ToString(reader["bairro"]);
                        string cidade = Convert.ToString(reader["cidade"]);
                        string estado = Convert.ToString(reader["estado"]);

                        address = $"{CapitalizeWords(rua)}, {CapitalizeWords(bairro)}, {CapitalizeWords(cidade)}, {CapitalizeWords(estado)}";

                    }
                }
            }

            userAddress.Text = address;
            userName.Text = name;
        }

        private void PosCarrinho_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private string CapitalizeWords(string inputString)
        {
            string[] words = inputString.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (!string.IsNullOrEmpty(word))
                {
                    result.Append(char.ToUpper(word[0]));
                    if (word.Length > 1)
                    {
                        result.Append(word.Substring(1));
                    }
                }
                result.Append(' '); // Add space between words
            }

            string capitalizedString = result.ToString().TrimEnd(); // Remove trailing space
            return capitalizedString;
        }
    }
}