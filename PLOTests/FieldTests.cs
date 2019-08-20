using NUnit.Framework;
using PLO.Field;

namespace Tests
{
    public class FieldTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Field field = new Field();

            Assert.AreEqual(field.IsActive, true);
            Assert.AreEqual(field.NeutralDomination, 1);
        }
    }
}
