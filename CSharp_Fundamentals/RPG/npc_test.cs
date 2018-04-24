using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharp_Fundamentals.RPG
{
    [TestFixture]
    public class npc_test
    {
        [Test]
        public void Attack()
        {
            npc test_npc = new npc(100);
            test_npc.Attack();

            Assert.AreEqual(test_npc.Attack(), 10, "Different than 10");
        }

        [Test]
        public void life()
        {
            npc life_npc = new npc(100);
                  
            Assert.AreEqual(life_npc.current_life, 100, "False");
            Assert.AreEqual(life_npc.max_life, 100, "False");
        }

        [Test]
        public void life2()
        {
            npc life2_npc = new npc(100, 80);

            Assert.AreEqual(life2_npc.max_life, 100, "False");
            Assert.AreEqual(life2_npc.current_life, 80, "False");
        }

        [Test]
        public void zmienne_referencyjne()
        {
            npc life2_npc = new npc(100, 80);
            Assert.AreEqual(life2_npc.max_life, 100, "False");
            Assert.AreEqual(life2_npc.current_life, 80, "False");


            life2_npc.max_life = 50;
            Assert.AreEqual(life2_npc.max_life, 50, "False");
            life2_npc.current_life = 30;

            npc life3_npc = life2_npc;

            // npc life3_npc = new npc(20,10); // "new" łamie powiązanie

            Assert.AreEqual(life3_npc.max_life, 50, "wOw");
            Assert.AreEqual(life3_npc.current_life, 30, "WoW");

            life3_npc.max_life = 20;
            
            Assert.AreEqual(life2_npc.max_life, 20, "00");
            Assert.AreEqual(life2_npc.current_life, 30, "11");
            
        }

        [Test]
        public void max_life()
        {
            npc Hero2 = new npc(100, 200);
            Assert.AreEqual(Hero2.max_life, 100, "False");
            Assert.AreEqual(Hero2.current_life, 100, "False current");

        }

        [Test]
        public void take_damage()
        {
            npc Hero3 = new npc(100);
            Hero3.Take_Damage(50);
            Assert.AreEqual(Hero3.current_life, 50, "False");
 
        }

        [Test]
        public void is_alive()
        {
            npc Hero4 = new npc(100);
            Hero4.Take_Damage(91);
            Assert.True(Hero4.Is_alive());

            Console.WriteLine(Hero4.current_life);

        }
    }
}
