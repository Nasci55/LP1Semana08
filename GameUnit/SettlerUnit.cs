using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnit
{
    public class SettlerUnit : Unit
    {
        public SettlerUnit(int movement, int health) : base(movement, health)
        {
            movement = 1;
            health = 3;
        }

        public override float cost => 5;
    }
}