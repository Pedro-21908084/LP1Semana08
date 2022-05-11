using System;
namespace GameUnits
{
    public class MilitaryUnit : Unit
    {
        public int AttackPower{get;}
        public int XP{get; set;}
        public override int Health { get => base.Health+XP; set => base.Health = value; }
        public override int Value => AttackPower +XP;

        public  MilitaryUnit(int movement, int health, int attackPower, int xp) : base(movement, health)
        {
            AttackPower = attackPower;
            XP = xp;
        }

        public void Attack()
        {
            Console.WriteLine($"I'm attacking with {AttackPower} attack power!");
        }
    }
}