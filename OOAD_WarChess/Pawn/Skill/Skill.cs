using OOAD_WarChess.Localization;
using OOAD_WarChess.Pawn.Modifier;
using OOAD_WarChess.Pawn.Modifier.Common;

namespace OOAD_WarChess.Pawn.Skill;

public class Skill : ISkill
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

    public Skill(Pawn initiator)
    {
        Initiator = initiator;
        FullDescription = () =>
            string.Format(Lang.Text["Skill_Full_Description"], Description(), Range, CastTime, Cooldown);
    }

    public virtual void Use()
    {
    }
}

public class SkillEffectImpl
{
    public Func<int, Pawn, int, IModifier> DealDamage = (val, giver, id) => new Injury(val, giver, id);
}