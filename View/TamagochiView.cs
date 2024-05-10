using ConsultaPokemons.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPokemons.View
{
    public class TamagochiView
    {
        public void App(string nomeUsuario)
        {
            List<string> mascotes = new List<string>();

            int opcao = 1;

            while (opcao != 3)
            {
                opcao = Menu(nomeUsuario);

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

                        AddMascote addMascote = new AddMascote();
                        addMascote.AdcionarMascote(nomeUsuario, mascotes, mascote);

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

        public int Menu(string nomeUsuario)
        {
            Console.WriteLine
                (
                    "----------------------------- MENU -----------------------------\n" +
                    $"{nomeUsuario} Você deseja:\n" +
                    "1 - Adotar um Mascote Virtual\n" +
                    "2 - Ver seus Mascotes\n" +
                    "3 - Sair"
                );

            int opcao = int.Parse(Console.ReadLine());

            return opcao;
        }
    }
}
