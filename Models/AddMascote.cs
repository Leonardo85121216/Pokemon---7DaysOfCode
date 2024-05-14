using ConsultaPokemons.Service;
using System;
using System.Collections.Generic;

namespace ConsultaPokemons.Models
{
    public class AddMascote
    {
        public void AdicionarMascote(string nomeUsuario, Dictionary<string, StatusMascotes> mascotes, string mascote)
        {
            RequisicaoPokeAPI pokeAPI = new RequisicaoPokeAPI();
            int opcaoSobreMascote = 0;

            while (opcaoSobreMascote != 3)
            {
                opcaoSobreMascote = MenuAddMascote(nomeUsuario, mascote);

                switch (opcaoSobreMascote)
                {
                    case 1:
                        pokeAPI.Requisicao(mascote);
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadLine();
                        break;

                    case 2:
                        if (!mascotes.ContainsKey(mascote))
                        {
                            mascotes[mascote] = new StatusMascotes();
                            Console.WriteLine($"{mascote} foi adotado!");
                        }
                        else
                        {
                            Console.WriteLine($"{mascote} já foi adotado.");
                        }
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
        }

        public int MenuAddMascote(string nomeUsuario, string mascote)
        {
            Console.WriteLine("---------------------------------------------------------------------------\n" +
                              $"{nomeUsuario}, você deseja:\n" +
                              $"1 - Saber mais sobre {mascote}\n" +
                              $"2 - Adotar {mascote}\n" +
                              "3 - Voltar");
            int opcaoSobreMascote = int.Parse(Console.ReadLine());
            return opcaoSobreMascote;
        }
    }
}
