using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Fundamentals.RPG
{
    [TestFixture]
    public class hero_test
    {
       [Test]
       public void test_weapon()
        {
            Heroes NewHero = new Heroes(100);
            var ActualWeapons = NewHero.GetWeaponNames();
            List<string> ExpectedList = new List<string> {"sword", "axe", "fireball"};
            Assert.AreEqual(ExpectedList, ActualWeapons);
        }

    }
}
