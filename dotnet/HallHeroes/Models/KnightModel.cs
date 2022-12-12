using DataCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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
            var attrribute = ObterValoresPropriedades(knight.Attribute, atributo);
            var modWeapns = (int)knight.KnightWeapon.Sum(w => w.Weapon.Mod);
            ataque = getAtaque(attrribute, modWeapns);
        }
        

        public int id { get; set; }
        public string name { get; set; }
        public int idade { get; set; }
        public int armas { get; set; }
        public string atributo { get; set; }
        public int ataque { get; set; }
        public double Exp => Math.Floor((idade - 7) * Math.Pow(22, 1.45));
        private int getAtaque(int keyAttr, int weaponsMods)
        {
            var ataque = 0;
            if (keyAttr >= 0 && keyAttr <= 8) ataque = - 2;
            else if (keyAttr >= 9 && keyAttr <= 10)  ataque = -1;
            else if (keyAttr >= 11 && keyAttr <= 12) ataque = 0;
            else if (keyAttr >= 13 && keyAttr <= 15) ataque = 1;
            else if (keyAttr >= 16 && keyAttr <= 18) ataque = 2;
            else if (keyAttr >= 19 && keyAttr <= 20) ataque = 3;
            return 10 + ataque + weaponsMods;
        }

        private int ObterValoresPropriedades(object objeto, string  keyAttribute)
        {
            foreach (var item in objeto.GetType().GetProperties())
            {
                if (item.Name == keyAttribute) return Convert.ToInt32(item.GetValue(objeto));
            }
            return 0;
        }
    }
}
