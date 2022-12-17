namespace OOAD_WarChess.Pawn.PawnClass
{
    public class Priest : PawnClass
    {
        public Priest(Pawn pawn) : base(pawn)
        {
            Name = "Priest";
            STR = 2;
            DEX = 4;
            INT = 5;
            CON = 5;
        }
    }
}