namespace OOAD_WarChess.Battle;

public class Team
{
    private List<Pawn.Pawn> Pawns { get; set; }
    
    public Team()
    {
        Pawns = new List<Pawn.Pawn>();
    }
}