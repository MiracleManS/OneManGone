using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneManGone.Interfaces
{
    
    public interface IEntity
    {
        string Name { get; set; }
        Vector2 Position { get; set; }
        Vector2 Velocity { get; set; }
    }
}
