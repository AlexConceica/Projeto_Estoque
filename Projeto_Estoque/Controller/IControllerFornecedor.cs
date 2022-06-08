using Projeto_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque.Controller
{
    interface IControllerFornecedor
    {
        public void Inserir();
        public void Editar();
        public void Excluir();
        public IEnumerable<Fornecedor> Consultar();
        public Fornecedor ConsultarPorId(int id);
    }
}
