using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeEstoque.Models
{
    class Carrinho
    {
        public string NomeProduto { get; set; }
        public int ProdutoId { get;  set; }
        public int PedidoId { get;  set; }
        public int Quantidade { get; set; }
        public int Id { get; set; }

        public Carrinho(string nomeProduto, int produtoId, int pedidoId, int quantidade)
        {
            NomeProduto = nomeProduto;
            ProdutoId = produtoId;
            PedidoId = pedidoId;
            Quantidade = quantidade;
        }

        public Carrinho(string nomeProduto, int produtoId, int pedidoId, int quantidade, int id)
        {
            NomeProduto = nomeProduto;
            ProdutoId = produtoId;
            PedidoId = pedidoId;
            Quantidade = quantidade;
            Id = id;
        }


    }
}
