using ConsultaPokemons.Service;
using System;
using System.Collections.Generic;

namespace ConsultaPokemons.Models
{
    public class InteracaoPokemons
    {
        private Dictionary<string, StatusMascotes> mascotes;
        RequisicaoPokeAPI requisicao = new RequisicaoPokeAPI();

        public InteracaoPokemons(Dictionary<string, StatusMascotes> mascotes)
        {
            this.mascotes = mascotes;
        }

        public void Interacao(string nomeUsuario, string nomeMascote)
        {
            int opcao = 1;

            while (opcao != 4)
            {
                Menu(nomeUsuario, nomeMascote);
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        requisicao.Requisicao(nomeMascote);
                        mascotes[nomeMascote].ExibirStatus(nomeMascote);
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadLine();
                        break;

                    case 2:
                        mascotes[nomeMascote].Alimentar();
                        Console.WriteLine($"{nomeMascote} foi alimentado.");
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadLine();
                        break;

                    case 3:
                        mascotes[nomeMascote].Brincar();
                        Console.WriteLine($"Você brincou com {nomeMascote}.");
                        Console.WriteLine("Aperte ENTER para continuar");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção incorreta.\nENCERRANDO...");
                        break;
                }
                Console.Clear();
            }
        }

        private void Menu(string nomeUsuario, string nomeMascote)
        {
            Console.Clear();
            Console.WriteLine($"{nomeUsuario}, você deseja:\n" +
                              $"1 - Saber como {nomeMascote} está\n" +
                              $"2 - Alimentar {nomeMascote}\n" +
                              $"3 - Brincar com {nomeMascote}\n" +
                              "4 - Sair");
        }
    }
}
