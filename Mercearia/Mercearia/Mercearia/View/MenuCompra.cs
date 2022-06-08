using Mercearia.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.View
{
    internal class MenuCompra
    {
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
                }
            }
        }
        public void menuFornecedor()
        {
            bool loop = true;
            while(loop)
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
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Editar Fornecedor");
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Excluir Fornecedor");
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Consultar Todos Fornecedor");
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Consultar por Id Fornecedor");
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
        public void menuComprarProdutos()
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("_____Compra Produtos_____");
                Console.WriteLine("");
                Console.WriteLine("1 - Se deseja comprar novos produtos\n" +
                    "2 - Para voltar para o menu");
                Console.Write("Sua opção: ");
                string option = Console.ReadLine();

                switch(option)
                {
                    case "1":
                        break;
                }
            }
        }
    }
}
