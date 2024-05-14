using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPokemons.Models
{
    
    public class StatusMascotes
    {
        List<string> ListHumor = new List<string> {"Triste", "Feliz", "Raivoso" };
        List<string> ListAlimentacao = new List<string> {"Esfomeado", "Alimentado" };
        public string Alimentacao { get; private set; }
        public string Humor { get; private set; }

        public StatusMascotes()
        {
            Random rnd = new Random();
            int indiceHumor = rnd.Next(ListHumor.Count);
            int indiceAlimentacao = rnd.Next(ListAlimentacao.Count);

            Alimentacao = ListAlimentacao[indiceAlimentacao];
            Humor = ListHumor[indiceHumor];
        }



        public void ExibirStatus(string nomeMascote)
        {
            Console.WriteLine("-----------------------------STATUS----------------------------\n");

            Console.WriteLine
                (

                    $"{nomeMascote} Está {Humor}\n" +
                    $"{nomeMascote} Está {Alimentacao}"
                );
            Console.WriteLine("\n--------------------------------------------------------------");

        }
        public void Alimentar()
        {
            Alimentacao = "Alimentado";
        }
        public void Brincar()
        {
            Humor = "Feliz";
        }
    }
}
