using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ConsultaPokemons.Models;

namespace ConsultaPokemons.Service
{
    public class RequisicaoPokeAPI
    {

        public void Requisicao(string pokemonName)
        {
            var client = new RestClient($"https://pokeapi.co/api/v2/pokemon/{pokemonName}");
            var request = new RestRequest("", Method.Get);

            var response = client.Execute(request);

            InfosPokemon infos = JsonConvert.DeserializeObject<InfosPokemon>(response.Content);

            PokemonHabilidades habilidades = JsonConvert.DeserializeObject<PokemonHabilidades>(response.Content);

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("-----------------------------INFORMAÇÕES----------------------------\n");
                Console.WriteLine($"Altura: {infos.height}");
                Console.WriteLine($"Peso: {infos.weight}");
                Console.WriteLine("Habilidades:");
                foreach (var habilidade in habilidades.abilities)
                {
                    Console.WriteLine($"- {habilidade.ability.name}");
                }
                Console.WriteLine("\n-------------------------------------------------------------------");
            }
            else
            {
                Console.WriteLine(response.ErrorMessage);
            }
        }

        

    }
}
