using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataCore.Models
{
    public partial class Hall
    {
        public int HallId { get; set; }
        public int KnightId { get; set; }

        public virtual Knight Knight { get; set; }
    }
}
