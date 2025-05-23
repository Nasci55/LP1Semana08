using System;
using System.Reflection.PortableExecutable;
using Humanizer;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        private void Move(int movement)
        {
            System.Console.WriteLine(movement.ToRoman());
        }
        public virtual float cost { get; }

        private string unitType;

        public virtual string ToString()
        {

        }

    }
}
