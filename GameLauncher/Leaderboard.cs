using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher
{
    public class LeaderboardPlayer
    {
        public int Time1;
        public int Time2;
        public int Time3;
    }

    public class LeaderboardData
    {
        public Dictionary<string, LeaderboardPlayer> Leaderboard;
    }
}
