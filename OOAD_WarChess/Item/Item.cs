using System;
using OOAD_WarChess.Battle;
using OOAD_WarChess.Pawn.Skill;
using OOAD_WarChess.Pawn.Skill.Common;

namespace OOAD_WarChess.Item;

public class Item : IItem
{
    public virtual Tuple<int, string> Cast(Pawn.Pawn initiator, Pawn.Pawn receiver)
    {
        ItemEffect.Name = Name;
        return SettleAction.Instance.SettleSkill(ItemEffect, initiator, receiver);
    }

    public Tuple<int, string> Cast(Pawn.Pawn initiator, int value)
    {
        throw new NotImplementedException();
    }

    public int Weight { get; set; }
    public int Value { get; set; }
    public string Name { get; set; }
    public bool IsUsed { get; set; }
    public ISkill ItemEffect { get; set; }

    public Item(int value)
    {
        Weight = 0;
        Value = value;
        IsUsed = false;
        ItemEffect = new UseItem();
        Name = "Item";
    }
}