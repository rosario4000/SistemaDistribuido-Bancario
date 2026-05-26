using SistemaBancario.Database;
using System;
using System.Data.SqlClient;

namespace SistemaBancario.DAO
{
    public class LogsDAO
    {
        private Conexao conexao = new Conexao();

        public void RegistrarLogin(int usuarioId, string ip)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                string sql = @"INSERT INTO LogsAcesso
                              (UsuarioId, IP, DataAcesso)
                              VALUES
                              (@UsuarioId, @IP, @DataAcesso)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);
                cmd.Parameters.AddWithValue("@IP", ip);
                cmd.Parameters.AddWithValue("@DataAcesso", DateTime.Now);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}