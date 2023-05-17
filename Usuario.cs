using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_produtos
{
    public class Usuario
    {
        private int Codigo { get; set; }
        public string ? Nome { get; set; }
        public string ? Email { get; set; }
        public string ? Senha { get; set; }
        private DateTime DataCadastro;
        public Usuario()
        {
            Cadastrar();
        }
        public void Cadastrar()
        {
            this.Nome = "Pedro";
            this.Email = "email";
            this.Senha = "senha";
            this.DataCadastro = DateTime.Now;
            this.Codigo = 001;
        }
        public void Deletar(Usuario usuario)
        {
            
        }
    }
}