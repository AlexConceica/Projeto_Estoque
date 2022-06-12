using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercearia.Model.DAO
{
    internal class Conexao
    {
        private SqlConnection con = new SqlConnection();

        public Conexao()
        {
            con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MERCEARIA;Integrated Security=True";
        }
        public SqlConnection Conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
