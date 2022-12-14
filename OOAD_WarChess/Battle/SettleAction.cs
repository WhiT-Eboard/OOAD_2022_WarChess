using OOAD_WarChess.Pawn.Modifier;
using OOAD_WarChess.Pawn.Modifier.Common;
using OOAD_WarChess.Pawn.Skill;

namespace OOAD_WarChess.Battle;

public class SettleAction
{
    private CombatTracker _combatTracker = CombatTracker.Instance;

    public static SettleAction instance { get; private set; } = new SettleAction();

    public Tuple<int, string> SettleSkill(ISkill skill, Pawn.Pawn initiator, Pawn.Pawn target)
    {
        var damageModifier = 0;
        if (!RuleSet.IsHit(initiator, target)) return Tuple.Create(0, "Miss");
        damageModifier = RuleSet.IsCriticalHit(initiator) ? RuleSet.CriticalDamageMultiplier() : 1;
        var rawDamage = skill.DamageType switch
        {
            DamageType.Physical => RuleSet.DealPhysicalDamage(target,
                RuleSet.DealPhysicalDamage(initiator, skill.Damage)),
            DamageType.Pure => RuleSet.DealTureDamage(target,
                RuleSet.DealTureDamage(initiator, skill.Damage)),
            _ => RuleSet.DefendMagicalDamage(target,
                RuleSet.DealMagicalDamage(initiator, skill.Damage))
        };

        var damage = new Injury(damageModifier * rawDamage, initiator, 0);
        var exhaust = new Exhaust(skill.APCost, initiator, 0);
        var deplete = new Deplete(skill.MPCost, initiator, 0);
        SettleModifier(target, damage);
        foreach (var modifier in skill.Effects)
        {
            SettleModifier(target, modifier.Clone());
        }

        SettleModifier(initiator, exhaust);
        SettleModifier(initiator, deplete);
        var result = Tuple.Create<int, string>(rawDamage, "Fireball");
        _combatTracker.LogSkill(initiator.Name, target.Name, skill.Name, result);
        return result;
    }

    private void SettleModifier(Pawn.Pawn pawn, IModifier modifier)
    {
        if (modifier.IsUnique)
        {
            var temp = pawn.Modifiers.Find(m => m.Name == modifier.Name);
            if (temp != null)
            {
                pawn.Modifiers.Remove(temp);
                _combatTracker.LogModifierLoss(pawn, temp);
            }
        }

        pawn.Modifiers.Add(modifier);
        _combatTracker.LogModifierGain(pawn, modifier);
    }

    public Tuple<int, string> SettlePawn(Pawn.Pawn pawn)
    {
        var result = Tuple.Create<int, string>(0, "");
        for (var i = 0; i < pawn.Modifiers.Count; i++)
        {
            var modifier = pawn.Modifiers[i];
            if (modifier.Type == ModifierType.EachTurn)
            {
                if (modifier.Apply(0) > 0)
                {
                    SettleModifier(pawn, new Injury(modifier.Apply(0), modifier.Giver, 0));
                }
                else
                {
                    SettleModifier(pawn, new Heal(modifier.Apply(0), modifier.Giver, 0));
                }
            }

            if (modifier.Type is ModifierType.Temporary or ModifierType.EachTurn &&
                modifier.Duration <= 1)
            {
                pawn.Modifiers.Remove(modifier);
                _combatTracker.LogModifierLoss(pawn, modifier);
                result = Tuple.Create(modifier.Apply(0), modifier.Name);
                i--;
            }
            else
            {
                modifier.Duration--;
            }
        }

        return result;
    }
}