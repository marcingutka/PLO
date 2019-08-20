using System;
using System.Collections.Generic;
using System.Text;

namespace PLO.Creatures
{
    public class RedCreatureLvl1 : ICreature
    {
        public RedCreatureLvl1(){ Level = 1; }

        override public int GetLevel() { return Level; }
    }
}
