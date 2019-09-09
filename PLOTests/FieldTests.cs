using NUnit.Framework;
using PLO.Field;
using System.Collections.Generic;

namespace Tests
{
    public class FieldTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreatingField()
        {
            Field field = new Field();
            Assert.AreEqual(field.NeutralDomination, 1);
        }
    }
}
