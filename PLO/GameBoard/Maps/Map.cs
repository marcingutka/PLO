using System;
using System.Collections.Generic;
using System.Text;

using PLO.RegionTiles;

namespace PLO.GameBoard.Maps
{
    using Field = Field.Field;
    public class Map
    {
        public readonly List<Field> map = new List<Field>();
        public readonly Dictionary<int, Field> orderOfFields = new Dictionary<int, Field>();

        public Map()
        {
            for(int i = 0; i < 8; i++)
            {
                map.Add(new Field());
            }
        }

        public void AssignTilesToFields(List<int> orderOfTiles, List<Tile> listOfTiles)
        {
            int i = 0;
            foreach(var f in map)
            {
                if (f.IsActive == true)
                {
                    f.Tile = listOfTiles[orderOfTiles[i]];
                    orderOfFields[orderOfTiles[i]] = f;
                    i++;
                }
            }
        }

        public void DeactivateField(int fieldNumber)
        {
            map[fieldNumber - 1].IsActive = false;
        }
        public void AddThorn(int fieldNumber)
        {
            map[fieldNumber - 1].Thorn = true;
        }
        public bool AddSacredSpot(int fieldNumber)
        {
            map[fieldNumber - 1].Sacred_Spot = true;
            return map[fieldNumber - 1].Sacred_Spot;
        }
    }
}
