using NUnit.Framework;
using PLO.Board.Maps;

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
            Map map = new Map();

            Assert.AreEqual(9, map.map.Count);
            foreach(var m in map.map)
            {
                Assert.AreEqual(1, m.NeutralDomination);
                Assert.AreEqual(true, m.IsActive);
            }
        }
    }
}
