using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Mercearia.Model.DAO
{
    class ClienteDAO
    {

        Conexao conexao = new Conexao();
        SqlCommand sqlCommand = null;

        public void Cadastrar(Cliente cliente)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO FORNECEDOR VALUES (@Nome, @Cpf, @Endereco, @Data_Cadastro);";
            sqlCommand.Parameters.AddWithValue("@Razao_Social", cliente.Nome);
            sqlCommand.Parameters.AddWithValue("@Cnpj", cliente.Cpf);
            sqlCommand.Parameters.AddWithValue("@Endereco", cliente.Endereco);
            sqlCommand.Parameters.AddWithValue("@Data_Cadastro", cliente.DataCadastro);

            try
            {
                sqlCommand.Connection = conexao.Conectar();
                int id = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public List<Cliente> ConsultarClientes()
        {
            List<Cliente> consultarClientes = new List<Cliente>();
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM CLIENTE;";

            try
            {
                sqlCommand.Connection = conexao.Conectar();
                sqlCommand.ExecuteNonQuery();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Cliente cliente = new();
                    cliente.Nome = reader.GetString(1);
                    cliente.Cpf = reader.GetString(2);
                    cliente.Endereco = reader.GetString(3);
                    cliente.DataCadastro = reader.GetDateTime(4);

                    consultarClientes.Add(cliente); ;
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            return consultarClientes;
        }

        public void Editar(Cliente cliente)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = $"UPDATE FORNECEDOR SET Nome = '{cliente.Nome}', Endereco = '{cliente.Endereco}' WHERE Cpf = '{cliente.Cpf}';";

            try
            {
                sqlCommand.Connection = conexao.Conectar();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erro: " + e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public bool Excluir(string Cpf)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DELETE FROM FORNECEDOR WHERE Cpf = @Cpf;";
            sqlCommand.Parameters.AddWithValue("@Cpf", Cpf);
            try
            {
                sqlCommand.Connection = conexao.Conectar();
                sqlCommand.ExecuteNonQuery();
                return true;
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
                return false;
            }
            finally
            {
                conexao.Desconectar();
            }
        }

        public List<Cliente> ListarClientes(int Cpf)
        {
            sqlCommand = new SqlCommand();
            List<Cliente> cliente = new List<Cliente>();
            sqlCommand.CommandText = "SELECT * FROM FORNECEDOR WHERE Cpf = @Cpf;";
            sqlCommand.Parameters.AddWithValue("@Cpf", Cpf);

            try
            {
                sqlCommand.Connection = conexao.Conectar();
                sqlCommand.ExecuteNonQuery();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Cliente clienteU = new Cliente();
                    clienteU.Nome = reader.GetString(1);
                    clienteU.Cpf = reader.GetString(2);
                    clienteU.Endereco = reader.GetString(3);
                    clienteU.DataCadastro = reader.GetDateTime(4);
                    cliente.Add(clienteU);
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
            return cliente;
        }
    }
}
