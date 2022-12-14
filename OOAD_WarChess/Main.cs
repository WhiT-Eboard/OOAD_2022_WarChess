using System;
using OOAD_WarChess;
using OOAD_WarChess.Battle;
using OOAD_WarChess.Item;
using OOAD_WarChess.Item.Potion;
using OOAD_WarChess.Item.Util;
using OOAD_WarChess.Localization;
using OOAD_WarChess.Pawn;
using OOAD_WarChess.Pawn.Modifier.Buff;
using OOAD_WarChess.Pawn.PawnClass;
using OOAD_WarChess.Pawn.Skill.Ability;
using OOAD_WarChess.Pawn.Skill.Common;
using OOAD_WarChess.Pawn.Skill.Magic;

Lang.Text.Language = Language.SimplifiedChinese;
CombatTracker.IsDebug = true;
var demo = new Demo();
var p1 = PawnClass.Create("A", PawnClassType.Knight);
var p2 = PawnClass.Create("B", PawnClassType.Warrior);
var p3 = new Pawn(10, 10, 10, 10, "C");
p3.Skills.Add(new Move(p3));
demo.Mount(p1);
demo.Mount(p2);
demo.Mount(p3);
var healPotion = new HealPotion(50);
Console.WriteLine(p1);
var log = "";
p1.Items.Add(new Knife(5));
p1.Items.Add(new Beer(10));
demo.ListPawnDetail();
p1.GainExp(10000, out _);
p2.GainExp(10000, out _);
demo.ActOneTurn(
    (() =>
    {
        p1.GainMoney(100,out _);
        p1.Items[0].Cast(p1, p2, out _);
    })
);
demo.ActOneTurn(
    (() => { p1.Items[0].Cast(p1, p2); })
);