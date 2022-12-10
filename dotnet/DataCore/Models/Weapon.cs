using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataCore.Models
{
    public partial class Weapon
    {
        public Weapon()
        {
            KnightWeapon = new HashSet<KnightWeapon>();
        }

        public int WeaponId { get; set; }
        public string Name { get; set; }
        public int? Mod { get; set; }
        public string Attr { get; set; }
        public bool Equipped { get; set; }

        public virtual ICollection<KnightWeapon> KnightWeapon { get; set; }
    }
}
