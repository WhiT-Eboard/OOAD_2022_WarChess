using OOAD_WarChess.Pawn.Modifier;

namespace OOAD_WarChess.Battle
{

    public class CombatTracker
    {
        public static CombatTracker Instance { get; set; } = new CombatTracker();

        private static List<Tuple<string, string, string, int, string, LogType>> _combatLogList = new();

        public static bool IsDebug = false;

        private CombatTracker()
        {
        }

        public static string CombatLogToString(Tuple<string, string, string, int, string, LogType> log)
        {
            return log.Item6 switch
            {
                LogType.Skill => $"{log.Item1} used {log.Item3} on {log.Item2}. Deal {log.Item4} damage.",
                LogType.ModifierLoss => $"{log.Item1} lost effect {log.Item2}",
                LogType.ModifierGain => $"{log.Item1} gain effect {log.Item2} from {log.Item3} for {log.Item4} turns",
                _ => throw new ArgumentOutOfRangeException()
            };
        }

        public void PrintCombatLog()
        {
            foreach (var log in _combatLogList)
            {
                Console.WriteLine(CombatLogToString(log));
            }
        }

        public string LogSkill(string initiator, string target, string skill, Tuple<int, string> result)
        {
            _combatLogList.Add(Tuple.Create(initiator, target, skill, result.Item1, result.Item2, LogType.Skill));
            if (IsDebug)
            {
                Console.WriteLine(CombatLogToString(_combatLogList.Last()));
            }

            return CombatLogToString(_combatLogList.Last());
        }

        public string LogModifierLoss(Pawn.Pawn pawn, IModifier modifier)
        {
            _combatLogList.Add(Tuple.Create(pawn.Name, modifier.Name, modifier.Name, 0, "", LogType.ModifierLoss));
            if (IsDebug)
            {
                Console.WriteLine(CombatLogToString(_combatLogList.Last()));
            }

            return CombatLogToString(_combatLogList.Last());
        }

        public string LogModifierGain(Pawn.Pawn pawn, IModifier modifier)
        {
            _combatLogList.Add(Tuple.Create(pawn.Name, modifier.Name, modifier.Giver.Name, modifier.Duration, "",
                LogType.ModifierGain));
            if (IsDebug)
            {
                Console.WriteLine(CombatLogToString(_combatLogList.Last()));
            }

            return CombatLogToString(_combatLogList.Last());
        }

        public enum LogType
        {
            Skill,
            ModifierLoss,
            ModifierGain
        }
    }
}