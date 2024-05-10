using ConsultaPokemons.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPokemons.View
{
    public class AddMascote
    {
        public void AdcionarMascote(string nomeUsuario, List<string> mascotes, string mascote)
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


        }

        public int MenuAddMascote(string nomeUsuario, string mascote)
        {
            Console.WriteLine
            (
                "---------------------------------------------------------------------------\n" +
                $"{nomeUsuario}, você deseja:\n" +
                $"1 - Saber mais sobre {mascote}\n" +
                $"2 - Adotar {mascote}\n" +
                "3 - Voltar"
            );

            int opcaoSobreMascote = int.Parse(Console.ReadLine());

            return opcaoSobreMascote;
        }

    }
}
