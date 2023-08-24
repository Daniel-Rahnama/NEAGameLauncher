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

namespace GameLauncher
{
    public partial class Form1 : Form
    {
        private static HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("http://danielrahnama.com:1323/")
        };

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

                foreach (KeyValuePair<string, LeaderboardPlayer> player in data.leaderboard)
                {
                    LeaderboardDataLabel.Text += player.Key + ": " + player.Value.time1 + ", " + player.Value.time2 + ", " + player.Value.time3 + "\n";
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

        public Form1()
        {
            InitializeComponent();
        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            Process game = new Process();
            game.StartInfo.FileName = "C:\\Repositories\\NEAGame\\Game\\build\\Game.exe";
            game.StartInfo.Arguments += "-u " + UsernameTextBox.Text + " -s " + SpriteFileSearchTextBox.Text;
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
                SpriteFileSearchTextBox.Text = launcherSettings.spritefile;
                SettingsFileSearchTextBox.Text = launcherSettings.settingsfile;

                LoadSettingsFile();
            }

            SetLeaderboardData();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            LauncherSettings launcherSettings = new LauncherSettings
            {
                username = UsernameTextBox.Text,
                spritefile = SpriteFileSearchTextBox.Text,
                settingsfile = SettingsFileSearchTextBox.Text,
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
            SpriteFileSearchDialogueBox.ShowDialog(this);
            SpriteFileSearchTextBox.Text =  SpriteFileSearchDialogueBox.FileName;
        }
    }
}
