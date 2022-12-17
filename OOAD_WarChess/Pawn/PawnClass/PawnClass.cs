using System;
using System.Collections.Generic;
using OOAD_WarChess.Pawn.Skill;
using OOAD_WarChess.Pawn.Skill.Common;

namespace OOAD_WarChess.Pawn.PawnClass
{
    public class PawnClass : IPawnClass
    {
        public string Name { get; set; }
        public int STR { get; set; }
        public int DEX { get; set; }
        public int INT { get; set; }
        public int CON { get; set; }
        public List<ISkill> SkillSet { get; set; }

        public static PawnClass Temp = new PawnClass();

        private PawnClass()
        {
        }

        public PawnClass(Pawn pawn)
        {
            SkillSet = new List<ISkill>();
            SkillSet.Add(new Move(pawn));
            SkillSet.Add(new MeleeAttack(pawn));
        }

        public static void Create(ref Pawn pawn, PawnClassType type)
        {
            PawnClass pawnClass = type switch
            {
                PawnClassType.Warrior => new Warrior(pawn),
                PawnClassType.Archer => new Archer(pawn),
                PawnClassType.Mage => new Mage(pawn),
                PawnClassType.Priest => new Priest(pawn),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };
            pawn.Init(pawnClass);
        }
    }

    public enum PawnClassType
    {
        Warrior,
        Archer,
        Mage,
        Priest,
    }
}