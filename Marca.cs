using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string? NomeMarca { get; set; }
        public DateTime DataCadastro;
        public static List<Marca> Marcas = new List<Marca>();
        public Marca()
        {

        }

        public Marca Cadastrar()
        {
            Marca ver = new Marca();

            Console.WriteLine($"Digite o codigo da marca:");
            int codigo = int.Parse(Console.ReadLine()!);
            
            ver = Marcas.Find(x => x.Codigo == codigo)!;

            if (ver == null)
            {
                Marca nova = new Marca();
                nova.Codigo = codigo;
                nova.DataCadastro = DateTime.Now;

                Console.WriteLine($"Digite o nome da marca:");
                nova.NomeMarca = Console.ReadLine();
                
                Marcas.Add(nova);
                return nova;
            }
            else
            {
                Console.WriteLine($"Essa marca ja existe");
                return new Marca();
            }

        }
        public void Listar()
        {
            foreach (Marca m in Marcas)
            {
                Console.WriteLine(@$"
------------------------------------
Codigo: {m.Codigo}
Nome da marca: {m.NomeMarca}
Data de cadastro: {m.DataCadastro}
------------------------------------
                ");
            }
        }
        public void Deletar(int codigo2)
        {
            Marca achado = Marcas.Find(x => x.Codigo == codigo2)!;
            Marcas.Remove(achado);
        }
    }
}