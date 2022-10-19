using OOAD_WarChess.Battle.Terran;

namespace OOAD_WarChess.Battle.Map;

public class Map
{
    public int Size { get; set; }

    public List<Tile> BattleMap { get; set; }

    public Environment.Environment Environment { get; set; }

    public Map(int size)
    {
        Size = size;
        BattleMap = new List<Tile>();
        for (var i = 0; i < size; i++)
        {
            for (var j = 0; j < size; j++)
            {
                BattleMap.Add(new Tile(TerranType.Plain));
            }
        }
    }
}