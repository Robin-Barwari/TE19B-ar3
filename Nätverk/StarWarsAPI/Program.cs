using System;
using System.Collections.Generic;
using RestSharp;
using System.Text.Json;


namespace StarWarsAPI
{
    class Program
    {

        class StarWars
        {
            public string name {get; set;}
        }
        class People
        {
            public List<StarWars> results {get; set;}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta StarWars info");
            // Hämta en person från StarWarsAPI
            string url = "https://swapi.dev/api";
            var client = new RestClient(url);
            var request = new RestRequest("people", DataFormat.Json);
            var response = client.Get(request);

            // Avkoda Json-svaret
            People lista = new People();
            lista = JsonSerializer.Deserialize<People>(response.Content);

            // Skriv ut alla personer
            if (lista != null)
            {
                foreach (var item in lista.results)
                {
                    Console.WriteLine(item.name);
                }
            }
        }
    }
}
