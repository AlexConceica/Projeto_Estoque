using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.Model.DAO
{
    internal class CompraDAO
    {
        Conexao conexao = new Conexao();
        SqlCommand sqlCommand = null;

        public void Comprar(Produto produto, Fornecedor fornecedor)
        {
            sqlCommand = new SqlCommand();
            sqlCommand.CommandText = "INSERT INTO ESTOQUE VALUES (@Descricao, @Quantidade, @Preco, @Fornecedor_Id)";
            sqlCommand.Parameters.AddWithValue("@Descricao", produto.Descricao);
            sqlCommand.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
            sqlCommand.Parameters.AddWithValue("@Preco", produto.preco);
            sqlCommand.Parameters.AddWithValue("@Fornecedor_Id", fornecedor.Id);

            try
            {
                sqlCommand.Connection = conexao.Conectar();
                sqlCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                conexao.Desconectar();
            }
        }
    }
}
