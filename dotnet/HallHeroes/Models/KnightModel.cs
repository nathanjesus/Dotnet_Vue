using DataCore.Models;
using System;

namespace HallHeroes.Models
{
    public class KnightModel
    {
        public KnightModel(Knight knight)
        {
            id = knight.KnightId;
            name = knight.Name;
            idade = (int)knight.Idade;
            armas = (int)knight.Armas;
            atributo = knight.KeyAttribute;
            ataque = (int)knight.Ataque;
       
        }
        

        public int id { get; set; }
        public string name { get; set; }
        public int idade { get; set; }
        public int armas { get; set; }
        public string atributo { get; set; }
        public int ataque { get; set; }
        public double Exp => Math.Floor((idade - 7) * Math.Pow(22, 1.45));
    }
}
