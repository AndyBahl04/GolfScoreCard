using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfScoreCard
{
    internal class History
    {
        public class PlayerHistory
        {
            private const string FileName = "user_history.txt";

            public static void SaveUserScore(string playerName, int score)
            {
                using (StreamWriter writer = new StreamWriter(FileName, true))
                {
                    writer.WriteLine($"{playerName},{score}");
                }
            }

            public static List<HistoryEntry> LoadUserScores()
            {
                List<HistoryEntry> userHistory = new List<HistoryEntry>();

                if (File.Exists(FileName))
                {
                    using (StreamReader reader = new StreamReader(FileName))
                    {
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length == 2)
                            {
                                string playerName = parts[0];
                                int score = int.Parse(parts[1]);
                                userHistory.Add(new HistoryEntry { PlayerName = playerName, Score = score });
                            }
                        }
                    }
                }

                return userHistory;
            }
        }

        public class HistoryEntry
        {
            public string PlayerName { get; set; }
            public int Score { get; set; }
        }
    }
}
