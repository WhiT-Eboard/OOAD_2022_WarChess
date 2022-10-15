namespace OOAD_WarChess.Pawn.Modifier;

public class Modifier : IModifier
{
    public Func<int, int> Apply { get; set; }
    public PawnAttribute Target { get; set; }
    
    public string Name { get; set; }
    public Func<string> Description { get; set; }
    
    public Pawn Giver { get; set; }
    public int ID { get; set; }

    protected Modifier(Pawn giver,int id)
    {
        Giver = giver;
        ID = id;
    }
}