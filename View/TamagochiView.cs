using ConsultaPokemons.Models;
using ConsultaPokemons.Service;
using System;
using System.Collections.Generic;

namespace ConsultaPokemons.View
{
    public class TamagochiView
    {
        private Dictionary<string, StatusMascotes> mascotes = new Dictionary<string, StatusMascotes>();

        public void App(string nomeUsuario)
        {
            int opcao = 1;

            while (opcao != 4)
            {
                opcao = Menu(nomeUsuario);
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine
                            (
                                "--------------------------------------------------\n" +
                                $"{nomeUsuario}, escolha um mascote: "
                            );

                        string mascote = Console.ReadLine();
                        Console.Clear();

                        AddMascote addMascote = new AddMascote();
                        addMascote.AdicionarMascote(nomeUsuario, mascotes, mascote);

                        break;

                    case 2:
                        ListarMascotes();
                        Console.WriteLine("Aperte ENTER para sair\n");
                        Console.ReadLine();

                        break;

                    case 3:
                        Console.WriteLine("Escolha um mascote para interagir: ");
                        ListarMascotes();
                        string mascoteEscolhido = Console.ReadLine();

                        if (mascotes.ContainsKey(mascoteEscolhido))
                        {
                            var interacao = new InteracaoPokemons(mascotes);
                            interacao.Interacao(nomeUsuario, mascoteEscolhido);
                        }
                        else
                        {
                            Console.WriteLine("Mascote não encontrado.");
                        }

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

        private int Menu(string nomeUsuario)
        {
            Console.WriteLine
                    (
                        "--------------------------------------------------\n" +
                        $"{nomeUsuario}, você deseja:\n" +
                        "1 - Adotar um Mascote Virtual\n" +
                        "2 - Ver seus Mascotes\n" +
                        "3 - Interagir com seus mascotes\n" +
                        "4 - Sair"
                    );
            int opcao = int.Parse(Console.ReadLine());
            return opcao;
        }

        private void ListarMascotes()
        {
            foreach (var mascote in mascotes.Keys)
            {
                Console.WriteLine(mascote);
            }
        }
    }
}
