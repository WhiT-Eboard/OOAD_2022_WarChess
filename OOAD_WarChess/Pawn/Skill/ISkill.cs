namespace OOAD_WarChess.Pawn.Skill;

public interface ISkill
{
    public SkillTarget Target { get; set; }
    public SkillType Type { get; set; }

    public Pawn Initiator { get; set; }
    public Predicate<Pawn> Condition { get; set; }
    public Func<string> Description { get; set; }
    public Func<string> FullDescription { get; set; }
    public int Range { get; set; }
    public int Cooldown { get; set; }
    public int CastTime { get; set; }
    public List<SkillEffect> Effects { get; set; }

    public void Use();
}

public enum SkillTarget
{
    Self,
    SingleEnemy,
    MultipleEnemy,
    AllEnemy,
    SingleAlly,
    MultipleAlly,
    AllAlly,
    AllTarget,
    NoTarget
}

public enum SkillType
{
    Attack,
    MeleeAttack,
    RangeAttack,
    Magic,
    CombatSkill,
    Heal
}

public enum SkillEffect
{
    DealDamage,
    Heal,
    ApplyEffect,
}