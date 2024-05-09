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
            Console.WriteLine("Digite seu Nome: ");
            string nomeUsuario = Console.ReadLine();

            Console.Clear();

            List<string> mascotes = new List<string>();
            RequisicaoPokeAPI pokeAPI = new RequisicaoPokeAPI();

            int opcao = 0;

            while (opcao != 3)
            {
                Console.WriteLine
                (
                    "----------------------------- MENU -----------------------------\n" +
                    $"{nomeUsuario} Você deseja:\n" +
                    "1 - Adotar um Mascote Virtual\n" +
                    "2 - Ver seus Mascotes\n" +
                    "3 - Sair"
                );
                opcao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine
                        (
                            "------------------------------ ADOTAR MASCOTE ------------------------------\n" +
                            $"{nomeUsuario}, escolha um mascote: "
                        );
                        string mascote = Console.ReadLine();
                        Console.Clear();

                        int opcaoSobreMascote = 0;

                        while (opcaoSobreMascote != 3)
                        {
                            Console.WriteLine
                                (
                                    "---------------------------------------------------------------------------\n" +
                                    $"{nomeUsuario}, você deseja:\n" +
                                    $"1 - Saber mais sobre {mascote}\n" +
                                    $"2 - Adotar {mascote}\n" +
                                    "3 - Voltar"
                                );

                            opcaoSobreMascote = int.Parse(Console.ReadLine());

                            switch (opcaoSobreMascote)
                            {
                                case 1:
                                    pokeAPI.Requisicao(mascote);
                                    Console.WriteLine("Aperte ENTER para continuar");
                                    Console.ReadLine();
                                    break;
                                case 2:
                                    mascotes.Add(mascote);
                                    Console.WriteLine($"{mascote} foi adotado!");
                                    Console.WriteLine("Aperte ENTER para continuar");
                                    Console.ReadLine();
                                    break;
                                case 3:
                                    Console.WriteLine("Voltando ao menu principal...");
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida. Por favor, escolha novamente.");
                                    break;
                            }
                            Console.Clear();
                        }
                        break;


                    case 2:

                        for (int i = 0; i < mascotes.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {mascotes[i]}");
                        }

                        Console.WriteLine("Aperte ENTER para sair\n");
                        Console.ReadLine();
                        break;
                    case 3:

                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção incorreta.\nENCERRANDO...");
                        break;
                }

                Console.Clear();
            }
            
        }
    }
}
