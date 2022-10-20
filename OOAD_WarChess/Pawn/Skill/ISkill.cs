using OOAD_WarChess.Battle;

namespace OOAD_WarChess.Pawn.Skill;

public interface ISkill
{
    public SkillTarget TargetType { get; set; }
    public SkillType Type { get; set; }
    public Pawn Initiator { get; set; }
    public List<Pawn> Target { get; set; }
    public DamageType DamageType { get; set; }
    public Predicate<Global> Available { get; set; }
    public Func<string> Description { get; set; }
    public Func<string> FullDescription { get; set; }
    public int Range { get; set; }
    public int Cooldown { get; set; }
    public int CastTime { get; set; }
    public List<SkillEffectType> Effects { get; set; }

    public void Cast();
}

public enum SkillTarget
{
    Self,
    SingleEnemy,
    MultipleEnemies,
    AllEnemies,
    SingleAlly,
    MultipleAllAllies,
    AllAllies,
    AllTargets,
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

public enum SkillEffectType
{
    DealDamage,
    Heal,
    ApplyEffect,
}

public enum DamageType
{
    Fire,
    Ice,
    Thunder,
    Water,
    Arcane,
    Pure
}