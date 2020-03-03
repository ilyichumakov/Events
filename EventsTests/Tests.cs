using System;
using System.Collections.Generic;
using NUnit.Framework;
using Events;
using System.Drawing;

namespace EventsTests
{
    [TestFixture]
    public class Tests
    {
        private Lamp lamp;
        private ColorCounter cnt;

        [SetUp]
        public void init()
        {
            lamp = new Lamp();
            cnt = new ColorCounter();
        }

        [Test]
        public void defaultStateTest()
        {
            Assert.AreEqual(lamp.State, false);
        }

        [Test]
        public void StateChangesOnTest()
        {
            lamp.turnOn();
            Assert.AreEqual(lamp.State, true);
        }

        [Test]
        public void StateChangesOffTest()
        {
            lamp.turnOn();
            lamp.turnOff();
            Assert.AreEqual(lamp.State, false);
        }

        [Test]
        public void StateEventThrowsTest()
        {
            Color c = Color.AliceBlue;
            lamp.Observers += ((Color p) => c = p); 
            lamp.turnOn();
            Assert.AreEqual(lamp.CurrentColor, c);
        }

        [Test]
        public void CntEventThrowsTest()
        {
            int c = 0;
            lamp.CntObservers += ((int p) => c = p);
            lamp.turnOn();
            Assert.AreEqual(lamp.Counter, c);
        }

        [Test]
        public void DoubleOnTest()
        {
            int c = 0;
            lamp.CntObservers += ((int p) => c = p);
            lamp.turnOn();
            lamp.turnOn();
            Assert.AreEqual(1, c);
        }

        [Test]
        public void DoubleOffTest()
        {
            Color c = Color.AliceBlue;
            lamp.Observers += ((Color p) => c = p);            
            lamp.turnOff();
            lamp.turnOff();
            Assert.AreEqual(Color.AliceBlue, c);
        }
    }
}
