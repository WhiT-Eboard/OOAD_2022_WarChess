using OOAD_WarChess.Battle.Terran;

namespace OOAD_WarChess.Battle.Map;

public class Tile
{
    public TerranType Terran { get; set; }
    
    public Pawn.Pawn Pawn { get; set; }
    
    public Tile(TerranType terran)
    {
        Terran = terran;
    }
}