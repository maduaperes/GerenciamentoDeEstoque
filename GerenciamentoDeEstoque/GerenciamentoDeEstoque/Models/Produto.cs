using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque.Models
{
    class Produto
    {
        public string Nome { set; get; }
        public int Quantidade { set; get; }
        public int Codigo { set; get; }
        public decimal Preco { set; get; }
        public int Id { set; get; }

        public Produto(string nome, int quantidade, int codigo, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Codigo = codigo;
            Preco = preco;
        }

        public Produto(string nome, int quantidade, int codigo, decimal preco, int id)
        {
            Nome = nome;
            Quantidade = quantidade;
            Codigo = codigo;
            Preco = preco;
            Id = id;
        }
    }
}
