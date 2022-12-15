namespace OOAD_WarChess
{

    public class Demo
    {
        private List<Pawn.Pawn> _pawns = new();

        public void Mount(Pawn.Pawn pawn)
        {
            _pawns.Add(pawn);
        }

        public void Unmount(Pawn.Pawn pawn)
        {
            _pawns.Remove(pawn);
        }

        public void ActOneTurn(Action action)
        {
            StartTurn(action);
            ListPawnDetail();
            EndTurn();
            ListPawnDetail();
        }

        public void StartTurn(Action action)
        {
            Console.WriteLine("--------------------Start Turn Phase---------------------");
            action.Invoke();
            Console.WriteLine("---------------------------------------------------------");

        }

        public void EndTurn()
        {
            Console.WriteLine("--------------------End Turn Phase---------------------");
            _pawns.ForEach(p => p.UpdateModifiers());
            Console.WriteLine("-------------------------------------------------------");

        }


        public void ListPawn()
        {
            foreach (var pawn in _pawns)
            {
                Console.WriteLine(pawn.Name);
            }
        }

        public void ListPawnDetail()
        {
            Console.WriteLine("******************Pawn Detail******************");
            _pawns.ForEach(p => { Console.WriteLine($"*|{p.Name}| HP:{p.HP} MP:{p.MP} ACTPOINT:{p.ACTPOINT}"); });
            Console.WriteLine("***********************************************");
        }
    }
}