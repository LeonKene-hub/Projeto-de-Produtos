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
        List<Marca> Marcas = new List<Marca>();
        public Marca()
        {

        }
        public void Cadastrar()
        {
            Marca novaMarca = new Marca();

            Console.WriteLine($"Digite o codigo da nova marca:");
            novaMarca.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Digite o nome da nova marca:");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.Now;

            Marcas.Add(novaMarca);
        }

        public Marca Checar()
        {
            Marca ver = new Marca();

            Console.WriteLine($"Digite o codigo da marca:");
            int codigo1 = int.Parse(Console.ReadLine()!);
            
            ver = Marcas.Find(x => x.Codigo == codigo1)!;

            if (ver == null)
            {
                Marca nova = new Marca();
                nova.Codigo = codigo1;
                nova.DataCadastro = DateTime.Now;

                Console.WriteLine($"Digite o nome da marca:");
                nova.NomeMarca = Console.ReadLine();
                
                Marcas.Add(nova);
                return nova;
            }
            else if (ver.Codigo == codigo1)
            {
                return ver;
            }
            return new Marca();

        }
        public void Listar()
        {
            foreach (Marca m in Marcas)
            {
                Console.WriteLine($"Codigo: {m.Codigo} - Nome da marca: {m.NomeMarca} - Data de cadastro: {m.DataCadastro}");
            }
        }
        public void Deletar(int codigo2)
        {
            Marca achado = new Marca();
            achado = Marcas.Find(x => x.Codigo == codigo2)!;
            Marcas.Remove(achado);
        }
    }
}