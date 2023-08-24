using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher
{
    public class LeaderboardPlayer
    {
        public int time1;
        public int time2;
        public int time3;
    }

    public class LeaderboardData
    {
        public Dictionary<string, LeaderboardPlayer> leaderboard;
    }
}
