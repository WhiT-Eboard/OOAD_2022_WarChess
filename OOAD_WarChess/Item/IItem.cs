using OOAD_WarChess.Pawn;

namespace OOAD_WarChess.Item;

public interface IItem : ICast
{
    public int Weight { get; set; }
    public int Value { get; set; }
}