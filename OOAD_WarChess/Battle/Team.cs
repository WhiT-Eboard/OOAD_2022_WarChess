namespace OOAD_WarChess.Battle
{

    public class Team
    {
        private List<Pawn.Pawn> Pawns { get; set; }

        public TeamColor Color { get; set; }

        public Team()
        {
            Pawns = new List<Pawn.Pawn>();
        }
    }

    public enum TeamColor
    {
        Red = 0,
        Blue = 1,
        Count = 2
    }
}