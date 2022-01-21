using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonJSONEditor_WinForm.Models
{
    public class Pokemon
    {
        public string name { get; set; }
        public string id { get; set; }
        public string imageurl { get; set; }
        public PokeDex[] description { get; set; }
        public string height { get; set; }
        public string category { get; set; }
        public string weight { get; set; }
        public string[] type { get; set; }
        public string[] weaknesses { get; set; }
        public string[] evolutions { get; set; }
        public string[] abilities { get; set; }
        public int hp { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        public int special_attack { get; set; }
        public int special_defense { get; set; }
        public int speed { get; set; }
        public int total { get; set; }
        public int catch_rate { get; set; }
        public CatchLocation[] catch_location { get; set; }
        public string male_percentage { get; set; }
        public string female_percentage { get; set; }
        public string sexless { get; set; }
        public string hatch_time { get; set; }
        public string egg_groups { get; set; }
        public string evolvedfrom { get; set; }
        public string evolution_cause { get; set; }
        public int base_exp { get; set; }
        public EV[] ev { get; set; }
    }
}
