using System;
namespace GameUnits
{
    public abstract class Unit
    {
        private int movement;
        public virtual int Health {get; set;}
        public abstract int Value{get;}

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(Vector2 v)
        {
            Console.WriteLine($"Moved {v.x * movement} tiles horizontally and " +
            $" {v.y * movement} tiles vertically");
        }
    }
}