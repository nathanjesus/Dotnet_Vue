using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataCore.Models
{
    public partial class KnightWeapon
    {
        public int KnightId { get; set; }
        public int WeaponId { get; set; }

        public virtual Knight Knight { get; set; }
        public virtual Weapon Weapon { get; set; }
    }
}
