namespace OOAD_WarChess.Pawn.Modifier;

public interface IModifier
{
    public Func<int, int> Apply { get; set; } // Apply modifier to the value
    public PawnAttribute Target { get; set; }

    public string Name { get; set; }
    public Func<string> Description { get; set; }

    public Pawn Giver { get; set; }
    public int ID { get; set; } // ID is to identify the one single specific buff/debuff, used when remove
}