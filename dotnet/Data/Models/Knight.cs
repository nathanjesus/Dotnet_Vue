using HallHeroes.Data.Models;
using System;
using System.Collections.Generic;

namespace HallHeroes.Data.Models
{
    public class Knight
    {
        public Knight()
        {
            weapons = new HashSet<Weapon>();
        }
        public int id { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public string birthday { get; set; }
        public IEnumerable<Weapon> weapons { get; set; }
        public Attributes attributes { get; set; }
        public string keyAttribute { get; set; }
        public int Idade { get; set; }
        public int Armas { get; set; }
        public int Ataque { get; set; }
        public double Exp => Math.Floor((Idade - 7) * Math.Pow(22, 1.45));



    }
}
