using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneManGone.Interfaces
{
    public interface IPlayer : IEntity, ILevelable
    {
        Texture2D Texture { get; set; }
        Vector2 Position { get; set; }
        Vector2 Velocity { get; set; }
        

    }
}
