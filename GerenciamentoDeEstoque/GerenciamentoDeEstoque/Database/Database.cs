using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GerenciamentoDeEstoque.Models;
using Microsoft.Data.Sqlite;


namespace GerenciamentoDeEstoque.Database
{
    class Database
    {
        /*cria as tabelas no banco de dados 
         
        Tabelas:
        - Produtos (Id, Nome, Codigo, Preco, Quantidade)
        - Usuarios (Id, Nome, Cargo, Senha)
        - Pedidos (Id, ClienteCPF, ClienteNome, Total)
        - Carrinho (Id, ProdutoId, PedidoId, Quantidade)

         */
        public static void CriarTabelasNoBanco()
        {
            string conectar = "Data Source=database.db";
            using (SqliteConnection connection = new SqliteConnection(conectar))

            {
                connection.Open();

                string createTables = @"
                CREATE TABLE IF NOT EXISTS Produtos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Codigo TEXT UNIQUE NOT NULL,
                    Preco REAL NOT NULL,
                    Quantidade INTEGER NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Usuarios (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nome TEXT NOT NULL,
                    Cargo TEXT NOT NULL,
                    Senha TEXT NOT NULL
                );

                CREATE TABLE IF NOT EXISTS Pedidos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Data TEXT NOT NULL,
                    ClienteCPF TEXT NOT NULL,
                    ClienteNome TEXT NOT NULL,
                    Total REAL NOT NULL,
                );

                CREATE TABLE IF NOT EXISTS Carrinho(
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProdutoId INTEGER NOT NULL,
                    PedidoId INTEGER NOT NULL,
                    Quantidade INTEGER NOT NULL,
                    FOREIGN KEY (ProdutoId) REFERENCES Produtos(Id),
                    FOREIGN KEY (PedidoId) REFERENCES Pedidos(Id)
                ); ";

                var comando = connection.CreateCommand();
                comando.CommandText = createTables;
                comando.ExecuteNonQuery();
            }
        }

        // Método para cadastrar um novo usuário
        public void CadastrarUsuario(Usuario usuario)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();

                string inserir = "INSERT INTO Usuarios (Nome, Cargo, Senha) VALUES (@nome, @cargo, @senha)";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;
                cmd.Parameters.AddWithValue("@nome", usuario.Nome);
                cmd.Parameters.AddWithValue("@cargo", usuario.Cargo);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para cadastrar um novo produto
        public void CadastrarProduto(Produto produto)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();

                string inserir = "INSERT INTO Produtos (Nome, Codigo, Preco, Quantidade) VALUES (@Nome, @Codigo, @Preco, @Quantidade)";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;

                cmd.Parameters.AddWithValue("@Nome", produto.Nome);
                cmd.Parameters.AddWithValue("@Codigo", produto.Codigo);
                cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                cmd.ExecuteNonQuery();
            }
        }

        // Método para atualizar um produto
        public void AtualizarProduto(Produto produto)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))

            {
                connection.Open();
                string inserir = "UPDATE Produtos SET Preco = @Preco, Quantidade = @Quantidade WHERE Codigo = @Codigo";
                var cmd = connection.CreateCommand();
                cmd.CommandText = inserir;

                {
                    cmd.Parameters.AddWithValue("@Preco", produto.Preco);
                    cmd.Parameters.AddWithValue("@Quantidade", produto.Quantidade);
                    cmd.Parameters.AddWithValue("@Codigo", produto.Codigo);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para remover um produto
        public void RemoverProduto(int id)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Carrinho WHERE ProdutoId = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Produtos WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para cadastrar um novo pedido 
        public void CriarPedido(Pedido pedido)
        {
            string conectar = "Data Source=database.db";

            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();

                string inserir = "INSERT INTO Pedidos (ClienteNome, ClienteCPF, Data, Total) VALUES (@nomecliente, @cpfcliente, @data, @total)";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = inserir;
                    cmd.Parameters.AddWithValue("@nomecliente", pedido.Nome);
                    cmd.Parameters.AddWithValue("@cpfcliente", pedido.Cpf);
                    cmd.Parameters.AddWithValue("@data", pedido.Data);
                    cmd.Parameters.AddWithValue("@total", pedido.Total);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para remover um pedido
        public void RemoverPedido(int id)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Carrinho WHERE PedidoId = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM Pedidos WHERE Id = @id";
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /* Método para adicionar um produto no pedido, atualiza no banco a quantia que foi removida e
         * atualiza na tabela PEDIDOS o total do preco*/
        public void AdicionarItemCarrinho(int pedidoId, int produtoId, int quantidade)
        {
            string conectar = "Data Source=database.db";

            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();

                string inserir = "INSERT INTO Carrinho (ProdutoId, PedidoId, Quantidade) VALUES (@produtoId, @pedidoId, @quantidade)";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = inserir;
                    cmd.Parameters.AddWithValue("@produtoId", produtoId);
                    cmd.Parameters.AddWithValue("@pedidoId", pedidoId);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.ExecuteNonQuery();
                }
                string updateProdutos = "UPDATE Produtos SET Quantidade = Quantidade - @quantidade WHERE Id = @Id";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = updateProdutos;
                    cmd.Parameters.AddWithValue("@Id", produtoId);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.ExecuteNonQuery();
                }

                string updateTotal = @"UPDATE Pedidos SET Total = (SELECT COALESCE(SUM(Produtos.Preco * Carrinho.Quantidade), 0) FROM Carrinho JOIN Produtos ON Carrinho.ProdutoId = Produtos.Id  WHERE Carrinho.PedidoId = @pedidoId) WHERE Id = @pedidoId;";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = updateTotal;
                    cmd.Parameters.AddWithValue("@pedidoId", pedidoId);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        /* Método para remover um produto no carrinho, atualiza no banco a quantia que foi removida e
         * atualiza na tabela PEDIDOS o total do preco*/
        public void RemoverItemCarrinho(int carrinhoId ,int pedidoId, int produtoId, int quantidade)
        {
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {
                string delete = "DELETE Quantidade = @quantidade FROM Carrinho WHERE Id = @id";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = delete;
                    cmd.Parameters.AddWithValue("@id", carrinhoId);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.ExecuteNonQuery();
                }
                string updateProdutos = "UPDATE Produtos SET Quantidade = Quantidade + @quantidade WHERE Id = @Id";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = updateProdutos;
                    cmd.Parameters.AddWithValue("@Id", produtoId);
                    cmd.Parameters.AddWithValue("@quantidade", quantidade);
                    cmd.ExecuteNonQuery();
                }

                string updateTotal = @"UPDATE Pedidos SET Total = (SELECT COALESCE(SUM(Produtos.Preco * Carrinho.Quantidade), 0) FROM Carrinho JOIN Produtos ON Carrinho.ProdutoId = Produtos.Id  WHERE Carrinho.PedidoId = @pedidoId) WHERE Id = @pedidoId;";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = updateTotal;
                    cmd.Parameters.AddWithValue("@pedidoId", pedidoId);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        /* Método para retornar uma lista de produtos
           exemplo: List<Produto> produtos = ObterProdutos();
        */
        public  List<Produto> ObterProdutos()
        {
            List<Produto> produtos = new List<Produto>();
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {
                connection.Open();
                string select = "SELECT Id, Nome, Codigo, Quantidade, Preco FROM Produtos";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = select;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())  
                        {
                            int id = reader.GetInt32(0);
                            string nome = reader.GetString(1);
                            int codigo = reader.GetInt32(2);
                            int quantidade = reader.GetInt32(3);
                            decimal preco = reader.GetDecimal(4);
                            Produto produto = new Produto(nome, quantidade, codigo, preco, id);
                            produtos.Add(produto);
                        }
                    }
                }
            }
            return produtos;
        }

        /* Método para retornar uma lista de produtos
           exemplo: List<Pedido> pedidos = ObterPedidos();
        */
        public  List<Pedido> ObterPedidos()
        {
            List<Pedido> pedidos = new List<Pedido>();
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {

                connection.Open();
                string select = "SELECT Id, ClienteNome, ClienteCPF, Data, Total FROM Produtos";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.CommandText = select;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string nome = reader.GetString(1);
                            string cpf = reader.GetString(2);
                            string data = reader.GetString(3);
                            decimal total = reader.GetDecimal(4);
                            Pedido pedido = new Pedido(nome, cpf, data, total, id);
                            pedidos.Add(pedido);
                        }
                    }
                }
            }
            return pedidos;
        }

        /* Método para retornar uma lista de produtos do Carrinho
           exemplo: List<Carrinho> itens = ObterCarrinho(ID_PEDIDO);
        */
        public  List<Carrinho> ObterCarrinho(int pedidoId)
        {
            List<Carrinho> itens = new List<Carrinho>();
            string conectar = "Data Source=database.db";
            using (var connection = new SqliteConnection(conectar))
            {

                connection.Open();
                string select = "SELECT Carrinho.Id, Produtos.Nome, Carrinho.ProdutoId, Carrinho.Quantidade FROM Carrinho JOIN Produtos ON Carrinho.ProdutoId = Produtos.Id WHERE Carrinho.PedidoId = @pedidoId";
                using (var cmd = connection.CreateCommand())
                {
                    cmd.Parameters.AddWithValue("@pedidoId", pedidoId);
                    cmd.CommandText = select;
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(0);
                            string produtoNome = reader.GetString(1);
                            int produtoId = reader.GetInt32(2);
                            int quantidade = reader.GetInt32(3);
                            Carrinho carrinho = new Carrinho(produtoId, pedidoId, quantidade, id, produtoNome);
                            itens.Add(carrinho);
                        }
                    }
                }
            }
            return itens;
        }


    }
}
