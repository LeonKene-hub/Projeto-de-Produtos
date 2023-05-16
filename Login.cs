using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos
{
    public class Login
    {
        private bool Logado;

        public Login()
        {

        }

        public string Logar()
        {
            string email = "admin@gmail.com";
            string senha = "suasenha";

            string emailDigitado = Console.ReadLine()!;
            string senhaDigitado = Console.ReadLine()!;

            if (emailDigitado == email && senhaDigitado == senha)
            {
                return "Bem vindo";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return "ACESSO NEGADO";
            }
        }
        public string Deslogar()
        {
            return "Ate mais";
        }
    }
}