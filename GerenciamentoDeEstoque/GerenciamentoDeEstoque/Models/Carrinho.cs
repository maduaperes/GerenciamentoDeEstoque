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

        public Carrinho(int produtoId, int pedidoId, int quantidade)
        {
            ProdutoId = produtoId;
            PedidoId = pedidoId;
            Quantidade = quantidade;
        }

        public Carrinho(int produtoId, int pedidoId, int quantidade, int id, string nomeProduto)
        {
            NomeProduto = nomeProduto;
            ProdutoId = produtoId;
            PedidoId = pedidoId;
            Quantidade = quantidade;
            Id = id;
        }


    }
}
