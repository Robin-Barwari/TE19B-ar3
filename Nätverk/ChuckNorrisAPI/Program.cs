using System;
using System.Text.Json;
using RestSharp;

namespace ChuckNorrisAPI
{
    class Program
    {
        class Joke
        {
            public string icon_url { get; set; }
            public string id { get; set; }
            public string value { get; set; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Chuck Norris Skämt");

            // Hämta ett skämt från api.chucknorris.io
            string url = "https://api.chucknorris.io/jokes";
            var client = new RestClient(url);
            var request = new RestRequest("random", DataFormat.Json);
            var response = client.Get(request);

            Console.WriteLine(response.Content);

            // Avkoda Json-svaret
            Joke skämtet = new Joke();
            // Stoppa in svaret i Joke-objektet
            skämtet = JsonSerializer.Deserialize<Joke>(response.Content);

            // Skriv ut skämtet
            Console.WriteLine(skämtet.value);
        }
    }
}
