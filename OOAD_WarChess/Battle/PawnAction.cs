using OOAD_WarChess.Pawn.Skill;

namespace OOAD_WarChess.Battle;

public struct PawnAction
{
    public PawnAction(Pawn.Pawn initiator, List<(int, int)> path, List<Skill> casts)
    {
        Initiator = initiator;
        Speed = initiator.ACTPOINT;
        Path = path;
        CastSkills = casts;
    }

    public Pawn.Pawn Initiator { get; private set; }

    public int Speed { get; private set; }

    public List<(int, int)> Path { get; private set; } = new();

    public List<Skill> CastSkills { get; private set; } = new();
}