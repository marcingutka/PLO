using System;
using System.Collections.Generic;
using System.Text;

namespace PLO.Board.Maps
{
    using Field = Field.Field;
    public class Map
    {
        public readonly List<Field> map = new List<Field>();

        public Map()
        {
            for(int i = 0; i < 9; i++)
            {
                map.Add(new Field());
            }
        }
    }
}
