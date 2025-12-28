# Documentação da Stack do Projeto

Este projeto é uma aplicação Fullstack composta por uma API Backend em .NET e um Frontend em React.

## 🛠️ Tecnologias e Serviços

### Backend
O backend está localizado na pasta `Backend/` e utiliza **.NET 10**.

*   **Framework**: ASP.NET Core Web API
*   **Linguagem**: C# (NET 10.0)
*   **Banco de Dados**: SQLite (via Entity Framework Core 10.0.1)
*   **ORM**: Entity Framework Core
*   **Porta Padrão**: `3000` (HTTP) / `7284` (HTTPS)

### Frontend
O frontend está localizado na pasta `client/` e foi construído com **React** e **Vite**.

*   **Framework**: React 19.2.0
*   **Build Tool**: Vite 7.2.4
*   **Linguagem**: TypeScript (~5.9.3)
*   **Estilização**: TailwindCSS v4.1.18
*   **Roteamento**: React Router DOM 7.11.0
*   **HTTP Client**: Axios 1.13.2
*   **Porta Padrão**: `5175`

---

## 🚀 Como Iniciar a Aplicação

Siga os passos abaixo para rodar o projeto localmente.

### 1. Iniciar o Backend

1.  Abra um terminal e navegue até o diretório do projeto backend:
    ```bash
    cd Backend/Backend
    ```
2.  Execute a aplicação:
    ```bash
    dotnet run
    ```
    *O servidor iniciará em `http://localhost:3000`.*

### 2. Iniciar o Frontend

1.  Abra um **novo terminal** e navegue até o diretório do cliente:
    ```bash
    cd client
    ```
2.  Instale as dependências (caso seja a primeira vez):
    ```bash
    npm install
    ```
3.  Inicie o servidor de desenvolvimento:
    ```bash
    npm run dev
    ```
    *O frontend estará acessível em `http://localhost:5175`.*

### Notas Adicionais
-   Certifique-se de que o backend esteja rodando antes de interagir com a aplicação frontend para evitar erros de conexão.
-   O projeto utiliza o banco de dados SQLite (`app.db`), que é criado/gerenciado pelo Entity Framework.
