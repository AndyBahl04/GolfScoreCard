using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolfScoreCard
{
    internal class Calculations
    {
        public int FinalScore(List<int> scores)
        {
            return scores.Sum();
        }

        public double UpdateHandicap (int finalScore, double handicap)
        {
            double newHandicap = handicap + ((finalScore - 36) / 2.0);

            return Math.Max(0, newHandicap);
        }
    }
}
