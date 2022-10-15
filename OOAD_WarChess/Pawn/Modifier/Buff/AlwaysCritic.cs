using OOAD_WarChess.Localization;

namespace OOAD_WarChess.Pawn.Modifier.Buff;

public class AlwaysCritic : Modifier,IDuration
{
    // Buff example code
    public AlwaysCritic(int value, Pawn giver, int id) : base(giver, id)
    {
        Duration = value;
        Apply = x => 100;
        Target = PawnAttribute.CRIT;
        Description = () => string.Format(Lang.Text["AlwaysCritic"], Duration);
    }

    public int Duration { get; set; }
}