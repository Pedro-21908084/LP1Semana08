using System;
namespace GameUnits
{
    public class SettlerUnit
    {
        public SettlerUnit(int mov, int health):base(mov, health){}

        public void Settle(Vector2 v)
        {
            Console.WriteLine($"I have settle the tile x:{v.x} y:{v.y}");
        }
    }
}