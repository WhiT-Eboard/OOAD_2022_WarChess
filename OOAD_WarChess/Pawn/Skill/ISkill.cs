using OOAD_WarChess.Battle;
using OOAD_WarChess.Pawn.Modifier;

namespace OOAD_WarChess.Pawn.Skill;

public interface ISkill : ICast
{
    public SkillType Type { get; set; }
    public string Name { get; set; }
    public Pawn Initiator { get; set; }
    public List<Pawn> Target { get; set; }
    public DamageType DamageType { get; set; }
    public int Damage { get; set; }
    public Func<string> Description { get; set; }
    public Func<string> FullDescription { get; set; }
    public int Range { get; set; }
    public int Cooldown { get; set; }
    public int CastTime { get; set; }
    public int APCost { get; set; }
    public List<IModifier> Effects { get; set; }
    public List<(int, int)> EffectArea { get; set; }
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