using NUnit.Framework;
using System.Collections.Generic;
using System;

using PLO;

namespace Tests
{
    class RandomGeneratorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void RandomGeneratorForOneElement()
        {
            var result = RandomGenerator.Draw(1);

            Assert.AreEqual(0, result[0]);            
        }
        [Test]
        public void RandomGeneratorForTwoElements()
        {
            var result = RandomGenerator.Draw(2);

            if (result[0] == 0) Assert.AreEqual(1, result[1]);
            else Assert.AreEqual(0, result[1]);
        }
    }
}
