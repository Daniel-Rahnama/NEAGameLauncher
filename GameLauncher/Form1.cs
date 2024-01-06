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
using System.CodeDom;
using System.IO;
using System.Numerics;

namespace GameLauncher
{
    public partial class Form1 : Form
    {
        private static HttpClient client;

        private async void SetLeaderboardData()
        {
            LeaderboardDataLabel.Text = string.Empty;

            try
            {
                using HttpResponseMessage response = await client.GetAsync("leaderboard");

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Unable to connect to DB");
                }

                LeaderboardData data = JsonConvert.DeserializeObject<LeaderboardData>(await response.Content.ReadAsStringAsync());

                while (data.leaderboard.Count > 0) {
                    string minkey = "";
                    uint minval = uint.MaxValue;

                    for (int i = 0; i < data.leaderboard.Count; i++)
                    {
                        uint val = (uint)(data.leaderboard.ElementAt(i).Value.time1 + data.leaderboard.ElementAt(i).Value.time2 + data.leaderboard.ElementAt(i).Value.time3);
                        if (val < minval)
                        {
                            minval = val;
                            minkey = data.leaderboard.ElementAt(i).Key;
                        }
                    }

                    LeaderboardDataLabel.Text += minkey + ": " + data.leaderboard[minkey].time1 + ", " + data.leaderboard[minkey].time2 + ", " + data.leaderboard[minkey].time3 + "\n";

                    data.leaderboard.Remove(minkey);
                 }

                LeaderboardLastUpdatedLabel.Text = "Last Updated:\n" + DateTime.Now.ToString();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LeaderboardDataLabel.Text = "Unable to connect to DB";
            }
        }

        private void LoadSettingsFile()
        {
            using StreamReader settingsFile = new StreamReader(SettingsFileSearchTextBox.Text);
            Settings settings = JsonConvert.DeserializeObject<Settings>(settingsFile.ReadToEnd());

            FullscreenCheckBox.Checked = settings.fullscreen;
            MusicCheckBox.Checked = settings.music;
            WidthNumericUpDown.Value = settings.width;
            HeightNumericUpDown.Value = settings.height;
            TargetFPSNumericUpDown.Value = settings.targetFPS;
            ResourceFileSearchTextBox.Text = settings.resources;

            FullscreenCheckBox.Visible = true;
            MusicCheckBox.Visible = true;
            WidthLabel.Visible = true;
            WidthNumericUpDown.Visible = true;
            HeightLabel.Visible = true;
            HeightNumericUpDown.Visible = true;
            TargetFPSLabel.Visible = true;
            TargetFPSNumericUpDown.Visible = true;
            ResourcesLabel.Visible = true;
            ResourcesFileSearchButton.Visible = true;
            ResourceFileSearchTextBox.Visible = true;
            SaveSettingsButton.Visible = true;

            NoSettingsFileLabel.Visible = false;
        }

        private void LoadMissionFile()
        {
            using StreamReader missionFile = new StreamReader(MissionFileSearchTextBox.Text);
            dynamic mission = JsonConvert.DeserializeObject(missionFile.ReadToEnd());

            MissionNameTextBox.Text = mission["Mission Name"];
            MissionMapTextBox.Text = mission["Map Address"];
            MissionLeaderboardURLTextBox.Text = mission["Leaderboard URL"];

            MissionNameLabel.Visible = true;
            MissionMapLabel.Visible = true;
            MissionLeaderboardURLTextBox.Visible = true;
            MissionLeaderboardURLLabel.Visible = true;
            MissionMapSearchButton.Visible = true;
            MissionNameTextBox.Visible = true;
            MissionMapTextBox.Visible = true;
            SaveMissionButton.Visible = true;
            LeaderboardPersonalTimesLabel.Visible = true;
            Time1Label.Visible = true;
            Time2Label.Visible = true;
            Time3Label.Visible = true;
            PushToLeaderboardButton.Visible = true;

            NoMissionFileLabel.Visible = false;

            if (mission["Local Leaderboard Address"] != "")
            {
                using StreamReader LocalLeaderboardFile = new StreamReader((string)mission["Local Leaderboard Address"]);
                var localLeaderboard = JsonConvert.DeserializeObject<Dictionary<string, string>>(LocalLeaderboardFile.ReadToEnd());

                Time1ValueLabel.Text = localLeaderboard["time1"];
                Time2ValueLabel.Text = localLeaderboard["time2"];
                Time3ValueLabel.Text = localLeaderboard["time3"];
            }

            if (MissionLeaderboardURLTextBox.Text != "")
            {
                client = new HttpClient()
                {
                    BaseAddress = new Uri(MissionLeaderboardURLTextBox.Text)
                };
            }
        }

        private void SaveSettingsFile()
        {
            Settings settings = new Settings
            {
                fullscreen = FullscreenCheckBox.Checked,
                music = MusicCheckBox.Checked,
                width = (int)WidthNumericUpDown.Value,
                height = (int)HeightNumericUpDown.Value,
                targetFPS = (int)TargetFPSNumericUpDown.Value,
                resources = ResourceFileSearchTextBox.Text,
            };

            using StreamWriter settingsFile = new StreamWriter(SettingsFileSearchTextBox.Text);
            settingsFile.Write(JsonConvert.SerializeObject(settings));
        }

        private void SaveMissionFile()
        {
            using StreamReader missionFileRead = new StreamReader(MissionFileSearchTextBox.Text);
            dynamic mission = JsonConvert.DeserializeObject(missionFileRead.ReadToEnd());
            missionFileRead.Close();

            mission["Mission Name"] = MissionNameTextBox.Text;
            mission["Map Address"] = MissionMapTextBox.Text;
            mission["Leaderboard URL"] = MissionLeaderboardURLTextBox.Text;

            using StreamWriter missionFileWrite = new StreamWriter(MissionFileSearchTextBox.Text);
            missionFileWrite.Write(mission);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Process game = new Process();
            game.StartInfo.FileName = "C:\\Repositories\\NEAGame\\build\\Game.exe";
            game.StartInfo.Arguments += "-username " + UsernameTextBox.Text + " -playerSpriteSheet " + PlayerSpriteFileSearchTextBox.Text;
            if (UsernameTextBox.Text.Length > 0)
            {
                game.StartInfo.Arguments += " -username \"" + UsernameTextBox.Text + "\"";
            }
            if (PlayerSpriteFileSearchTextBox.Text.Length > 0)
            {
                game.StartInfo.Arguments += " -playerSpritesheet \"" + PlayerSpriteFileSearchTextBox.Text + "\"";
            }
            if (MobSpriteFileSearchTextBox.Text.Length > 0)
            {
                game.StartInfo.Arguments += " -mobSpritesheet \"" + MobSpriteFileSearchTextBox.Text + "\"";
            }
            if (MissionFileSearchTextBox.Text.Length > 0)
            {
                game.StartInfo.Arguments += " -gameMission \"" + MissionFileSearchTextBox.Text + "\"";
            }
            if (DifficultyLevelSelector.SelectedIndex == 3)
            {
                game.StartInfo.Arguments += " -difficultyLevel \"\"";
                game.StartInfo.Arguments += " -playerStats \"" + PlayerStatsSearchTextBox.Text + "\"";
                game.StartInfo.Arguments += " -mobStats \"" + MobStatsSearchTextBox.Text + "\"";
            } else
            {
                game.StartInfo.Arguments += " -difficultyLevel \"" + (DifficultyLevelSelector.SelectedIndex + 1) + "\"";
                switch (DifficultyLevelSelector.SelectedIndex)
                {
                    case 0:
                        game.StartInfo.Arguments += " -playerStats \"C:\\Users\\Daniel Rahnama\\source\\repos\\NEAGameLauncher\\GameLauncher\\bin\\Debug\\PlayerStats\\1.json\"";
                        game.StartInfo.Arguments += " -mobStats \"C:\\Users\\Daniel Rahnama\\source\\repos\\NEAGameLauncher\\GameLauncher\\bin\\Debug\\MobStats\\1.json\"";
                        break;
                    case 1:
                        game.StartInfo.Arguments += " -playerStats \"C:\\Users\\Daniel Rahnama\\source\\repos\\NEAGameLauncher\\GameLauncher\\bin\\Debug\\PlayerStats\\2.json\"";
                        game.StartInfo.Arguments += " -mobStats \"C:\\Users\\Daniel Rahnama\\source\\repos\\NEAGameLauncher\\GameLauncher\\bin\\Debug\\MobStats\\2.json\"";
                        break;
                    case 2:
                        game.StartInfo.Arguments += " -playerStats \"C:\\Users\\Daniel Rahnama\\source\\repos\\NEAGameLauncher\\GameLauncher\\bin\\Debug\\PlayerStats\\3.json\"";
                        game.StartInfo.Arguments += " -mobStats \"C:\\Users\\Daniel Rahnama\\source\\repos\\NEAGameLauncher\\GameLauncher\\bin\\Debug\\MobStats\\3.json\"";
                        break;
                }
            }
            game.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WidthNumericUpDown.Maximum = Screen.PrimaryScreen.Bounds.Width;
            HeightNumericUpDown.Maximum = Screen.PrimaryScreen.Bounds.Height;

            if (File.Exists("LauncherSettings.json"))
            {
                using StreamReader launcherSettingsFile = new StreamReader("LauncherSettings.json");
                LauncherSettings launcherSettings = JsonConvert.DeserializeObject<LauncherSettings>(launcherSettingsFile.ReadToEnd());

                UsernameTextBox.Text = launcherSettings.username;
                PlayerSpriteFileSearchTextBox.Text = launcherSettings.playerspritefile;
                MobSpriteFileSearchTextBox.Text = launcherSettings.mobspritefile;
                SettingsFileSearchTextBox.Text = launcherSettings.settingsfile;
                MissionFileSearchTextBox.Text = launcherSettings.missionfile;
                DifficultyLevelSelector.SelectedIndex = launcherSettings.difficultylevel - 1;
                PlayerStatsSearchTextBox.Text = launcherSettings.playerstatfile;
                MobStatsSearchTextBox.Text = launcherSettings.mobstatfile;

                if (DifficultyLevelSelector.SelectedIndex == 3)
                {
                    PlayerStatsLabel.Visible = true;
                    PlayerStatsSearchButton.Visible = true;
                    PlayerStatsSearchTextBox.Visible = true;
                    MobStatsLabel.Visible = true;
                    MobStatsSearchButton.Visible = true;
                    MobStatsSearchTextBox.Visible = true;
                }

                if (SettingsFileSearchTextBox.Text != "")
                {
                    LoadSettingsFile();
                }

                if (MissionFileSearchTextBox.Text != "")
                {
                    LoadMissionFile();
                }

                if (MissionLeaderboardURLTextBox.Text != "")
                {
                    SetLeaderboardData();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LauncherSettings launcherSettings = new LauncherSettings
            {
                username = UsernameTextBox.Text,
                playerspritefile = PlayerSpriteFileSearchTextBox.Text,
                mobspritefile = MobSpriteFileSearchTextBox.Text,
                settingsfile = SettingsFileSearchTextBox.Text,
                missionfile = MissionFileSearchTextBox.Text,
                difficultylevel = DifficultyLevelSelector.SelectedIndex + 1,
                playerstatfile = PlayerStatsSearchTextBox.Text,
                mobstatfile = MobStatsSearchTextBox.Text
            };

            using StreamWriter launcherSettingsFile = new StreamWriter("LauncherSettings.json");
            launcherSettingsFile.Write(JsonConvert.SerializeObject(launcherSettings));
        }

        private void RefreshLeaderboardButton_Click(object sender, EventArgs e)
        {
            SetLeaderboardData();
        }

        private void SettingsFileSearchButton_Click(object sender, EventArgs e)
        {
            SettingsFileSearchDialogueBox.ShowDialog(this);
        }

        private void SettingsFileSearchDialogueBox_FileOk(object sender, CancelEventArgs e)
        {
            SettingsFileSearchTextBox.Text = SettingsFileSearchDialogueBox.FileName;
            LoadSettingsFile();
        }

        private void SettingsSelectorOpenButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SettingsFileSearchTextBox.Text))
            {
                LoadSettingsFile();
            }
        }

        private void ResourcesFileSearchButton_Click(object sender, EventArgs e)
        {
            ResourceFolderSearchDialogueBox.ShowDialog(this);
            ResourceFileSearchTextBox.Text = ResourceFolderSearchDialogueBox.SelectedPath;
        }

        private void SaveSettingsButton_Click(object sender, EventArgs e)
        {
            SaveSettingsFile();
        }

        private void SpriteFileSearchButton_Click(object sender, EventArgs e)
        {
            PlayerSpriteFileSearchDialogueBox.ShowDialog(this);
            PlayerSpriteFileSearchTextBox.Text =  PlayerSpriteFileSearchDialogueBox.FileName;
        }

        private void MissionFileSearchButton_Click(object sender, EventArgs e)
        {
            MissionFileSearchOpenDialogueBox.ShowDialog(this);
        }

        private void MissionFileSearchOpenDialogueBox_FileOk(object sender, CancelEventArgs e)
        {
            MissionFileSearchTextBox.Text = MissionFileSearchOpenDialogueBox.FileName;
            LoadMissionFile();
        }

        private void SaveMissionButton_Click(object sender, EventArgs e)
        {
            SaveMissionFile();
        }

        private void MissionSelecterOpenButton_Click(object sender, EventArgs e)
        {
            LoadMissionFile();
        }

        private void MobSpriteFileSearchButton_Click(object sender, EventArgs e)
        {
            MobSpriteFileSearchDialogueBox.ShowDialog(this);
            MobSpriteFileSearchTextBox.Text = MobSpriteFileSearchDialogueBox.FileName;
        }

        private void PushToLeaderboardButton_Click(object sender, EventArgs e)
        {
            try
            {
                LeaderboardData data = new LeaderboardData()
                {
                    leaderboard = new Dictionary<string, LeaderboardPlayer>()
                };

                data.leaderboard.Add(UsernameTextBox.Text, new LeaderboardPlayer()
                {
                    time1 = Int32.Parse(Time1ValueLabel.Text),
                    time2 = Int32.Parse(Time2ValueLabel.Text),
                    time3 = Int32.Parse(Time3ValueLabel.Text)
            });

                var content = new StringContent(JsonConvert.SerializeObject(data).ToString(), Encoding.UTF8, "application/json");
                var result = client.PostAsync("leaderboard", content).Result;

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LeaderboardDataLabel.Text = "Unable to connect to DB";
            }

            SetLeaderboardData();
        }

        private void PlayerStatsSearchButton_Click(object sender, EventArgs e)
        {
            PlayerStatsFileSearchDialogueBox.ShowDialog(this);
            PlayerStatsSearchTextBox.Text = PlayerStatsFileSearchDialogueBox.FileName;
        }

        private void MobStatsSearchButton_Click(object sender, EventArgs e)
        {
            MobStatsFileSearchDialogueBox.ShowDialog(this);
            MobStatsSearchTextBox.Text = MobStatsFileSearchDialogueBox.FileName;
        }

        private void DifficultyLevelSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DifficultyLevelSelector.SelectedIndex == 3)
            {
                PlayerStatsLabel.Visible = true;
                PlayerStatsSearchButton.Visible = true;
                PlayerStatsSearchTextBox.Visible = true;
                MobStatsLabel.Visible = true;
                MobStatsSearchButton.Visible = true;
                MobStatsSearchTextBox.Visible = true;
            } else
            {
                PlayerStatsLabel.Visible = false;
                PlayerStatsSearchButton.Visible = false;
                PlayerStatsSearchTextBox.Visible = false;
                MobStatsLabel.Visible = false;
                MobStatsSearchButton.Visible = false;
                MobStatsSearchTextBox.Visible = false;
            }
        }
    }
}
