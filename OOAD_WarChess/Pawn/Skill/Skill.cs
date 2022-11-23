using OOAD_WarChess.Battle;
using OOAD_WarChess.Localization;
using OOAD_WarChess.Pawn.Modifier;
using OOAD_WarChess.Pawn.Modifier.Common;

namespace OOAD_WarChess.Pawn.Skill;

public abstract class Skill : ISkill
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
    

    public Skill(Pawn initiator)
    {
        Initiator = initiator;
        //FullDescription = () =>
        //  string.Format(Lang.Text["Skill_Full_Description"], Description(),, Range, CastTime, Cooldown);
    }

    public string GetEffectDescription()
    {
        throw new NotImplementedException();
    }

    public virtual void Cast()
    {
        
    }
}

public class SkillEffectImpl
{
    public Func<int, Pawn, int, IModifier> DealDamage = (val, giver, id) => new Injury(val, giver, id);


    public static string GetEffectDescription(SkillEffectType effectType)
    {
        return effectType switch
        {
            SkillEffectType.DealDamage => Lang.Text["Skill_Effect_DealDamage"],
            SkillEffectType.Heal => Lang.Text["Skill_Effect_Heal"],
            SkillEffectType.ApplyEffect => Lang.Text["Skill_Effect_ApplyEffect"],
            _ => throw new ArgumentOutOfRangeException(nameof(effectType), effectType, null)
        };
    }
}