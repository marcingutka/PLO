using System;
using System.Collections.Generic;
using System.Text;

namespace PLO.Creatures
{
    public abstract class ICreature
    {
        public int Level { get; protected set; }
        public abstract int GetLevel();
    }
}
