using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneManGone.Interfaces
{
    public interface ILevelable
    {
        int Health { get; set; }
        int Strength { get; set; }
        int Agility { get; set; }
        int Intelligence { get; set; }
        int Luck { get; set; }
        int Defense { get; set; }
    }
}
