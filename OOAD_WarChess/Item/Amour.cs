namespace OOAD_WarChess.Item;

public class Amour: IItem
{
    public int Weight { get; set; }
    public int Value { get; set; }
    
    public int Shield { get; set; }
    public int PhysicalDefence { get; set; }
    public int MagicalDefence { get; set; }
}