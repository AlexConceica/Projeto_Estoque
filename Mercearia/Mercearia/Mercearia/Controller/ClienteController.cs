using Mercearia.Model;
using Mercearia.Model.DAO;
using System;
using System.Linq;

namespace Mercearia.Controller
{
    class ClienteController : Cliente
    {
        ClienteDAO _clienteDao = new();

        public void Cadastrar()
        {
            Cliente cliente = new();
            Console.WriteLine("___CADASTRAR CLIENTE___");
            Console.Write("Digite seu nome: ");
            cliente.Nome = Console.ReadLine();

            Console.Write("Digite o Cpf (XXX.XXX.XXX-XX): ");
            cliente.Cpf = Console.ReadLine();

            Console.Write("Digite o Endereco: ");
            cliente.Endereco = Console.ReadLine();

            cliente.DataCadastro = DateTime.UtcNow;

            ClienteDAO clienteDAO = new();

            clienteDAO.Cadastrar(cliente);

        }
        public void Editar()
        {
            var clientes = _clienteDao.ConsultarClientes();

            Console.WriteLine("-----EDITAR CLIENTES-----");
            Console.WriteLine("");
            Console.Write("Informe o CPF do cliente que deseja editar: ");
            string Cpf = Console.ReadLine();

            Cliente cliente = clientes.FirstOrDefault(a => a.Cpf == Cpf);

            if (cliente != null)
            {
                Console.Write("Digite o seu Nome: ");
                cliente.Nome = Console.ReadLine();

                Console.Write("Digite o Endereco: ");
                cliente.Endereco = Console.ReadLine();

                _clienteDao.Editar(cliente);
            }
        }

        public void Excluir()
        {
            var clientes = _clienteDao.ConsultarClientes();
            Console.WriteLine("-----EXCLUIR CLIENTES-----");
            Console.WriteLine("");
            Console.Write("Informe o Cpf que deseja excluir: ");
            string Cpf = Console.ReadLine();

            Cliente cliente = clientes.FirstOrDefault(a => a.Cpf == Cpf);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                var result = _clienteDao.Excluir(cliente.Cpf);
                if (result)
                {
                    Console.Clear();
                    Console.WriteLine("Fornecedor apagado com sucesso");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Não foi possivel exlcuir o cliente");
                    Console.ReadKey();
                }
            }
        }

        public void ListarTodosClientes()
        {
            Console.WriteLine("-----CLIENTES-----"); ;
            Console.WriteLine("");

            var listarClientes = _clienteDao.ConsultarClientes();

            foreach (var cliente in listarClientes)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.Cpf);
                Console.WriteLine("Endereço: " + cliente.Endereco);
                Console.WriteLine("Data Cadastro: " + cliente.DataCadastro);
                Console.WriteLine("----------------");
            }
        }

        public void ListarFornecedor()
        {
            var clientes = _clienteDao.ConsultarClientes();
            Console.WriteLine("-----LISTAR CLIENTES-----");
            Console.WriteLine("");
            Console.Write("Informe o cpf do cliente que deseja listar: ");
            string Cpf = Console.ReadLine();

            Cliente cliente = clientes.FirstOrDefault(a => a.Cpf == Cpf);

            if (cliente != null)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("CPF: " + cliente.Cpf);
                Console.WriteLine("Endereço: " + cliente.Endereco);
                Console.WriteLine("Data Cadastro: " + cliente.DataCadastro);
                Console.WriteLine("----------------");
            }
        }
    }
}