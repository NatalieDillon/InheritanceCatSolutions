using Microsoft.VisualStudio.TestTools.UnitTesting;
using InheritanceCat.Classes;

namespace InheritanceCat.Tests
{
    [TestClass]
    public class CatTests
    {
        [TestMethod]
        public void DomesticCatShouldBeAwakeByDefault()
        {
            DomesticCat domesticCat = new();
            Assert.AreEqual(false, domesticCat.IsAsleep);
        }

        [TestMethod]
        public void DomesticCatShouldBeAsleepWhenGoToSleepIsCalled()
        {
            DomesticCat domesticCat = new();
            domesticCat.GoToSleep();
            Assert.AreEqual(true, domesticCat.IsAsleep);
        }

        [TestMethod]
        public void DomesticCatShouldBeAwakeWhenWakeUpIsCalled()
        {
            DomesticCat domesticCat = new();
            domesticCat.GoToSleep();
            domesticCat.WakeUp();
            Assert.AreEqual(false, domesticCat.IsAsleep);
        }

        [TestMethod]
        public void DomesticCatSettingShouldBeDomestic()
        {
            DomesticCat domesticCat = new();
            Assert.AreEqual("domestic", domesticCat.Setting);
        }

        [TestMethod]
        public void DomesticCatAverageHeightShouldBeCorrect()
        {
            DomesticCat domesticCat = new();
            Assert.AreEqual(23, domesticCat.AverageHeight);
        }

        [TestMethod]
        public void LionAverageHeightShouldBeCorrect()
        {
            Lion lion = new();
            Assert.AreEqual(1100, lion.AverageHeight);
        }

        [TestMethod]
        public void LionShouldRoarWhenEatIsCalled()
        {
            Lion lion = new();
            Assert.AreEqual("Roar!!!!", lion.Eat());
        }

        [TestMethod]
        public void CheetahShouldSnoreWhenEatIsCalled()
        {
            Cheetah cheetah = new();
            Assert.AreEqual("Zzzzzz", cheetah.Eat());
        }

        [TestMethod]
        public void DomesticCatShouldPurrWhenEatIsCalled()
        {
            DomesticCat domesticCat = new();
            Assert.AreEqual("Purrrrrrr", domesticCat.Eat());
        }
    }
}