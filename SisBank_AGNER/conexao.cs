using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SisBank_AGNER
{
    public class Conexao
    {
        private string connectionString =
            "Server=localhost;Database=BancoDB;Trusted_Connection=True;";

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }
    }
}
