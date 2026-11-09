using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastrarCliente
{
    class Pessoa
    {

        public string Nome { get; set; }
        public string email { get; set; }
        public string senha { get; set; }
        public string senha2 { get; set; }

        public string rua { get; set; }

        public string bairro { get; set; }

        public string cidade { get; set; }

        public string estado { get; set; }


        public string CPF { get; set; }

        public bool IsValid()
        {
            if (Nome != null &&
                email != null &&
                senha != null &&
                CPF != null)
            {
                return true;
            }
            else { return false; }
        }
    }
}
