using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos
{
    public class Login
    {
        private bool Logado;
        Produto p = new Produto();
        Marca m = new Marca();

        public Login()
        {
            Usuario user = new Usuario();
            Logar(user);

            if (Logado)
            {
                GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"Insira seu email");
            string email = Console.ReadLine()!;

            Console.WriteLine($"Insira sua senha");
            string senha = Console.ReadLine()!;


            if (email == usuario.Email && senha == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso");
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao logar");
            }
        }
        public void Deslogar()
        {
            Logado = false;
            Console.WriteLine($"Ate mais");
        }

        public void GerarMenu()
        {
            ConsoleKeyInfo tecla;
            bool fechar = false;
            do
            {

                Console.WriteLine(@$"
===========================
| SISTEMA DE PRODUTOS 2.0 |
|                         |
| 1 - Cadastrar produto   |
| 2 - Listar produtos     |
| 3 - Remover produto     |
===========================          
| 4 - Cadastrar marca     |
| 5 - Listar marcas       |
| 6 - Deletar marcas      |
===========================          
| 0 - Sair                |
===========================         
            ");

                tecla = Console.ReadKey(true);
                switch (tecla.Key)
                {
                    case ConsoleKey.D1:
                        p.Cadastrar();
                        Console.Clear();
                        break;

                    case ConsoleKey.D2:
                        p.Listar();
                        Console.WriteLine($"Pressionw ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine($"Digite o codigo do item que deseja apagar");
                        int codigo = int.Parse(Console.ReadLine()!);
                        p.Deletar(codigo);
                        Console.Clear();
                        break;

                    case ConsoleKey.D4:
                        m.Cadastrar();
                        Console.Clear();
                        break;

                    case ConsoleKey.D5:
                        m.Listar();
                        Console.WriteLine($"Pressionw ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case ConsoleKey.D6:
                        Console.WriteLine($"Digite o codigo do item que deseja apagar");
                        int codigo2 = int.Parse(Console.ReadLine()!);
                        p.Deletar(codigo2);
                        Console.Clear();
                        break;

                    case ConsoleKey.D0:
                        fechar = true;
                        Console.Clear();
                        Console.WriteLine($"DESLIGADO");
                        break;

                    default:
                        Console.Clear();
                        break;
                }
            } while (fechar == false);

        }
    }
}