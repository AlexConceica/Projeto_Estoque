using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.Model
{
    internal class Cliente
    {
        public string Nome { get; set; }
        public long Cpf { get; set; }
        public string Endereco { get; set; }
        public DateTime DataCadastro { get; set;}
    }
}
