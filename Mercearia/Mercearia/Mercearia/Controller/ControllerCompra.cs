using System;
using Mercearia.Model;
using Mercearia.Model.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.Controller
{
    internal class ControllerCompra : ControllerFornecedor
    {
        Produto produto = new Produto();
        Fornecedor fornecedor = new Fornecedor();
        CompraDAO compra = new CompraDAO();
        ControllerFornecedor controllerFornecedor = new ControllerFornecedor();
        public void ComprarNovoProduto()
        {
            controllerFornecedor.ListarTodosFornecedores();

            Console.WriteLine("-----Compra Produtos-----");
            Console.Write("Informe o Id do fornecedor que deseja Comprar");
            fornecedor.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o produto que deseja comprar");
            produto.Descricao = Console.ReadLine();
            Console.WriteLine("Informe a quantidade que deseja comprar");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do produto");
            produto.preco = float.Parse(Console.ReadLine());

            compra.Comprar(produto, fornecedor);
        }
    }
}
