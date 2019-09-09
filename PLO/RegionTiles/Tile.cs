using System;
using System.Collections.Generic;
using System.Text;

namespace PLO.RegionTiles
{
    public struct Tile
    {
        public int Number { get; private set; }
        public int FactorM { get; private set; }
        public int Gold { get; private set; }
        public int Population { get; private set; }
        public int FirstReward { get; private set; }
        public int SecondReward { get; private set; }
        public int ThirdReward { get; private set; }

        public Tile(int _number, int _factorM, int _gold, int _population, int _firstReward, int _secondReward, int _thirdReward)
        {
            Number = _number;
            FactorM = _factorM;
            Gold = _gold;
            Population = _population;
            FirstReward = _firstReward;
            SecondReward = _secondReward;
            ThirdReward = _thirdReward;
        }
    }
}
