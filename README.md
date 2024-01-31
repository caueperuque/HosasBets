# **HosasBets - Sistema de Apostas Esportivas** 🤑🤑

Bem-vindo(a) ao HosasBets!

Este é um sistema incrível para gerenciar apostas esportivas! Com o HosasBets, você pode controlar pessoas usuárias, times, partidas e apostas.

## **Tecnologias Utilizadas**

- **SQL Server:**

- **C#:**

- **ASP.NET Core:**

- **Entity Framework Core:**

- **JWT:**

- **Docker:**

- **Swagger/OpenAPI:**

## **Instalação e Configuração**

Vamos começar!

1. Clone o repositório HosasBets:
   ```
   git clone git@github.com:caueperuque/HosasBets.git
   ```

2. Instale as dependências do projeto utilizando o NuGet Package Manager:
   ```
   dotnet restore
   ```

3. Configure as credenciais do banco de dados no arquivo `appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=127.0.0.1;Database=HosasBets;User=SA;Password=HosasBets123456!;TrustServerCertificate=true"
     }
   }
   ```

4. Inicie o serviço do banco de dados:
   - Se estiver utilizando o Docker:
     ```
     docker-compose up -d
     ```
   - Se estiver utilizando outro banco de dados, inicie o serviço de acordo com as instruções do fabricante.

5. Inicie o servidor da aplicação:
   ```
   dotnet run
   ```

## **Documentação da API**

A documentação da API está disponível no seguinte endereço:

[http://localhost:5500/swagger/index.html](http://localhost:5500/swagger/index.html)

## **Testes**

Para executar os testes da aplicação, execute o seguinte comando:

```
dotnet test
```

## **Contribuindo**

Contribuições são sempre bem-vindas! Para contribuir com o projeto, siga estas etapas:

1. Faça um fork do repositório.
2. Crie uma nova branch para sua alteração.
3. Faça suas alterações e teste-as.
4. Envie um pull request para a branch principal.

## **Licença**

O HosasBets é licenciado sob a licença de eu Mesmo <3.

## **Diferenciais de HosasBets**

O HosasBets é uma versão atualizada do TryBetsAPI, com as seguintes diferenças:

- **Arquitetura:**
  - O HosasBets utiliza uma arquitetura de microsserviços.

- **Tecnologias:**
  - O HosasBets utiliza as seguintes tecnologias:
    - SQL Server como banco de dados
    - C# como linguagem de programação
    - ASP.NET Core como framework web
    - Entity Framework Core como ORM
    - JWT como mecanismo de autenticação
    - Docker como plataforma de containerização
    - Swagger/OpenAPI para documentação da API

- **Funcionalidades:**
  - O HosasBets possui as seguintes funcionalidades adicionais:
    - Gerenciamento de usuários: permite que os administradores criem, editem e excluam usuários.
    - Gerenciamento de times: permite que os administradores criem, editem e excluam times.
    - Gerenciamento de partidas: permite que os administradores criem, editem e excluam partidas.
    - Gerenciamento de apostas: permite que os usuários façam apostas em partidas.
