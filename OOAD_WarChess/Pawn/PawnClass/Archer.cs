namespace OOAD_WarChess.Pawn.PawnClass
{
    public class Archer : PawnClass
    {
        public Archer(Pawn pawn) : base(pawn)
        {
            Name = "Archer";
            STR = 3;
            DEX = 8;
            INT = 1;
            CON = 5;
            
        }
    }
}