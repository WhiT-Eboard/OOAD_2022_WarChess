using OOAD_WarChess.Pawn.Skill;

namespace OOAD_WarChess.Battle;

public class GameController
{
    public Global Global { get; set; } = new();

    public List<PawnAction> Actions { get; set; } = new();

    public bool SettleAction()
    {
        if (Actions.Count > 0)
        {
            var action = Actions[0];
            foreach (var step in action.Path)
            {
            }

            foreach (var skill in action.CastSkills
                         .Where(skill => skill.Available(Global))
                         .Where(skill => skill.TargetType != SkillTarget.NoTarget))
            {
                for (var i = 0; i < skill.Target.Count; i++)
                {
                    SettleSkill(skill, i);
                }
            }

            action.Initiator.UpdateModifiers();
            Actions.RemoveAt(0);
            Actions.Sort((a1, a2) => a1.Speed > a2.Speed ? 1 : -1);
        }
        else
        {
            return false;
        }

        return true;
    }

    public bool SettleSkill(ISkill skill, int targetNumber)
    {
        var target = skill.Target[targetNumber];
        var initiator = skill.Initiator;
        if (!RuleSet.IsHit(initiator, target)) return false;
        skill.Cast();
        return true;
    }
}