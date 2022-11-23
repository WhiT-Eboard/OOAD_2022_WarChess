namespace OOAD_WarChess.Battle;

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
    
    public static double CriticalDamageMultiplier(Pawn.Pawn attacker)
    {
        return 1.5;
    }
}