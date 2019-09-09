using System;
using System.Collections.Generic;
using System.Text;

namespace PLO.RegionTiles
{
    public static class TileSets
    {
        public static readonly List<Tile> TwoPlayersTiles = new List<Tile>
        {
            new Tile(1, 0, 1, 1, 5, 4, 0),
            new Tile(2, 0, 1, 1, 5, 3, 0),
            new Tile(3, 1, 1, 1, 5, 3, 0),
            new Tile(4, 1, 1, 1, 4, 2, 0),
            new Tile(5, 0, 2, 1, 4, 2, 0),
            new Tile(6, 0, 1, 2, 3, 2, 0)
        };

        public static readonly List<Tile> ThreePlayersTiles = new List<Tile>
        {
            new Tile(1, 0, 1, 1, 6, 4, 3),
            new Tile(2, 1, 1, 1, 5, 3, 2),
            new Tile(3, 1, 1, 1, 5, 3, 2),
            new Tile(4, 0, 1, 2, 5, 2, 2),
            new Tile(5, 1, 2, 1, 4, 2, 1),
            new Tile(6, 0, 2, 2, 4, 2, 1),
            new Tile(7, 0, 2, 2, 4, 2, 1)
        };

        public static readonly List<Tile> FourPlayersTiles = new List<Tile>
        {
            new Tile(1, 0, 1, 1, 6, 4, 3),
            new Tile(2, 1, 1, 1, 6, 4, 3),
            new Tile(3, 1, 1, 1, 6, 4, 3),
            new Tile(4, 1, 1, 1, 5, 3, 2),
            new Tile(5, 0, 1, 2, 5, 3, 2),
            new Tile(6, 1, 2, 1, 5, 3, 2),
            new Tile(7, 0, 2, 2, 4, 2, 1),
            new Tile(8, 0, 2, 2, 4, 2, 1)
        };
    }
}
