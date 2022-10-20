namespace OOAD_WarChess.Battle;

public static class RuleSet
{
    public static bool IsHit(Pawn.Pawn attacker, Pawn.Pawn defender)
    {
        return Dice.D6(attacker.ACC) > Dice.D6(defender.DOGE);
    }
}