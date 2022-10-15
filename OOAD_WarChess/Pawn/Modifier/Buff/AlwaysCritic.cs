using OOAD_WarChess.Localization;

namespace OOAD_WarChess.Pawn.Modifier.Buff;

public class AlwaysCritic : Modifier
{
    // Buff example code
    public AlwaysCritic(int value, Pawn giver, int id) : base(giver, id)
    {
        Apply = x => 100;
        Target = PawnAttribute.CRIT;
        Description = () => Lang.Text["AlwaysCritic"];
    }
}