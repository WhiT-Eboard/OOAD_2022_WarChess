using System.Collections.Generic;
using OOAD_WarChess.Pawn.Skill;
using OOAD_WarChess.Pawn.Skill.Common;

namespace OOAD_WarChess.Pawn.PawnClass
{
    public class Warrior : PawnClass
    {

        public Warrior(Pawn pawn): base(pawn)
        {
            Name = "Warrior";
            STR = 10;
            DEX = 5;
            INT = 2;
            CON = 10;
            
        }
    }
}