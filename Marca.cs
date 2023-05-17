using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string ? NomeMarca { get; set; }
        public DateTime DataCadastro;
        List<Marca> Marcas = new List<Marca>();

        public Marca()
        {
            
        }
        public void Cadastrar()
        {
            Marca novaMarca = new Marca();

            Console.WriteLine($"Digite o codigo da marca");
            novaMarca.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Digite o nome da marca");
            novaMarca.NomeMarca = Console.ReadLine();

            novaMarca.DataCadastro = DateTime.Now;

            Marcas.Add(novaMarca);
            
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