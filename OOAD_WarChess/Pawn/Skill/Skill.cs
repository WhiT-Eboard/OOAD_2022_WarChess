using OOAD_WarChess.Battle;
using OOAD_WarChess.Localization;
using OOAD_WarChess.Pawn.Modifier;
using OOAD_WarChess.Pawn.Modifier.Common;

namespace OOAD_WarChess.Pawn.Skill
{

    public abstract class Skill : ISkill
    {
        public SkillType Type { get; set; }
        public string Name { get; set; }
        public Pawn Initiator { get; set; }
        public List<Pawn> Target { get; set; }
        public DamageType DamageType { get; set; }
        public int Damage { get; set; } = 0;
        public Func<string> Description { get; set; }
        public Func<string> FullDescription { get; set; }
        public int Range { get; set; } 
        public int Cooldown { get; set; } 
        public int CastTime { get; set; } 
        public int APCost { get; set; }  
        public int MPCost { get; set; } 
        public List<IModifier> Effects { get; set; } = new();
        public List<(int, int)> EffectArea { get; set; } = new();


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


        public virtual Tuple<int, string> Cast(Pawn initiator, Pawn receiver)
        {
            throw new NotImplementedException();
        }
    }
}