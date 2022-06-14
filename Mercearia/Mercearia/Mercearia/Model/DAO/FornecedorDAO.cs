using System;
using Mercearia.Controller;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Mercearia.Model.DAO
{
    internal class FornecedorDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand sqlCommand = null;

        public void Cadastrar(Fornecedor fornecedor)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO FORNECEDOR VALUES (@Razao_Social, @Cnpj, @Endereco, @Data_Cadastro, @Numero_Registro);";
            sqlCommand.Parameters.AddWithValue("@Razao_Social", fornecedor.RazaoSocial);
            sqlCommand.Parameters.AddWithValue("@Cnpj", fornecedor.Cnpj);
            sqlCommand.Parameters.AddWithValue("@Endereco", fornecedor.Endereco);
            sqlCommand.Parameters.AddWithValue("@Data_Cadastro", fornecedor.DataCadastro);
            sqlCommand.Parameters.AddWithValue("@Numero_Registro", fornecedor.NumeroRegistro);

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

        public List<Fornecedor> ConsultarFornecedores()
        {
            List<Fornecedor> consultarFornecedores = new List<Fornecedor>();
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM FORNECEDOR;";

            try
            {
                sqlCommand.Connection = conexao.Conectar();
                sqlCommand.ExecuteNonQuery();
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Fornecedor fornecedor = new();
                    fornecedor.Id = reader.GetInt32(0);
                    fornecedor.RazaoSocial = reader.GetString(1);
                    fornecedor.Cnpj = reader.GetString(2);
                    fornecedor.Endereco = reader.GetString(3);
                    fornecedor.DataCadastro = reader.GetDateTime(4);
                    fornecedor.NumeroRegistro = reader.GetInt32(5);

                    consultarFornecedores.Add(fornecedor); ;
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
            return consultarFornecedores;
        }

        public void Editar(Fornecedor fornecedor)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = $"UPDATE FORNECEDOR SET Razao_Social = '{fornecedor.RazaoSocial}', Cnpj = '{fornecedor.Cnpj}', Endereco = '{fornecedor.Endereco}' WHERE Numero_Registro = '{fornecedor.NumeroRegistro}';";
            
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
        public bool Excluir(int NumeroRegistro)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "DELETE FROM FORNECEDOR WHERE Numero_Registro = @Numero_Registro;";
            sqlCommand.Parameters.AddWithValue("@Numero_Registro", NumeroRegistro);
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
        public Fornecedor ListarFornecedor(int Id)
        {
            Fornecedor fornecedorU = new Fornecedor();
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "SELECT * FROM FORNECEDOR WHERE Id = @Id;";
            sqlCommand.Parameters.AddWithValue("@Id", Id);

            try
            {
                sqlCommand.Connection = conexao.Conectar();
                sqlCommand.ExecuteNonQuery();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    fornecedorU.RazaoSocial = reader.GetString(1);
                    fornecedorU.Cnpj = reader.GetString(2);
                    fornecedorU.Endereco = reader.GetString(3);
                    fornecedorU.DataCadastro = reader.GetDateTime(4);
                    fornecedorU.NumeroRegistro = reader.GetInt32(5);
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
            return fornecedorU;
        }

    }
}
