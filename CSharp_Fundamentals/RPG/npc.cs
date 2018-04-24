using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Fundamentals.RPG
{
    public class npc
    {
        public int max_life;
        public int current_life;
        
        public npc(int v)
        {
            this.max_life = v;
            this.current_life = v;
        }
        public npc(int max, int current)
        {
            this.max_life = max;
            this.current_life = current;
        }
        public int Attack()
        {
            return 10;
        }
    }
}
