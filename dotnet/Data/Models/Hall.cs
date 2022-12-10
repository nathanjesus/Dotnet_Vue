using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HallHeroes.Data.Models
{
    public class Hall
    {
        public IEnumerable<Knight> knights { get; set; }
    }
}
