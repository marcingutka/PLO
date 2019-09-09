using System;
using System.Collections.Generic;
using System.Text;

using PLO.GameBoard;
using PLO.RegionTiles;

namespace PLO
{
    class Controller
    {
        public Board GameBoard = new Board();
        public List<int> RandomTile(int numberOfFields)
        {
            return RandomGenerator.Draw(numberOfFields);
        }
    }
}
