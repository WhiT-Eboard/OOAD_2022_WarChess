using OOAD_WarChess.Battle;

namespace OOAD_WarChess.Pawn.Skill.Common;

public class MeleeAttack : Skill
{
    public MeleeAttack(Pawn initiator) : base(initiator)
    {
        APCost = 2;
        Range = 1;
        Name = "Attack";
        Damage = 10;
        MPCost = 0;
        EffectArea = new List<(int, int)> {(0, 0)};
        DamageType = DamageType.Physical;
    }

    public override Tuple<int, string> Cast(Pawn initiator, Pawn receiver)
    {
        return SettleAction.instance.SettleSkill(this, initiator, receiver);
    }
}