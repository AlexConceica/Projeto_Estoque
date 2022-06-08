using Mercearia.View;
using System;

namespace Mercearia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MenuCompra menuCompra = new MenuCompra();
            bool menu = true;

            while(menu)
            {
                Console.WriteLine("___Mercearia do João___");
                Console.WriteLine("");
                Console.WriteLine("Gostaria de comprar ou vender?\n1- Para Comprar Produtos\n2- Para vender Produtos\n3- Sair do sistema");
                Console.Write("Digite sua opção: ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Menu Compra e Fornecedor");
                        menuCompra.menuCompra();
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Menu Venda Produtos");
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Saindo Do Sistema");
                        menu = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Opção Invalida");
                        break;

                }
            }
        }
    }
}
