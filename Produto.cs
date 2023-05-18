using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string? NomeProduto { get; set; }
        private float Preco { get; set; }
        private DateTime DataCadastro;
        private Marca marca = new Marca();
        Usuario usuario = new Usuario();
        private string ? CadastradoPor;
        private List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
            Produto novoProduto = new Produto();
            Marca marcaNova = new Marca();

            Console.WriteLine($"Codigo do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Nome do produto:");
            novoProduto.NomeProduto = Console.ReadLine();

            Console.WriteLine($"Preco do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            novoProduto.CadastradoPor = usuario.Nome!;
            novoProduto.DataCadastro = DateTime.Now;

            novoProduto.marca = marca.Checar();

            ListaDeProdutos.Add(novoProduto);
        }
        public void Listar()
        {
            foreach (Produto p in ListaDeProdutos)
            {
                Console.WriteLine(@$"
===============================
Codigo: {p.Codigo}
Nome: {p.NomeProduto}
Preco: {p.Preco:c}
Marca: {p.marca.NomeMarca}
Cadastro realizado por: {p.CadastradoPor}
===============================
                ");
            }
        }
        public void Deletar(int codigo)
        {
            Produto achado = new Produto();
            achado = ListaDeProdutos.Find(x => x.Codigo == codigo)!;
            ListaDeProdutos.Remove(achado);
        }

        public void ListarM()
        {
            marca.Listar();
        }
    }
}