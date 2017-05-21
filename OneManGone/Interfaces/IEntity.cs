
using static OneManGone.Helpers.Enums;

namespace OneManGone.Interfaces
{
    
    public interface IEntity
    {
        string Name { get; set; }
        float XPos { get; set; }
        float YPos { get; set; }
        EntityState State { get; set; }

    }
}
