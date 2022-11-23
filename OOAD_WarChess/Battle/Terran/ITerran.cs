using OOAD_WarChess.Pawn.Modifier;

namespace OOAD_WarChess.Battle.Terran;

public interface ITerran
{
    public TerranType Type { get; set; }

    public int MoveDifficulty
    {
        get
        {
            return Type switch
            {
                TerranType.Plain => 1,
                TerranType.Forest => 2,
                TerranType.Mountain => 3,
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }

    public Pawn.Pawn _pawn { get; set; }

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