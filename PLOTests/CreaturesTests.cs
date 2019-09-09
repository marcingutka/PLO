using NUnit.Framework;
using PLO.Creatures;

namespace Tests
{
    public class CreaturesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ICreature creature = new RedCreatureLvl1();
            
            Assert.AreEqual(creature.Level, 1);
        }
    }
}