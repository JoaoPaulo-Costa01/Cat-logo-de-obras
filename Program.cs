using System;
using System.Text.Json;

namespace CatalogoDeFilmes {
    internal class Program {
        static async Task Main(string[] args) {

            HttpClient client = new HttpClient();
            string decisao;
            do {
                Console.WriteLine("Bem vindo, digite o nome da obra que você quer informações: ");
                string NomeFilme = Console.ReadLine();

                Console.WriteLine($"Buscando informações sobre a obra: [{NomeFilme}]");
                
                //abaixo coloque a chave da api do IMDB
                string minhaChave = //Coloque sua chave aqui;
                string Url = $"http://www.omdbapi.com/?apikey={minhaChave}&t={NomeFilme}";
                
                string respostaJson = await client.GetStringAsync(Url);
                Console.WriteLine();

                var opcoesDeSerializacao = new JsonSerializerOptions {
                    PropertyNameCaseInsensitive = true
                };
                Filme filmeConvertido = JsonSerializer.Deserialize<Filme>(respostaJson, opcoesDeSerializacao);

                Console.WriteLine($"Título: {filmeConvertido.Title}");
                Console.WriteLine($"Ano de Lançamento: {filmeConvertido.Year}");
                Console.WriteLine($"Sinopse: {filmeConvertido.Plot}");
                Console.WriteLine($"Diretor(a): {filmeConvertido.Director}");
                Console.WriteLine($"Duração: {filmeConvertido.Runtime}");
                Console.WriteLine($"Gênero: {filmeConvertido.Genre}");
                Console.WriteLine($"Escritor(a): {filmeConvertido.Writer}");
                Console.WriteLine($"Atores: {filmeConvertido.Actors}");
                Console.WriteLine($"Linguagem: {filmeConvertido.Language}");
                Console.WriteLine($"Avaliação do IMDB: {filmeConvertido.imdbRating}");
                Console.WriteLine($"Tipo: {filmeConvertido.Type}");


                Console.WriteLine("Deseja pesquisar outro filme? (Sim  = s/ Não = n)");
                decisao = Console.ReadLine();
                Console.WriteLine();
            } while (decisao.ToUpper() == "S"); 
        }
    }
}
