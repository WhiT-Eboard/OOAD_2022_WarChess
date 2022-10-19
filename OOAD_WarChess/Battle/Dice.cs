namespace OOAD_WarChess.Battle;

public static class Dice
{
    private static Random _random = new(new Guid().GetHashCode());

    public static Func<int> D6 = () => Roll(6);
    
    public static Func<int> D20 = () => Roll(20);

    public static Func<int> D100 = () => Roll(100);


    public static int Roll(int sides)
    {
        return _random.Next(1, sides + 1);
    }

    public static int Roll(int sides, int count)
    {
        var total = 0;
        for (var i = 0; i < count; i++)
        {
            total += Roll(sides);
        }
        return total;
    }
    
    
}

public enum DiceType
{
    Six = 6,
    Twenty = 20,
    Hundred = 100
}