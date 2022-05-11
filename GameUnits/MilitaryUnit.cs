using System;
namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower{get;}
        public int XP{get; set;}

        public  MilitaryUnit(int movement, int health, int attackPower) : base(movement, health)
        {
            AttackPower = attackPower;
            XP = 0;
        }

        public void Attack()
        {
            Console.WriteLine($"I'm attacking with {AttackPower} attack power!");
        }
    }
}