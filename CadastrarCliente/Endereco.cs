using System.Text.Json;
using System.Text.Json.Serialization;
namespace CadastrarCliente
{
    public class Endereco
    {
        [JsonPropertyName("cep")]
        public string Cep { get; set; }

        [JsonPropertyName("logradouro")]
        public string Logradouro { get; set; }

        [JsonPropertyName("complemento")]
        public string Complemento { get; set; }

        [JsonPropertyName("bairro")]
        public string Bairro { get; set; }

        [JsonPropertyName("localidade")]
        public string Localidade { get; set; }

        [JsonPropertyName("uf")]
        public string Uf { get; set; }

        [JsonPropertyName("ibge")]
        public string Ibge { get; set; }

        [JsonPropertyName("gia")]
        public string Gia { get; set; }

        [JsonPropertyName("ddd")]
        public string ddd { get; set; }

        [JsonPropertyName("siafi")]

        public string siafi { get; set; }
    }

    public class ConsultarCep
    {

        public static async Task Main(string[] args)
        {
            Console.Write("Digite o CEP: ");
            string cep = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(cep))
            {
                Endereco endereco = await BuscarEnderecoPorCep(cep);
                if (endereco != null)
                {
                    Console.WriteLine($"Logradouro: {endereco.Logradouro}");
                    Console.WriteLine($"Bairro: {endereco.Bairro}");
                    Console.WriteLine($"Cidade: {endereco.Localidade}");
                    Console.WriteLine($"Estado: {endereco.Uf}");
                }
                else
                {
                    Console.WriteLine("CEP não encontrado ou inválido.");
                }
            }
            else
            {
                Console.WriteLine("CEP inválido.");
            }
        }

        public static async Task<Endereco> BuscarEnderecoPorCep(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string url = $"https://viacep.com.br/ws/{cep}/json/";
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        return JsonSerializer.Deserialize<Endereco>(json);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao buscar o CEP: {ex.Message}");
                }
            }
            return null;
        }
    }

}