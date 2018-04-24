using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.RPG
{
    public class Heroes : npc
    {
        private List<Weapon> weapons_list;

        public Heroes(int v) : base(v)
        {
            weapons_list = new List<Weapon>();
            Weapon sword = new Weapon(8, "sword");
            Weapon axe = new Weapon(12, "axe");
            Weapon fireball = new Weapon(20, "fireball");
            weapons_list.Add(sword);
            weapons_list.Add(axe);
            weapons_list.Add(fireball);
        }

        public Heroes(int max, int current) : base(max, current)
        {
            weapons_list = new List<Weapon>();
            Weapon sword = new Weapon(8, "sword");
            Weapon axe = new Weapon(12, "axe");
            Weapon fireball = new Weapon(20, "fireball");
            weapons_list.Add(sword);
            weapons_list.Add(axe);
            weapons_list.Add(fireball);
        }

        public List<string> GetWeaponNames()
        {
            var WeaponNames = new List<string>();

            foreach (var WeaponFromTheList in weapons_list)
            {
                WeaponNames.Add(WeaponFromTheList.Name);
            }
            return WeaponNames;
        }

        //public GetDamageLevel()
        //{
        //        var DamageLevel = new ();

        //        foreach (var WeaponFromTheList in weapons_list)
        //        {
        //            DamageLevel.Add(WeaponFromTheList.Damage);
        //        }
        //        return DamageLevel;
        //}
    }



    public class Weapon
    {
        public int Damage;
        public string Name;

        public Weapon(int dmg, string name)
        {
            this.Damage = dmg;
            this.Name = name;
        }

    }
}
