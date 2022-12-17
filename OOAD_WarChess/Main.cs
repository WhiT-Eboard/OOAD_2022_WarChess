using System;
using OOAD_WarChess;
using OOAD_WarChess.Battle;
using OOAD_WarChess.Item;
using OOAD_WarChess.Item.Potion;
using OOAD_WarChess.Localization;
using OOAD_WarChess.Pawn;
using OOAD_WarChess.Pawn.Modifier.Buff;
using OOAD_WarChess.Pawn.PawnClass;
using OOAD_WarChess.Pawn.Skill.Common;
using OOAD_WarChess.Pawn.Skill.Magic;

Lang.Text.Language = Language.SimplifiedChinese;
CombatTracker.IsDebug = true;
var demo = new Demo();
var p1 = new Pawn("A");
var p2 = new Pawn("B");
PawnClass.Create(ref p1,PawnClassType.Mage);
PawnClass.Create(ref p2,PawnClassType.Warrior);
demo.Mount(p1);
demo.Mount(p2);
var healPotion = new HealPotion(50);
p1.Items.Add(healPotion);
demo.ListPawnDetail();
demo.ActOneTurn(
    (() => { p1.Skills[1].Cast(p1, p2); })
);
demo.ActOneTurn(
    (() => { p1.Items[0].Cast(p1, p2); })
);
