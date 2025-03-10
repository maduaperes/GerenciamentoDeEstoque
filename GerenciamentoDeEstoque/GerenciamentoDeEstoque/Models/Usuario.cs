using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque.Models
{
    class Usuario
    {
        public string Nome { get; private set; }

        public string Senha { get; private set; }

        public string Cargo { get; private set; }

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
