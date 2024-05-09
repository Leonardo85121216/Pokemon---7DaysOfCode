using System;
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json;
using ConsultaPokemons;
using ConsultaPokemons.Models;

namespace ConsultaPokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            //int limit = int.Parse(Console.ReadLine());
            string pokemonName = Console.ReadLine();
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemonName}");
            var request = new RestRequest("", Method.Get);

            var response = client.Execute(request);

            InfosPokemon infos = JsonConvert.DeserializeObject<InfosPokemon>(response.Content);

            PokemonHabilidades habilidades = JsonConvert.DeserializeObject<PokemonHabilidades>(response.Content);
            
            
            
            
            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine($"Altura: {infos.height}");
                Console.WriteLine($"Peso: {infos.weight}");
                Console.WriteLine("Habilidades:");
                foreach (var habilidade in habilidades.abilities)
                {
                    Console.WriteLine(habilidade.ability.name);
                }
                Console.WriteLine("----------------------------------------");
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
            
        }
    }
}
