using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.Model
{
    internal class Fornecedor
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
