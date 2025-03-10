# Sistema de Gerenciamento de Estoque

Este é o repositório do Sistema de Gerenciamento de Estoque, desenvolvido para otimizar a administração de produtos, pedidos e usuários em um ambiente comercial.

## Módulo: Gerenciamento de Estoque
- **Sprint:** Inicial
- **Empresa Cliente:** N/A
- **Responsável Cliente:** N/A
- **Analista:** Equipe de Desenvolvimento

## 1. Introdução ao Documento

### 1.1 Objetivo do Projeto

O Sistema de Gerenciamento de Estoque foi desenvolvido para otimizar a administração de produtos, pedidos e usuários em um ambiente comercial. Utiliza C# como linguagem principal, .NET como plataforma de desenvolvimento e SQLite para armazenamento de dados.

### 1.2 Delimitação do Problema

Empresas que necessitam de um controle preciso de estoque enfrentam desafios como falta de rastreamento eficiente de produtos, pedidos e controle de usuários. O sistema visa solucionar esses problemas ao fornecer um ambiente centralizado e intuitivo para gerenciamento de estoque.

## 2. Descrição Geral do Sistema

### 2.1 Usuários do Sistema

- **Administrador:** Gerencia usuários, produtos e pedidos.
- **Vendedor:** Pode visualizar produtos e registrar pedidos.

### 2.2 Regras de Negócio

- Apenas administradores podem cadastrar e editar produtos.
- O estoque é atualizado automaticamente após um pedido ser realizado.
- O login é obrigatório para acessar qualquer funcionalidade do sistema.

## 3. Descrição da Sprint

### 3.1 Escopo

- Autenticação de usuários.
- Cadastro, edição e remoção de produtos.
- Criação e listagem de pedidos.

### 3.2 Delimitação

- Não contempla integração com outros sistemas externos.
- Funciona exclusivamente em ambiente local utilizando SQLite.

### 3.3 O que Não Pertence ao Escopo

- Funcionalidades de relatórios avançados.
- Suporte para múltiplas moedas e unidades de medida.

## 4. Fator de Impacto

### 4.1 Detalhamento

- Redução de erros no controle de estoque.
- Melhor organização na gestão de pedidos.
- Maior segurança na administração de usuários.

### 4.2 Componentização

- **Módulo de Usuários:** Responsável pelo controle de acesso.
- **Módulo de Produtos:** Gerencia o catálogo de itens.
- **Módulo de Pedidos:** Processa vendas e atualiza estoque.

## 5. Requisitos do Sistema

### Requisitos Funcionais (RF)

| Código | Descrição |
|--------|-----------|
| RF01   | O sistema deve permitir o cadastro, edição e remoção de usuários. |
| RF02   | O sistema deve permitir o cadastro, edição e remoção de produtos. |
| RF03   | O sistema deve permitir a criação e listagem de pedidos. |
| RF04   | O sistema deve atualizar automaticamente o estoque após uma venda. |
| RF05   | O sistema deve controlar o acesso de acordo com o cargo do usuário. |

### Requisitos Não Funcionais (RNF)

| Código | Descrição |
|--------|-----------|
| RNF01  | O sistema deve ser desenvolvido utilizando a plataforma .NET. |
| RNF02  | O banco de dados utilizado deve ser SQLite. |
| RNF03  | A interface do sistema deve ser responsiva e intuitiva. |
| RNF04  | O tempo de resposta para operações deve ser inferior a 2 segundos. |
| RNF05  | O sistema deve armazenar dados de forma segura. |

## 6. Cenários

### Contexto

- Como usuário, posso realizar login para acessar o sistema de gerenciamento de estoque.
- Como administrador, posso cadastrar produtos para manter o catálogo atualizado.
- Como vendedor, posso registrar pedidos para controlar as vendas.

## 7. Telas

### Descrição da Tela: Tela de Login
- **Requisitos:** RF01
- **Cenários:**
  - Se o usuário inserir credenciais corretas, o login será bem-sucedido.
  - Se as credenciais forem inválidas, uma mensagem de erro será exibida.

### Descrição da Tela: Cadastro de Produtos
- **Requisitos:** RF02
- **Cenários:**
  - O administrador pode adicionar um novo produto preenchendo os campos obrigatórios.
  - O sistema exibe uma mensagem de sucesso após o cadastro.

## 8. Como Configurar e Executar o Sistema

### 8.1 Clonando o Repositório

Para obter o código-fonte do sistema, execute o seguinte comando:

```bash
git clone https://github.com/Leozitos96/UC8-Gerenciamento-de-estoque.git
