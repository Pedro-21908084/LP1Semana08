using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            Unit[] units = new Unit[2];
            units[0] = new MilitaryUnit(2, 5, 3, 1);
            units[1] = new SettlerUnit(2, 4);
            Vector2 movement = new Vector2() {x=1, y=2};
            
            units[0].Move(movement);
            movement.x++;
            units[1].Move(movement);

            Console.WriteLine($"The military unit has {units[0].Health}" + 
            $" health and a value of {units[0].Value}.");
            Console.WriteLine(units[0].ToString());

            Console.WriteLine($"The settler unit has {units[1].Health}" + 
            $" health and a value of {units[1].Value}.");
            Console.WriteLine(units[1].ToString());
        }
    }

    public struct Vector2
    {
        public int x;
        public int y;
    }
}
