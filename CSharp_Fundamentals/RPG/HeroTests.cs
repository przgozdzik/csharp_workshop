using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Fundamentals.RPG
{
    [TestFixture]
    public class HeroTests
    {
        private Heroes testHero;

        [SetUp]
        public void SetUp()
        {
            testHero = new Heroes(100);
        }

        [Test]
        public void HeroTests1()
        {
            var ActualWeapons = testHero.GetWeaponNames();
            List<string> ExpectedList = new List<string> { "sword", "axe", "fireball" };
            Assert.AreEqual(ExpectedList, ActualWeapons);
        }

        [Test]
        public void HeroTests2()
        {
            testHero.Take_Damage(50);
            testHero.Is_alive();

            bool HeIsAlive = testHero.Is_alive();
            Console.WriteLine(HeIsAlive);

            int ActualDamage = testHero.ReturnDamage("sword");



            //{
            //    this.
            //}
            int ExpectedDamage = 8;
            Assert.AreEqual(ExpectedDamage, ActualDamage);
        }

        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine("I'm cleaning DB!");
        }

    }
}
