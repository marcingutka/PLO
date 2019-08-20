using System;
using System.Collections.Generic;
using System.Text;
using PLO.Creatures;

namespace PLO.Field
{
    public class Field
    {
        public bool Sacred_Spot { get; set; }
        public bool Thorn { get; private set; }
        public int Gold { get; private set; }
        public int Population { get; private set; }
        public int FactorM { get; private set; }
        readonly List<int> Points = new List<int>();
        readonly Dictionary<ICreature, int> RedCreatures = new Dictionary<ICreature, int>(); //może lista??
        readonly Dictionary<ICreature, int> BlackCreatures = new Dictionary<ICreature, int>();
        readonly Dictionary<ICreature, int> GreenCreatures = new Dictionary<ICreature, int>();
        readonly Dictionary<ICreature, int> BlueCreatures = new Dictionary<ICreature, int>();
        readonly Dictionary<ICreature, int> NeutralCreatures = new Dictionary<ICreature, int>();
        public int RedDomination { get; set; }
        public int BlackDomination { get; set; }
        public int GreenDomination { get; set; }
        public int BlueDomination { get; set; }
        public int NeutralDomination { get; private set; }
        public bool IsActive { get; set; }

        public Field()
        {
            IsActive = true;
            NeutralDomination = 1;
        }
    }
}
