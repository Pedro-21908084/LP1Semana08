using System;
namespace GameUnits
{
    public class Unit
    {
        private int movement;
        public int Health {get; set;}

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move(Vector2 v)
        {
            Console.WriteLine($"Moved {v.x}tiles horizontally and {v.y} tiles vertically");
        }
    }
}