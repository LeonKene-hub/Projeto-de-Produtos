using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos
{
    public class Marca
    {
        private int Codigo { get; set; }
        private string ? NomeMarca { get; set; }
        private DateTime DataCadastro;
        List<Marca> Marcas = new List<Marca>();

        public Marca()
        {
            
        }
        public Marca(int codigo, string nomeMarca)
        {
            this.Codigo = codigo;
            this.NomeMarca = nomeMarca;
            this.DataCadastro = DateTime.Now;
        }
        public string Cadastrar(Marca marca)
        {
            return "Marca cadastrada";
        }
        public void Listar()
        {
            foreach (Marca m in Marcas)
            {
                Console.WriteLine($"Codigo: {m.Codigo} - Nome da marca: {m.NomeMarca} - Data de cadastro: {m.DataCadastro}");
                
            }
        }
        public string Deletar(Marca marca)
        {
            return "Marca deletada";
        }
    }
}