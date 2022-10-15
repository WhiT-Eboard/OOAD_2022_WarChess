namespace OOAD_WarChess.Pawn.Skill;

public interface ISkill
{
    public SkillTarget Target { get; set; }
    public SkillType Type { get; set; }
    
    public Predicate<Pawn> Condition { get; set; }
    public int Range { get; set; }
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