using NUnit.Framework;
using System.Collections.Generic;
using PLO.GameBoard.Maps;
using PLO.RegionTiles;

namespace Tests
{
    public class MapTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreatingMap()
        {
            
            List < List<int> > RegionTiles = new List<List<int>>();
            for(int i = 0; i < 8; i++)
            {
                List<int> RegionTile = new List<int> { i, i, i };
                RegionTiles.Add(RegionTile);
            }
            Map map = new Map();

            Assert.AreEqual(8, map.map.Count);
            foreach(var m in map.map)
            {
                Assert.AreEqual(1, m.NeutralDomination);
            }
        }

        [Test]
        public void CreatingMapWithRegionTilesForFourPlayers()
        {
            Map map = new Map();
            List<int> orderOfTiles = new List<int> {4, 2, 0, 1, 3, 6, 5, 7};

            map.AssignTilesToFields(orderOfTiles, TileSets.FourPlayersTiles);
            
            Assert.AreEqual(2, map.map[1].Tile.Number - 1);
        }

        [Test]
        public void CreatingMapWithRegionTilesForThreePlayers()
        {
            Map map = new Map();
            List<int> orderOfTiles = new List<int> { 4, 2, 0, 1, 3, 6, 5 };
            map.DeactivateField(5);
            map.AssignTilesToFields(orderOfTiles, TileSets.ThreePlayersTiles);

            Assert.AreEqual(2, map.map[1].Tile.Number - 1);
            Assert.AreEqual(5, map.map[7].Tile.Number - 1);
        }
    }
}
