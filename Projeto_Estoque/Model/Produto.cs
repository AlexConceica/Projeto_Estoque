using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque.Model
{
    public class Produto
    {
        public int CodProduto { get; set; }
        public int Quantidade { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
