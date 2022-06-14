using Mercearia.Controller;
using System;

namespace Mercearia.View
{
    internal class MenuCompra
    {
        ControllerFornecedor controlFonecedor = new ControllerFornecedor();
        ControllerCompra controlCompra = new ControllerCompra();
        public void menuCompra()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("___Menu de Compras___");
                Console.WriteLine("");
                Console.WriteLine("1 - Dados Fornecedor\n" +
                    "2 - Comprar Produtos\n" +
                    "3 - Voltar ao Menu");
                Console.Write("Sua opção: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Dados Fornecedor");
                        menuFornecedor();
                        break;
                    case "2":
                        Console.Clear();
                        controlCompra.ComprarNovoProduto();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Voltando ao menu");
                        Console.ReadKey();
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        Console.ReadKey();
                        break;
                }
            }
        }
        public void menuFornecedor()
        {
            bool loop = true;
            while (loop)
            {
                Console.Clear();
                Console.WriteLine("____Menu Fornecedor___");
                Console.WriteLine("");
                Console.WriteLine("1 - Cadastrar Fornecedor\n" +
                    "2 - Editar Fornecedor\n" +
                    "3 - Excluir Fornecedor\n" +
                    "4 - Consultar Todos Fornecedor\n" +
                    "5 - Consultar Fornecedor por Id\n" +
                    "6 - Voltar ao menu");
                Console.Write("Sua opção: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Cadastro Fornecedor");
                        controlFonecedor.Cadastrar();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Editar Fornecedor");
                        controlFonecedor.Editar();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Excluir Fornecedor");
                        controlFonecedor.Excluir();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Consultar Todos Fornecedor");
                        controlFonecedor.ListarTodosFornecedores();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Consultar por Id Fornecedor");
                        controlFonecedor.ListarFornecedor();
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Voltar ao menu");
                        loop = false;
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
            }
        }
    }
}
