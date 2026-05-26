using System;
using System.Collections.Generic;
using System.Text;

namespace SisBank_AGNER
{
    class ObjectAcessoUsuario
    {
        private Conexao conexao = new Conexao();

        public void Inserir(Usuario usuario)
        {
            using (SqlConnection conn = conexao.ObterConexao())
            {
                string sql = @"INSERT INTO Usuarios
                              (Nome, Email, Senha, Tipo, Ativo)
                              VALUES
                              (@Nome, @Email, @Senha, @Tipo, @Ativo)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@Email", usuario.Email);
                cmd.Parameters.AddWithValue("@NomeUsuario", usuario.NomeUsuario);
                cmd.Parameters.AddWithValue("@Senha", usuario.Senha);
                cmd.Parameters.AddWithValue("@Ativo", usuario.Ativo);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
