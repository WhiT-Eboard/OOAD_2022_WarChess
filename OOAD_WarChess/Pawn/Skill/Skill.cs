namespace OOAD_WarChess.Pawn.Skill;

public class Skill: ISkill
{
    public SkillTarget Target { get; set; }
    public SkillType Type { get; set; }
    public Predicate<Pawn> Condition { get; set; }
    public int Range { get; set; }
    public void Use()
    {
        throw new NotImplementedException();
    }
}