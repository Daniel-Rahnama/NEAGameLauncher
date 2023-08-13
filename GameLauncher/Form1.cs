using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GameLauncher
{
    public partial class Form1 : Form
    {
        private static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("http://danielrahnama.com:1323/")
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process game = new Process();
            game.StartInfo.FileName = "C:\\Repositories\\NEAGame\\Game\\build\\Game.exe";
            game.Start(); 
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            using HttpResponseMessage response = await client.GetAsync("leaderboard");

            LeaderboardData data = JsonConvert.DeserializeObject<LeaderboardData>(await response.Content.ReadAsStringAsync());

            foreach (KeyValuePair<string, LeaderboardPlayer> player in data.Leaderboard)
            {
                label1.Text += player.Key + " :" + player.Value.Time1 + ", " + player.Value.Time2 + ", " + player.Value.Time3 + "\n";
            }
        }
    }
}
