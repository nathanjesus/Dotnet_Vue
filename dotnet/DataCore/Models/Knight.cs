using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataCore.Models
{
    public partial class Knight
    {
        public Knight()
        {
            Hall = new HashSet<Hall>();
            KnightWeapon = new HashSet<KnightWeapon>();
        }

        public int KnightId { get; set; }
        public string Name { get; set; }
        public string Nickname { get; set; }
        public string Birthday { get; set; }
        public string KeyAttribute { get; set; }
        public int? Idade { get; set; }
        public int? Armas { get; set; }
        public int? Ataque { get; set; }
        public decimal? Exp { get; set; }
        public int? AttributeId { get; set; }
        public bool? IsAtivo { get; set; }

        public virtual Attributes Attribute { get; set; }
        public virtual ICollection<Hall> Hall { get; set; }
        public virtual ICollection<KnightWeapon> KnightWeapon { get; set; }
    }
}
