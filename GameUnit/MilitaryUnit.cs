namespace GameUnit
{
    public class MilitaryUnit : Unit // Heranca!!
    {
        public int AttackPower { get; }
        public int XP { get; private set; }

        public MilitaryUnit(int mov, int health, int attackPower) : base(mov, health)
        {                                                        // Unit(int, int)
            AttackPower = attackPower;
            XP = 0;
        }

        public override int Health { get => base.Health; set => base.Health += XP; }

        public override float cost { get => AttackPower + XP; }

        public void Attack(Unit u)
        {
            XP += 10;
            u.Health -= AttackPower;
        }




    }
}
