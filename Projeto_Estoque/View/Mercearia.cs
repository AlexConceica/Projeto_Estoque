using Projeto_Estoque.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque.View
{
    public class Mercearia
    {
        public void Menu()
        {
            bool RepeticaoMenu = true;
            while (RepeticaoMenu)
            Console.WriteLine("MENU MERCEARIA");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Vender Produto");
            Console.WriteLine("3 - Comprar de Fornecedor");
            Console.WriteLine("4 - Relatório de Estoque");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("Selecione a opção desejada:");
            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    CadastrarProduto();
                    break;
                case "2":
                    VenderProduto();
                    break;
                case "3":
                    ComprarDeFornecedor();
                    break;
                case "4":
                    RelatorioDeEstoque();
                    break;
                case "5":
                    Console.WriteLine("Sessão Encerrada!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Opção invalida!");
                    break;
            }
        }
        public void CadastrarProduto()
        {
            Produto produto = new();
            Console.WriteLine("Digite o nome do produto");
            produto.Descricao = Console.ReadLine();
            Console.WriteLine("Informe a quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preco: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a data do cadastro: ");
            produto.DataCadastro = DateTime.UtcNow;
        }
        public void VenderProduto()
        {

        }
        public void ComprarDeFornecedor()
        {

        }
        public void RelatorioDeEstoque()
        {

        }
    }
}
