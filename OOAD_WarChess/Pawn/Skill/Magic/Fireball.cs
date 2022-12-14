using OOAD_WarChess.Battle;
using OOAD_WarChess.Pawn.Modifier;
using OOAD_WarChess.Pawn.Modifier.Common;
using OOAD_WarChess.Pawn.Modifier.Debuff;

namespace OOAD_WarChess.Pawn.Skill.Magic;

public class Fireball : Skill
{
    public Fireball(Pawn initiator) : base(initiator)
    {
        Range = 3;
        Cooldown = 2;
        CastTime = 0;
        APCost = 3;
        Damage = 10;
        EffectArea = new List<(int, int)> {(0, 0), (1, 0), (-1, 0), (0, 1), (0, -1)};
        Name = "Fireball";
        Effects = new List<IModifier>{new Burn(3,initiator,1)};
    }

    public override Tuple<int, string> Cast(Pawn initiator, Pawn receiver)
    {
        return SettleAction.instance.SettleSkill(this, initiator, receiver);
    }
}