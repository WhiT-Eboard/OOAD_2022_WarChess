namespace OOAD_WarChess.Pawn
{

    public interface ICast
    {
        public Tuple<int, string> Cast(Pawn initiator, Pawn receiver);
    }
}