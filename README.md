# BlazorCRUD
CRUD PROJECT IN BLAZOR
## Telas
<img width="749" alt="01" src="https://github.com/ShirleyR12/BlazorCRUD/assets/56793368/488cd146-a857-4d0e-8016-59a85e6f3d26">

<img width="171" alt="03" src="https://github.com/ShirleyR12/BlazorCRUD/assets/56793368/b73b140f-5b4a-423e-9eaa-cc8457cc3fd5">

# Projeto CRUD em Blazor .NET 6

Este repositório contém um projeto CRUD desenvolvido em Blazor .NET 6. O projeto permite realizar operações básicas de criação, leitura, atualização e exclusão (CRUD) em uma aplicação web usando a tecnologia Blazor.

## Pré-requisitos

Certifique-se de ter as seguintes ferramentas instaladas em sua máquina:

- .NET 6 SDK: [Download .NET 6](https://dotnet.microsoft.com/download/dotnet/6.0)

## NuGets necessários
> `microsoft.entityframeworkcore` <br/>
> `microsoft.entityframeworkcore.design` <br/>
> `microsoft.entityframeworkcore.sqlserver` <br/>
> `microsoft.entityframeworkcore.sqllite`

## Como executar o projeto

1. Clone este repositório para sua máquina local:
 > `https://github.com/ShirleyR12/BlazorCRUD.git`

2. Navegue até o diretório do projeto:
> cd seu-repositorio

3. Execute o projeto usando o comando dotnet:
> `dotnet run`

4. Abra seu navegador e acesse a URL  para visualizar a aplicação.
> `https://localhost:suaPorta`

6. Migration ( certifique que está no diretório: cd .\BlazerCRUD\Server )
> `dotnet-ef`  <br/>
> `dotnet tool install --global dotnet-ef`  | se estiver intalado desinstale e instale novamente:  `dotnet tool uninstall --global dotnet-ef` <br/>
> `dotnet ef migrations add Initial ` <br/>
> `dotnet ef database update `

## BD - DBeave SQLLite
## Recursos

O projeto possui os seguintes recursos:

- Página de listagem: exibe todos os itens existentes no banco de dados.
- Página de criação: permite adicionar um novo item.
- Página de edição: permite editar as informações de um item existente.
- Página de detalhes: exibe informações detalhadas sobre um item.
- Funcionalidade de exclusão: permite remover um item do banco de dados.

## Contribuição

Contribuições são bem-vindas! Se você encontrou um bug, tem alguma ideia para melhorar o projeto ou deseja adicionar novos recursos, fique à vontade para abrir uma issue ou enviar um pull request.


