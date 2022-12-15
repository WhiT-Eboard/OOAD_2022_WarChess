namespace OOAD_WarChess.Item
{

    public class Weapon : IItem

    {
        public int Weight { get; set; }
        public int Value { get; set; }


        public Tuple<int, string> Cast(Pawn.Pawn pawn)
        {
            throw new NotImplementedException();
        }

        public Tuple<int, string> Cast(Pawn.Pawn initiator, Pawn.Pawn receiver)
        {
            throw new NotImplementedException();
        }
    }
}