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

            int ActualDamage = testHero.GetWeaponDamage("sword");
            int ExpectedDamage = 8;
            Assert.AreEqual(ExpectedDamage, ActualDamage);
        }


        // sprawdzić czy dla każdej broni zwraca obrażenia
        [Test]
        public void HeroTests3()
        {
            List<string> Names = testHero.GetWeaponNames();
            foreach (var TestWeapon in Names)
            {
                int Damage = testHero.GetWeaponDamage(TestWeapon);
                Console.WriteLine($"weapon: {TestWeapon}   damage: {Damage}");
            }

            //int AxeDamage = testHero.ReturnDamage("axe");
            //int AxeExpDmg = 12;

            //int SwordDamage = testHero.ReturnDamage("sword");
            //int SwordExpDmg = 8;

            //int FireballDamage = testHero.ReturnDamage("fireball");
            //int FireballExpDmg = 12;
        }

        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine("I'm cleaning DB!");
        }

    }
}
