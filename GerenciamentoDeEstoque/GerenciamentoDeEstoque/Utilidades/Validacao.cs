using GerenciamentoDeEstoque.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque.Utilidades
{
    class Validacao
    {

        private Database.Database db = new Database.Database();

        /*Verifica se ha textos nulos e os cancela, caso contrario cadastra um novo usuario no banco*/
        public bool CadastroValido(string usuario, string senha, string confirmarSenha, string cargo)
        {
            if(!(string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(senha) || string.IsNullOrEmpty(confirmarSenha)))
            {
                if (senha.Equals(confirmarSenha))
                {
                    if (!(string.IsNullOrEmpty(cargo)))
                    {
                        Usuario usuarioC = new Usuario(usuario, cargo, senha);
                        db.CadastrarUsuario(usuarioC);
                        MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }
                    else
                    {
                        cargo = "Vendedor";
                        Usuario usuarioC = new Usuario(usuario, cargo, senha);
                        db.CadastrarUsuario(usuarioC);
                        MessageBox.Show("Cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }
                }
                else
                {
                    MessageBox.Show("Senhas Divergentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /*Verifica se ha textos nulos, valores abaixo de zero e os cancela, caso contrario cadastra um novo produto no banco*/
        public bool ProdutoValido(string nome, int quantidade, decimal preco, int codigo)
        {
            if (!(string.IsNullOrEmpty(nome)))
            {
                if(!(quantidade <= 0 || codigo <= 0) || preco <= 0)
                {
                    Produto produto = new Produto(nome, quantidade, codigo, preco);
                    db.CadastrarProduto(produto);
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
                else
                {
                    MessageBox.Show("Quantidade, codigo ou preco invalidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Nome invalido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /*Verifica se ha textos nulos, valores abaixo de zero e os cancela, caso contrario cadastra um novo pedido no banco*/
        public bool PedidoValido(string clienteNome, string clienteCpf, string data, decimal total)
        {
            if(!(string.IsNullOrEmpty(clienteNome) || string.IsNullOrEmpty(clienteCpf)))
            {
                total = 0;
                data = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss");
                Pedido pedido = new Pedido(clienteNome, clienteCpf, data, total);
                db.CriarPedido(pedido);
                return true;
            }
            else
            {
                MessageBox.Show("Preencha todos os campos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /*Verifica se ha estoque de produtos, valores nuloes e os cancela, caso contrario adiciona um item no pedido banco*/
        public bool ItemCarrinhoValido(int produtoId, int pedidoId, int quantidade)
        {
            List<Produto> produtos = db.ObterProdutos();
            List<Pedido> pedidos = db.ObterPedidos();

            Produto produto = produtos.FirstOrDefault(p => p.Id == produtoId);
            Pedido pedido = pedidos.FirstOrDefault(p => p.Id == pedidoId);

            if (!(produto == null || pedido == null))
            {
                if (!(produto.Quantidade < quantidade))
                {
                    Carrinho carrinho = new Carrinho(produtoId, pedidoId, quantidade);
                    db.AdicionarItemCarrinho(carrinho.PedidoId, carrinho.ProdutoId, carrinho.Quantidade);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }
    }
}
