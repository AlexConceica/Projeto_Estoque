using System;
using Mercearia.Model;
using Mercearia.Model.DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.Controller
{
    internal class ControllerFornecedor : Fornecedor
    {
        FornecedorDAO _fornecedorDao = new();
       
        public void Cadastrar()
        {
            Fornecedor fornecedor = new Fornecedor();
            Console.WriteLine("___CADASTRAR FORNECEDOR___");
            Console.Write("Digite a Razão Social: ");
            fornecedor.RazaoSocial = Console.ReadLine();

            Console.Write("Digite o Cnpj (XX. XXX. XXX/0001-XX): ");
            fornecedor.Cnpj = Console.ReadLine();

            Console.Write("Digite o Endereco: ");
            fornecedor.Endereco = Console.ReadLine();

            Console.Write("Digite o numero de registro: ");
            fornecedor.NumeroRegistro = int.Parse(Console.ReadLine());

            fornecedor.DataCadastro = DateTime.UtcNow;

            FornecedorDAO fornecedorDAO = new FornecedorDAO();

            fornecedorDAO.Cadastrar(fornecedor);

        }

        public List<Fornecedor> Consultar(Fornecedor obj)
        {
            throw new NotImplementedException();
        }

        public Fornecedor ConsultarId(Fornecedor obj)
        {
            throw new NotImplementedException();
        }

        public void Editar()
        {
            var fornecedores = _fornecedorDao.ConsultarFornecedores();

            Console.WriteLine("-----EDITAR FORNECEDORES-----");
            Console.WriteLine("");
            Console.Write("Informe o Numero de Registro do fornecedor que deseja editar: ");
            int numeroRegistro = int.Parse(Console.ReadLine());

            Fornecedor fornecedor = fornecedores.FirstOrDefault(a => a.NumeroRegistro == numeroRegistro); 

            if (fornecedor != null)
            {
                Console.Write("Digite a Razão Social: ");
                fornecedor.RazaoSocial = Console.ReadLine();

                Console.Write("Digite o Endereco: ");
                fornecedor.Endereco = Console.ReadLine();

                _fornecedorDao.Editar(fornecedor); 
            }
        }

        public void Excluir()
        {
            var fornecedores = _fornecedorDao.ConsultarFornecedores();
            Console.WriteLine("-----EXCLUIR FORNECEDOR-----");
            Console.WriteLine("");
            Console.Write("Informe o Numero de Registro do fornecedor que deseja excluir: ");
            int numeroRegistro = int.Parse(Console.ReadLine());

            Fornecedor fornecedor = fornecedores.FirstOrDefault(a => a.NumeroRegistro == numeroRegistro);

            if (fornecedor != null)
            {
                fornecedores.Remove(fornecedor);
                var result = _fornecedorDao.Excluir(fornecedor.NumeroRegistro);
                if (result)
                {
                    Console.Clear(); 
                    Console.WriteLine("Fornecedor apagado com sucesso");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Não foi possivel exlcuir o fornecedor");
                    Console.ReadKey();
                }
            }
        }

        public void ListarTodosFornecedores()
        {
            Console.WriteLine("-----FORNECEDORES-----"); ;
            Console.WriteLine("");

            var listarFornecedores = _fornecedorDao.ConsultarFornecedores();

            foreach (var fornecedor in listarFornecedores)
            {
                Console.WriteLine("Razão Social: " + fornecedor.RazaoSocial);
                Console.WriteLine("CNPJ: " + fornecedor.Cnpj);
                Console.WriteLine("Endereço: " + fornecedor.Endereco);
                Console.WriteLine("Data Cadastro: " + fornecedor.DataCadastro);
                Console.WriteLine("Numero Registro: " + fornecedor.NumeroRegistro);
                Console.WriteLine("----------------");
            }
        }

        public void ListarFornecedor()
        {
            var fornecedores = _fornecedorDao.ConsultarFornecedores();
            Console.WriteLine("-----LISTAR FORNECEDOR-----");
            Console.WriteLine("");
            Console.Write("Informe o Numero de Registro do fornecedor que deseja listar: ");
            int numeroRegistro = int.Parse(Console.ReadLine());

            Fornecedor fornecedor = fornecedores.FirstOrDefault(a => a.NumeroRegistro == numeroRegistro);

            if (fornecedor !=null)
            {
                Console.WriteLine("Razão Social: " + fornecedor.RazaoSocial);
                Console.WriteLine("CNPJ: " + fornecedor.Cnpj);
                Console.WriteLine("Endereço: " + fornecedor.Endereco);
                Console.WriteLine("Data Cadastro: " + fornecedor.DataCadastro);
                Console.WriteLine("Numero Registro: " + fornecedor.NumeroRegistro);
                Console.WriteLine("----------------"); 
            }
        }
    }
}
