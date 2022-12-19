using System;
using System.Collections.Generic;
using OOAD_WarChess.Battle;

namespace OOAD_WarChess.Pawn.Skill.WeaponSkill
{

    public class PrimalRend:Skill
    {
        
            public PrimalRend(Pawn initiator) : base(initiator)
            {
                Range = 0;
                Cooldown = 1;
                CastTime = 0;
                APCost = 4;
                MPCost = 0;
                DamageType = DamageType.Physical;
                Damage = 20;
                EffectArea = new List<(int, int)> {(0, 0), (0, 1), (0, -1), (1, 0), (-1, 0)};
                Name = "Primal Rend";
            }

            public override Tuple<int, string> Cast(Pawn initiator, Pawn receiver, out string log)
            {
                var result = SettleAction.Instance.SettleSkill(this, initiator, receiver);
                log = CombatTracker.Instance.GetNewLog();
                return result;
            }
        }
    
}