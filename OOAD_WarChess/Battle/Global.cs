namespace OOAD_WarChess.Battle;

public class Global
{
    private static Global _global = new();
    public List<Pawn.Pawn> Pawns { get; set; } = new();
    
    public Map.Map Map { get; set; }

    public Global Instance => _global;

    public void Free()
    {
        Pawns.Clear();
        Map = null;
    }
}