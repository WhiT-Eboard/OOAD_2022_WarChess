using OOAD_WarChess.Item;
using OOAD_WarChess.Pawn.Modifier;

namespace OOAD_WarChess.Pawn;

public struct Pawn
{
    private int _STR { get; set; } = 0; // Strength
    private int _DEX { get; set; } = 0; // Dexterity
    private int _INT { get; set; } = 0; // Intelligence
    private int _CON { get; set; } = 0; // Constitution

    // All the properties bellow are calculated from the above properties

    private int _MAX_HP => CON * 10 + STR * 5; // Health Points

    private int _MAX_MP => 10 + INT * 10; // Mana Points

    private int _SPD => DEX * 20 - BURDEN; // Speed

    private int _PHY_DEF => CON * 2 * (STR % 2); // Physical Defense

    private int _MAG_DEF => CON * 2 * (INT % 2); // Magical Defense

    private int _PHY_ATK => STR * 10; // Physical Attack

    private int _MAG_ATK => INT * 10; // Magical Attack

    private int _ACC => 90; // Accuracy

    private int _DOGE => DEX * 2; // Dodge

    private int _CRIT => DEX * 2; // Critical Hit

    private int _SHIELD => _STR * 2 + _INT * 2; // Shield

    private int _MAXBURDEN => 50 + STR * 10;

    private int BURDEN => Items.Select(x => x.Weight).Sum();


    public List<IModifier> Modifiers { get; set; }

    public List<IItem> Items { get; set; }

    public int EXP { get; set; } = 0;
    
    public int LVL => EXP / 1000; //TODO Change the formula
    
    public Pawn(int str, int dex, int intel, int con)
    {
        _STR = str;
        _DEX = dex;
        _INT = intel;
        _CON = con;
        Modifiers = new List<IModifier>();
        Items = new List<IItem>();
    }
    

        public int GetAttribute(PawnAttribute attribute)
    {
        return attribute switch
        {
            PawnAttribute.STR => _STR,
            PawnAttribute.DEX => _DEX,
            PawnAttribute.INT => _INT,
            PawnAttribute.CON => _CON,
            PawnAttribute.HP => _MAX_HP,
            PawnAttribute.MP => _MAX_MP,
            PawnAttribute.SPD => _SPD,
            PawnAttribute.PHY_DEF => _PHY_DEF,
            PawnAttribute.MAG_DEF => _MAG_DEF,
            PawnAttribute.PHY_ATK => _PHY_ATK,
            PawnAttribute.MAG_ATK => _MAG_ATK,
            PawnAttribute.ACC => _ACC,
            PawnAttribute.DOGE => _DOGE,
            PawnAttribute.CRIT => _CRIT,
            PawnAttribute.SHIELD => _SHIELD,
            PawnAttribute.MAX_BURDEN => _MAXBURDEN,
            PawnAttribute.BURDEN => BURDEN,
            _ => throw new ArgumentOutOfRangeException(nameof(attribute), attribute, null)
        };
    }

    public int GetModifiedAttribute(PawnAttribute attribute)
    {
        var value = GetAttribute(attribute);
        return Modifiers.Where(x => x.Target == attribute)
            .Aggregate(value, (current, modifier) => modifier.Apply(current));
    }
    
    public int STR => GetModifiedAttribute(PawnAttribute.STR);
    public int DEX => GetModifiedAttribute(PawnAttribute.DEX);
    public int INT => GetModifiedAttribute(PawnAttribute.INT);
    public int CON => GetModifiedAttribute(PawnAttribute.CON);
    public int HP => GetModifiedAttribute(PawnAttribute.HP);
    public int MP => GetModifiedAttribute(PawnAttribute.MP);
    public int SPD => GetModifiedAttribute(PawnAttribute.SPD);
    public int PHY_DEF => GetModifiedAttribute(PawnAttribute.PHY_DEF);
    public int MAG_DEF => GetModifiedAttribute(PawnAttribute.MAG_DEF);
    public int PHY_ATK => GetModifiedAttribute(PawnAttribute.PHY_ATK);
    public int MAG_ATK => GetModifiedAttribute(PawnAttribute.MAG_ATK);
    public int ACC => GetModifiedAttribute(PawnAttribute.ACC);
    public int DOGE => GetModifiedAttribute(PawnAttribute.DOGE);
    public int CRIT => GetModifiedAttribute(PawnAttribute.CRIT);
    public int SHIELD => GetModifiedAttribute(PawnAttribute.SHIELD);
    public int MAX_BURDEN => GetModifiedAttribute(PawnAttribute.MAX_BURDEN);
    
}

public enum PawnAttribute
{
    STR,
    DEX,
    INT,
    CON,
    HP,
    MP,
    SPD,
    PHY_DEF,
    MAG_DEF,
    PHY_ATK,
    MAG_ATK,
    ACC,
    DOGE,
    CRIT,
    SHIELD,
    BURDEN,
    MAX_BURDEN
}