using System;

namespace HallHeroes.Data.Models
{
    public class Weapon
    {
        public int id { get; set; }
        public string name { get; set; }

        public int mod { get; set; }

        public string attr { get; set; }

        public bool equipped { get; set; }
    }
}
