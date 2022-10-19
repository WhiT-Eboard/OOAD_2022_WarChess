using OOAD_WarChess.Pawn.Modifier;

namespace OOAD_WarChess.Battle.Terran;

public class Terran
{
    public TerranType Type { get; set; }

    private Pawn.Pawn _pawn { get; set; } = new(0, 0, 0, 0);

    public Terran(TerranType type)
    {
        Type = type;
    }

    public IModifier GetModifier()
    {
        return Type switch
        {
            TerranType.Plain => new Plain(_pawn, 0),
            TerranType.Forest => new Forest(_pawn, 0),
            TerranType.Mountain => new Mountain(_pawn, 0),
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}

public enum TerranType
{
    Plain,
    Forest,
    Mountain
}