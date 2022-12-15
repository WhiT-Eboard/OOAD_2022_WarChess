namespace OOAD_WarChess.Battle
{

    public static class RuleSet
    {
        public static bool IsHit(Pawn.Pawn attacker, Pawn.Pawn defender)
        {
            return Dice.D6(attacker.ACC) > Dice.D6(defender.DOGE);
        }

        public static bool IsCriticalHit(Pawn.Pawn attacker)
        {
            return Dice.D100(1) <= attacker.CRIT;
        }

        public static int CriticalDamageMultiplier()
        {
            return 2;
        }

        public static int DealPhysicalDamage(Pawn.Pawn pawn, int damage)
        {
            return damage / 10 * pawn.PHY_ATK;
        }

        public static int DealTureDamage(Pawn.Pawn pawn, int damage)
        {
            return damage;
        }

        public static int DealMagicalDamage(Pawn.Pawn pawn, int damage)
        {
            return damage / 10 * pawn.MAG_ATK;
        }

        public static int DefendPhysicalDamage(Pawn.Pawn pawn, int damage)
        {
            return damage - pawn.PHY_DEF;
        }

        public static int DefendTrueDamage(Pawn.Pawn pawn, int damage)
        {
            return damage;
        }

        public static int DefendMagicalDamage(Pawn.Pawn pawn, int damage)
        {
            return damage - pawn.MAG_DEF;
        }
    }
}