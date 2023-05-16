using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos
{
    public class Produto
    {
        private int Codigo { get; set; }
        private string ? NomeProduto { get; set; }
        private float Preco { get; set; }
        private DateTime DataCadastro;
        private Marca marca = new Marca();
        private Usuario ? CadastradoPor;
        private List<Produto> ListaDeProdutos = new List<Produto>();

        public void Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Codigo do produto:");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Nome do produto:");
            novoProduto.NomeProduto = Console.ReadLine();
            
            Console.WriteLine($"Preco do produto:");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            ListaDeProdutos.Add(novoProduto);
        }
        public void Listar()
        {
            foreach (Produto p in ListaDeProdutos)
            {
                Console.WriteLine(@$"
                Codigo: {p.Codigo}
                Nome: {p.NomeProduto}
                Preco: {p.Preco}
                Marca:
                Cadastro realizado por: {p.CadastradoPor}");
            }
        }
        public void Deletar()
        {
            
        }
    }
}