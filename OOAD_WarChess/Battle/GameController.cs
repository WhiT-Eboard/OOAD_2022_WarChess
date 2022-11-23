using OOAD_WarChess.Battle.Map;

namespace OOAD_WarChess.Battle;

public class GameController
{
    public Global Global { get; set; } = new();

    public bool Move(Pawn.Pawn initiator,(int,int) src, (int,int) dst)
    {
        //TODO Settle MoveDifficulty and Modifier
       
        if (Global.Map.At(src.Item1, src.Item2).Unit == Tile.DefaultPawn) return false;
        Global.Map.At(src.Item1,src.Item2).Unit = initiator;
        Global.Map.At(dst.Item1,dst.Item2).Unit = Tile.DefaultPawn;
        return true;
    }
}