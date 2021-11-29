using System.Collections.Generic;
using System;
using RestSharp;
using System.Text.Json;

namespace PokeAPI
{
    class Program
    {

        class Pokemon
        {
            public string name {get;set;}
        }
        class Pokemons
        {
            public int count {get;set;}
            public string next {get;set;}
            public List<Pokemons> results {get;set;}
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hämta Pokemon info");
            // Hämta ett skämt från pokeapi
            string url = "https://pokeapi.co/api/v2";
            var client = new RestClient(url);
            var request = new RestRequest("Pokemon", DataFormat.Json);
            var response = client.Get(request);

            // Kolla på svaret
            System.Console.WriteLine(response.Content);

            // Avkoda Json-svaret
            Pokemons lista = new Pokemons();
            lista = JsonSerializer.Deserialize<Pokemons>(response.Content);

            // Skriv ut alla pokemons
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
