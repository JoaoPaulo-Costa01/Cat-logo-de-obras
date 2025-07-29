# Catálogo de Obras

## O que faz?
O usuário digita o nome de uma obra, o programa se conecta à OMDb API para buscar informações em tempo real sobre filmes ou séries, como ano de lançamento, sinopse, atores e nota no IMDb, e exibe tudo de forma organizada para o usuário.

## Linguagem de Programação:
C#: Linguagem principal utilizada para toda a lógica da aplicação.

## Plataforma e Ferramentas:
.NET: Plataforma de desenvolvimento sobre a qual a aplicação foi construída.

Visual Studio: IDE (Ambiente de Desenvolvimento Integrado) utilizada para escrever, compilar e depurar o código.

Git & GitHub: Ferramentas para versionamento de código e para hospedar o projeto publicamente.

## Conceitos Fundamentais de C# e .NET:
Programação Assíncrona (async/await): Essencial para fazer chamadas de rede (HttpClient) sem travar a aplicação enquanto espera a resposta.

Consumo de API REST (HttpClient): Utilização da classe HttpClient para se comunicar com um serviço externo (OMDb API) através do protocolo HTTP (requisições GET).

Manipulação de JSON (System.Text.Json): Processo de Deserialização para converter a resposta da API (em formato de texto JSON) em um objeto C# estruturado (JsonSerializer.Deserialize).

Programação Orientada a Objetos (Básico): Criação de uma classe (Filme) para modelar os dados do mundo real, com propriedades ({ get; set; }) para armazenar as informações.

## 🚀 Como Executar o Projeto

1.  **Clone o repositório:**
    ```bash
    git clone https://github.com/JoaoPaulo-Costa01/Cat-logo-de-obras.git
    ```

2.  **Obtenha uma chave de API:**
    - Este projeto requer uma chave da OMDb API.
    - Acesse [omdbapi.com/apikey.aspx](http://www.omdbapi.com/apikey.aspx) para conseguir sua chave gratuita por e-mail.

3.  **Adicione sua Chave de API no Código:**
    - Abra a solução do projeto (`.sln`) no Visual Studio.
    - Navegue e abra o arquivo `Program.cs`.
    - Localize a linha de código onde a variável `minhaChave` é declarada. Haverá um comentário indicando onde colar sua chave.
    - Substitua o valor de exemplo pela sua chave pessoal da API.
      ```csharp
      // Exemplo de como a linha deve ficar no código:
      string minhaChave = "SUA_CHAVE_AQUI"; 
      ```

4.  **Execute:**
    - Pressione **F5** ou clique no botão de "Play" no Visual Studio para compilar e rodar o projeto.
