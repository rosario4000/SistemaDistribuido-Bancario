using SistemaBancario.DAO;
using SistemaBancario.Models;
using SistemaBancario.Services;
using System;

namespace SistemaBancario.Menus
{
    public class MenuPrincipal
    {
        public void Iniciar()
        {
            int opcao;

            do
            {
                Console.Clear();

                Console.WriteLine("===== SISTEMA BANCÁRIO  =====");
                Console.WriteLine("======== SIS-BANK  =====");
                Console.WriteLine("1 - Criar Conta");
                Console.WriteLine("2 - Login");
                Console.WriteLine("0 - Sair");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CriarConta();
                        break;

                    case 2:
                        Login();
                        break;
                }

            } while (opcao != 0);
        }

        private void CriarConta()
        {
            Usuario usuario = new Usuario();
            UsuarioDAO dao = new UsuarioDAO();
            AuthService auth = new AuthService();

            Console.Write("Nome: ");
            usuario.Nome = Console.ReadLine();

            Console.Write("Email: ");
            usuario.Email = Console.ReadLine();

            Console.Write("Nome De Usuario: ");
            usuario.NomeUsuario = Console.ReadLine();

            Console.Write("Senha: ");
            usuario.Senha =
                auth.GerarSenhaHash(Console.ReadLine());

            usuario.Tipo = "CLIENTE";
            usuario.Ativo = true;

            dao.Inserir(usuario);

            Console.WriteLine("Conta criada com sucesso.");
            Console.ReadKey();
        }

        private void Login()
        {
            Console.WriteLine("Sistema de login...");
            Console.ReadKey();
        }
    }
}