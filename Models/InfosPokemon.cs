using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaPokemons.Models
{
    public class InfosPokemon
    {
        public string height {  get; set; }
        public string weight { get; set; }
    }

    public class PokemonHabilidades
    {
        public List<HabilidadeInfo> abilities { get; set; }
    }


    public class HabilidadeInfo
    { 
        public Habilidade ability { get; set; }
    }


    public class Habilidade
    {
        public string name { get; set; }
    }

}
