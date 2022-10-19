namespace OOAD_WarChess.Pawn.Skill.Magic;

public class Fireball: Skill
{
    public Fireball(Pawn initiator) : base(initiator)
    {
        Target = SkillTarget.SingleEnemy;
        Range = 3;
        Cooldown = 2;
        CastTime = 0;
    }
}