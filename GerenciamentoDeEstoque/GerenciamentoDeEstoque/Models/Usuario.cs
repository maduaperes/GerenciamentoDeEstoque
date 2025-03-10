using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque.Models
{
    class Usuario
    {
        public string Nome { get;  set; }

        public string Senha { get;  set; }

        public string Cargo { get;  set; }

        public Usuario(string nome, string cargo, string senha)
        {
            Nome = nome;
            Senha = senha;
            Cargo = cargo;
        }

        public Usuario(string nome, string cargo)
        {
            Nome = nome;
            Cargo = cargo;
        }

    }
}
