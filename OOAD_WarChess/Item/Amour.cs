using OOAD_WarChess.Pawn.Modifier;

namespace OOAD_WarChess.Item;

public struct Amour: IItem
{
    public Amour(int weight, int value, int shield, int physicalDefence, int magicalDefence, IModifier specialEffect)
    {
        Weight = weight;
        Value = value;
        Shield = shield;
        PhysicalDefence = physicalDefence;
        MagicalDefence = magicalDefence;
        SpecialEffect = specialEffect;
    }

    public int Weight { get; set; }
    public int Value { get; set; }
    public int Shield { get; set; }
    public int PhysicalDefence { get; set; }
    public int MagicalDefence { get; set; }
    public IModifier SpecialEffect { get; set; }
    public Tuple<int, string> Cast(Pawn.Pawn pawn)
    {
        throw new NotImplementedException();
    }

    public Tuple<int, string> Cast(Pawn.Pawn initiator, Pawn.Pawn receiver)
    {
        throw new NotImplementedException();
    }
}