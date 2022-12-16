using System;
using OOAD_WarChess;
using OOAD_WarChess.Battle;
using OOAD_WarChess.Item;
using OOAD_WarChess.Item.Potion;
using OOAD_WarChess.Localization;
using OOAD_WarChess.Pawn;
using OOAD_WarChess.Pawn.Modifier.Buff;
using OOAD_WarChess.Pawn.Skill.Common;
using OOAD_WarChess.Pawn.Skill.Magic;

Lang.Text.Language = Language.SimplifiedChinese;
CombatTracker.IsDebug = true;
var demo = new Demo();
var p1 = new Pawn(10, 10, 10, 10, "A");
var p2 = new Pawn(10, 10, 10, 10, "B");
demo.Mount(p1);
demo.Mount(p2);
var healPotion = new HealPotion(50);
p1.Skills.Add(new Move(p1));
p1.Skills.Add(new Fireball(p1));
p1.Items.Add(healPotion);
p1.Modifiers.Add(new AlwaysCritic(10, p1, 0));
demo.ListPawnDetail();
demo.ActOneTurn(
    (() => { p1.Skills[1].Cast(p1, p1); })
);
demo.ActOneTurn(
    (() => { p1.Items[0].Cast(p1, p1); })
);