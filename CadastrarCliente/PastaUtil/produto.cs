using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarCliente.PastaUtil
{
    internal class produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public string Valor { get; set; }

        // Construtor padrão (sem parâmetros)
        public produto() { }

        // Construtor com parâmetros
        public produto(int ID, string Nome, string Valor, int quantidade)
        {
            this.ID = ID;
            this.Nome = Nome;
            this.Valor = Valor;
            this.Quantidade = quantidade;
        }
    }

    internal class ProdutosLista {
        public produto Bic = new produto(1, "Bic", "1,00", 2);
        public produto Caderno = new produto(2, "Caderno", "5,00", 2);
        public produto Xicara = new produto(3, "Xicara", "3,00", 1);
        public produto Fita = new produto(4, "Fita", "7,00", 1);
        public produto Semente = new produto(5, "Semente", "2,00", 5);
    }



}
