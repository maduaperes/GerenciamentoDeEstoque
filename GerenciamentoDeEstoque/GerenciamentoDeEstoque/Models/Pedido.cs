using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque.Models
{
    class Pedido
    {

        public int Id { get; set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Data { get; set; }
        public decimal Total { get; set; }

        public Pedido(string nome, string cpf, string data, decimal total)
        {
            Nome = nome;
            Cpf = cpf;
            Data = data;
            Total = total;
        }

        public Pedido(string nome, string cpf, string data, decimal total, int id)
        {
            Nome = nome;
            Cpf = cpf;
            Data = data;
            Total = total;
            Id = id;
        }
    }
}
