namespace OOAD_WarChess.Battle;

public class Global
{
    private static Global _global = new();
    public List<Pawn.Pawn> AllPawns { get; set; } = new();
    
    public List<Team> Teams { get; set; } = new();

    public Map.Map Map { get; set; }

    public Global Instance => _global;

    public void Free()
    {
        AllPawns.Clear();
        Map = null;
    }
}