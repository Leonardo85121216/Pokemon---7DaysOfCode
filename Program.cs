using System;
using RestSharp;
using Newtonsoft;
using Newtonsoft.Json;
using ConsultaPokemons;
using ConsultaPokemons.Models;
using ConsultaPokemons.Service;
using ConsultaPokemons.View;

namespace ConsultaPokemons
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu Nome: ");
            string nomeUsuario = Console.ReadLine();

            Console.Clear();

            TamagochiView view = new TamagochiView();

            view.App(nomeUsuario);
            
        }
    }
}
