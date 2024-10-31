<div display="flex" justify-content="center">
<img width="200px" src="wwwroot/lib/PROVEI2024-Icon.png">
<p>
  <a href="#-tecnologias">Tecnologias</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-capa">Capa</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-resumo">Resumo</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-objetivo">Objetivos</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#memo-licença">Licença</a>
</p>

</div>
<h1> Flor D'Pet </h1>

<p>
Projeto desenvolvido por AnnaLetyFlor <br/>
</p>






<br>



## 🚀 Tecnologias

Esse projeto foi desenvolvido com as seguintes tecnologias:

- C#: Linguagem de programação principal.
- Visual Studio 2022: Ambiente de desenvolvimento integrado.
- Framework ASP.NET MVC: Framework para desenvolvimento de aplicações web.

## 💻 Capa

<p align="center">
<img src="wwwroot/lib/BannerKlothes.png">
</p>


## 📖 Resumo

Este projeto tem como objetivo desenvolver um sistema web completo para gestão de vendas, utilizando a arquitetura MVC (Model-View-Controller) e a linguagem C# no Visual Studio 2022. O sistema permite o cadastro de clientes, fornecedores e produtos, além de realizar o registro de vendas.


## 🔗 Objetivo

-Desenvolver um sistema web funcional e intuitivo para gestão de venda de roupas.
Aplicar os conceitos da arquitetura MVC na prática.
Utilizar as ferramentas do Visual Studio 2022 para criar uma aplicação robusta.

## :memo: Licença

Esse projeto está sob a licença MIT.

---

Feito com ♥ by Karol 


# Sistema de Vendas de Itens de Pet Shop

Este projeto é um sistema de vendas de itens de pet shop desenvolvido em C# utilizando o padrão MVC. Ele fornece uma estrutura simples para gerenciar vendas, produtos, clientes e fornecedores, simulando as operações essenciais de um banco de dados de pet shop.

<img src="wwwroot/lib/Provei2024-banner.png">

## Objetivo

O objetivo do sistema é oferecer uma aplicação web que permita o gerenciamento e controle de vendas de produtos de um pet shop, com informações completas sobre clientes, produtos, fornecedores, além de dados específicos de cada venda. Este sistema é ideal para fins de estudo e prática de conceitos de MVC, C# e integração com banco de dados.

## Estrutura do Projeto

O projeto segue a arquitetura **Model-View-Controller (MVC)** e está dividido nas seguintes partes:

1. **Models (Modelos)**: Classes que representam as tabelas do banco de dados, como:
   - **Cliente**: Contém os dados dos clientes, incluindo ID, nome, endereço e outros detalhes.
   - **Produto**: Representa os itens à venda no pet shop, com ID, nome, descrição, preço, quantidade em estoque e referência ao fornecedor.
   - **Fornecedor**: Armazena informações sobre os fornecedores dos produtos, como ID, nome da empresa e CNPJ.
   - **Venda**: Registra cada venda realizada, contendo ID, data de emissão, valor total e o cliente associado.
   - **VendaProduto**: Representa o relacionamento entre venda e produtos, armazenando a quantidade de cada item vendido.

2. **Controllers (Controladores)**: São responsáveis por lidar com as requisições do usuário e fornecer as respostas adequadas. Cada controlador corresponde a uma entidade e implementa as operações de listagem, criação, edição e exclusão.
   - `ClientesController`, `FornecedoresController`, `ProdutosController`, `VendasController`: Implementam as operações CRUD para gerenciar cada entidade.

3. **Views (Visões)**: Definem a interface do usuário. Cada controlador tem suas próprias visões que fornecem páginas para exibir listas, formulários de criação e detalhes de cada entidade.
   - As visões são divididas para cada entidade, com arquivos `.cshtml` para facilitar a renderização dos dados.

## Instalação e Configuração

1. **Pré-requisitos**:
   - Visual Studio com suporte para .NET Core ou .NET 6 (ou superior).
   - SQL Server (ou outra solução de banco de dados que o projeto esteja configurado para usar).

2. **Configuração do Banco de Dados**:
   - Configure a string de conexão para o banco de dados no arquivo `appsettings.json`:
     ```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "YourDatabaseConnectionString"
       }
     }
     ```
   - Execute as migrações do Entity Framework Core para criar as tabelas no banco de dados.
     ```bash
     dotnet ef database update
     ```

3. **Executando o Projeto**:
   - Inicie o projeto no Visual Studio ou use o comando a seguir para executar a aplicação:
     ```bash
     dotnet run
     ```

4. **Acessando a Aplicação**:
   - Acesse o navegador e digite o endereço `https://localhost:5001` ou `http://localhost:5000` (dependendo da configuração) para visualizar o sistema de vendas de itens de pet shop.

## Funcionalidades

### Produtos

- Listagem, criação, edição e exclusão de produtos vendidos no pet shop.
- Cada produto tem um fornecedor associado, permitindo que o sistema rastreie a origem dos itens.

### Clientes

- Cadastro de clientes, que podem realizar compras no pet shop.
- Opções para editar e visualizar informações dos clientes cadastrados.

### Fornecedores

- Cadastro de fornecedores, com informações como CNPJ e nome da empresa.
- Permite rastrear a origem de cada produto do estoque.

### Vendas

- Registro de vendas com data de emissão, cliente associado e valor total.
- Detalhes das vendas, listando todos os produtos comprados, com quantidade e valor.

### Relatórios e Visualização

- Páginas de listagem de cada entidade (clientes, produtos, fornecedores e vendas) com visualização dos detalhes.
- Integração com o banco de dados para registrar todas as operações realizadas.

## Estrutura do Banco de Dados

O banco de dados possui as seguintes tabelas:

- **Clientes**: ID, Nome, CPF, Endereço, Telefone, Email, Status (ativo/inativo).
- **Fornecedores**: ID, Nome_Empresa, CNPJ, Endereço, Telefone.
- **Produtos**: ID, Nome, Descrição, Preço, Quantidade_Estoque, FornecedorID.
- **Vendas**: ID, ClienteID, Data_Emissao, Valor_Total.
- **VendaProduto**: ID, VendaID, ProdutoID, Quantidade_Comprada.

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir uma _issue_ ou enviar um _pull request_ com melhorias, correções ou novas funcionalidades.
