using System;
using System.Windows.Forms;

namespace GameLauncher
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PlayButton = new System.Windows.Forms.Button();
            this.LeaderboardHeader = new System.Windows.Forms.Label();
            this.LeaderboardRefreshButton = new System.Windows.Forms.Button();
            this.LeaderboardLastUpdatedLabel = new System.Windows.Forms.Label();
            this.LeaderboardDataLabel = new System.Windows.Forms.Label();
            this.SettingsHeader = new System.Windows.Forms.Label();
            this.SettingsFileSelectorLabel = new System.Windows.Forms.Label();
            this.SettingsFileSearchButton = new System.Windows.Forms.Button();
            this.SettingsFileSearchTextBox = new System.Windows.Forms.TextBox();
            this.SettingsSelectorOpenButton = new System.Windows.Forms.Button();
            this.SettingsFileSearchDialogueBox = new System.Windows.Forms.OpenFileDialog();
            this.FullscreenCheckBox = new System.Windows.Forms.CheckBox();
            this.MusicCheckBox = new System.Windows.Forms.CheckBox();
            this.WidthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TargetFPSLabel = new System.Windows.Forms.Label();
            this.TargetFPSNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.ResourcesLabel = new System.Windows.Forms.Label();
            this.ResourcesFileSearchButton = new System.Windows.Forms.Button();
            this.ResourceFolderSearchDialogueBox = new System.Windows.Forms.FolderBrowserDialog();
            this.ResourceFileSearchTextBox = new System.Windows.Forms.TextBox();
            this.SaveSettingsButton = new System.Windows.Forms.Button();
            this.NoSettingsFileLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerSpriteLabel = new System.Windows.Forms.Label();
            this.PlayerSpriteFileSearchButton = new System.Windows.Forms.Button();
            this.PlayerSpriteFileSearchTextBox = new System.Windows.Forms.TextBox();
            this.PlayerSpriteFileSearchDialogueBox = new System.Windows.Forms.OpenFileDialog();
            this.MissionHeader = new System.Windows.Forms.Label();
            this.MissionFileSelectorLabel = new System.Windows.Forms.Label();
            this.MissionFileSearchButton = new System.Windows.Forms.Button();
            this.MissionFileSearchTextBox = new System.Windows.Forms.TextBox();
            this.MissionSelecterOpenButton = new System.Windows.Forms.Button();
            this.MissionNameLabel = new System.Windows.Forms.Label();
            this.MissionNameTextBox = new System.Windows.Forms.TextBox();
            this.MissionMapLabel = new System.Windows.Forms.Label();
            this.MissionMapSearchButton = new System.Windows.Forms.Button();
            this.MissionMapTextBox = new System.Windows.Forms.TextBox();
            this.MissionLeaderboardURLLabel = new System.Windows.Forms.Label();
            this.MissionLeaderboardURLTextBox = new System.Windows.Forms.TextBox();
            this.NoMissionFileLabel = new System.Windows.Forms.Label();
            this.MissionFileSearchOpenDialogueBox = new System.Windows.Forms.OpenFileDialog();
            this.SaveMissionButton = new System.Windows.Forms.Button();
            this.MobSpriteLabel = new System.Windows.Forms.Label();
            this.MobSpriteFileSearchButton = new System.Windows.Forms.Button();
            this.MobSpriteFileSearchTextBox = new System.Windows.Forms.TextBox();
            this.MobSpriteFileSearchDialogueBox = new System.Windows.Forms.OpenFileDialog();
            this.LeaderboardPersonalTimesLabel = new System.Windows.Forms.Label();
            this.Time1Label = new System.Windows.Forms.Label();
            this.Time2Label = new System.Windows.Forms.Label();
            this.Time3Label = new System.Windows.Forms.Label();
            this.PushToLeaderboardButton = new System.Windows.Forms.Button();
            this.Time1ValueLabel = new System.Windows.Forms.Label();
            this.Time2ValueLabel = new System.Windows.Forms.Label();
            this.Time3ValueLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DifficultyLevelSelector = new System.Windows.Forms.ComboBox();
            this.DifficultyLevelSelectorLabel = new System.Windows.Forms.Label();
            this.PlayerStatsLabel = new System.Windows.Forms.Label();
            this.PlayerStatsSearchTextBox = new System.Windows.Forms.TextBox();
            this.PlayerStatsSearchButton = new System.Windows.Forms.Button();
            this.MobStatsLabel = new System.Windows.Forms.Label();
            this.MobStatsSearchButton = new System.Windows.Forms.Button();
            this.MobStatsSearchTextBox = new System.Windows.Forms.TextBox();
            this.MobStatsFileSearchDialogueBox = new System.Windows.Forms.OpenFileDialog();
            this.PlayerStatsFileSearchDialogueBox = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetFPSNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(460, 370);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(209, 60);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "Play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // LeaderboardHeader
            // 
            this.LeaderboardHeader.AutoSize = true;
            this.LeaderboardHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LeaderboardHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardHeader.Location = new System.Drawing.Point(910, 12);
            this.LeaderboardHeader.Name = "LeaderboardHeader";
            this.LeaderboardHeader.Size = new System.Drawing.Size(201, 39);
            this.LeaderboardHeader.TabIndex = 2;
            this.LeaderboardHeader.Text = "Leaderboard";
            // 
            // LeaderboardRefreshButton
            // 
            this.LeaderboardRefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardRefreshButton.Location = new System.Drawing.Point(910, 54);
            this.LeaderboardRefreshButton.Name = "LeaderboardRefreshButton";
            this.LeaderboardRefreshButton.Size = new System.Drawing.Size(75, 25);
            this.LeaderboardRefreshButton.TabIndex = 4;
            this.LeaderboardRefreshButton.Text = "Refresh";
            this.LeaderboardRefreshButton.UseVisualStyleBackColor = true;
            this.LeaderboardRefreshButton.Click += new System.EventHandler(this.RefreshLeaderboardButton_Click);
            // 
            // LeaderboardLastUpdatedLabel
            // 
            this.LeaderboardLastUpdatedLabel.AutoSize = true;
            this.LeaderboardLastUpdatedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardLastUpdatedLabel.ForeColor = System.Drawing.Color.IndianRed;
            this.LeaderboardLastUpdatedLabel.Location = new System.Drawing.Point(991, 51);
            this.LeaderboardLastUpdatedLabel.Name = "LeaderboardLastUpdatedLabel";
            this.LeaderboardLastUpdatedLabel.Size = new System.Drawing.Size(0, 15);
            this.LeaderboardLastUpdatedLabel.TabIndex = 5;
            // 
            // LeaderboardDataLabel
            // 
            this.LeaderboardDataLabel.AutoSize = true;
            this.LeaderboardDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardDataLabel.Location = new System.Drawing.Point(907, 83);
            this.LeaderboardDataLabel.MaximumSize = new System.Drawing.Size(0, 242);
            this.LeaderboardDataLabel.Name = "LeaderboardDataLabel";
            this.LeaderboardDataLabel.Size = new System.Drawing.Size(0, 16);
            this.LeaderboardDataLabel.TabIndex = 7;
            // 
            // SettingsHeader
            // 
            this.SettingsHeader.AutoSize = true;
            this.SettingsHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsHeader.Location = new System.Drawing.Point(12, 9);
            this.SettingsHeader.Name = "SettingsHeader";
            this.SettingsHeader.Size = new System.Drawing.Size(134, 39);
            this.SettingsHeader.TabIndex = 8;
            this.SettingsHeader.Text = "Settings";
            // 
            // SettingsFileSelectorLabel
            // 
            this.SettingsFileSelectorLabel.AutoSize = true;
            this.SettingsFileSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsFileSelectorLabel.Location = new System.Drawing.Point(12, 53);
            this.SettingsFileSelectorLabel.Name = "SettingsFileSelectorLabel";
            this.SettingsFileSelectorLabel.Size = new System.Drawing.Size(101, 20);
            this.SettingsFileSelectorLabel.TabIndex = 9;
            this.SettingsFileSelectorLabel.Text = "Settings File:";
            // 
            // SettingsFileSearchButton
            // 
            this.SettingsFileSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsFileSearchButton.Location = new System.Drawing.Point(119, 53);
            this.SettingsFileSearchButton.Name = "SettingsFileSearchButton";
            this.SettingsFileSearchButton.Size = new System.Drawing.Size(103, 23);
            this.SettingsFileSearchButton.TabIndex = 10;
            this.SettingsFileSearchButton.Text = "Browse";
            this.SettingsFileSearchButton.UseVisualStyleBackColor = true;
            this.SettingsFileSearchButton.Click += new System.EventHandler(this.SettingsFileSearchButton_Click);
            // 
            // SettingsFileSearchTextBox
            // 
            this.SettingsFileSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsFileSearchTextBox.Location = new System.Drawing.Point(11, 80);
            this.SettingsFileSearchTextBox.Name = "SettingsFileSearchTextBox";
            this.SettingsFileSearchTextBox.Size = new System.Drawing.Size(210, 21);
            this.SettingsFileSearchTextBox.TabIndex = 11;
            // 
            // SettingsSelectorOpenButton
            // 
            this.SettingsSelectorOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsSelectorOpenButton.Location = new System.Drawing.Point(11, 107);
            this.SettingsSelectorOpenButton.Name = "SettingsSelectorOpenButton";
            this.SettingsSelectorOpenButton.Size = new System.Drawing.Size(210, 26);
            this.SettingsSelectorOpenButton.TabIndex = 12;
            this.SettingsSelectorOpenButton.Text = "Open Settings File";
            this.SettingsSelectorOpenButton.UseVisualStyleBackColor = true;
            this.SettingsSelectorOpenButton.Click += new System.EventHandler(this.SettingsSelectorOpenButton_Click);
            // 
            // SettingsFileSearchDialogueBox
            // 
            this.SettingsFileSearchDialogueBox.DefaultExt = "json";
            this.SettingsFileSearchDialogueBox.Filter = "Json files (*.json)|*.json|All files (*.*)|*.*";
            this.SettingsFileSearchDialogueBox.InitialDirectory = "C:\\Users\\Daniel\\AppData\\Roaming\\NEAGame";
            this.SettingsFileSearchDialogueBox.FileOk += new System.ComponentModel.CancelEventHandler(this.SettingsFileSearchDialogueBox_FileOk);
            // 
            // FullscreenCheckBox
            // 
            this.FullscreenCheckBox.AutoSize = true;
            this.FullscreenCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullscreenCheckBox.Location = new System.Drawing.Point(12, 139);
            this.FullscreenCheckBox.Name = "FullscreenCheckBox";
            this.FullscreenCheckBox.Size = new System.Drawing.Size(88, 20);
            this.FullscreenCheckBox.TabIndex = 14;
            this.FullscreenCheckBox.Text = "Fullscreen";
            this.FullscreenCheckBox.UseVisualStyleBackColor = true;
            this.FullscreenCheckBox.Visible = false;
            // 
            // MusicCheckBox
            // 
            this.MusicCheckBox.AutoSize = true;
            this.MusicCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicCheckBox.Location = new System.Drawing.Point(119, 139);
            this.MusicCheckBox.Name = "MusicCheckBox";
            this.MusicCheckBox.Size = new System.Drawing.Size(61, 20);
            this.MusicCheckBox.TabIndex = 15;
            this.MusicCheckBox.Text = "Music";
            this.MusicCheckBox.UseVisualStyleBackColor = true;
            this.MusicCheckBox.Visible = false;
            // 
            // WidthNumericUpDown
            // 
            this.WidthNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthNumericUpDown.Location = new System.Drawing.Point(100, 160);
            this.WidthNumericUpDown.Name = "WidthNumericUpDown";
            this.WidthNumericUpDown.Size = new System.Drawing.Size(121, 21);
            this.WidthNumericUpDown.TabIndex = 16;
            this.WidthNumericUpDown.Visible = false;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.Location = new System.Drawing.Point(8, 162);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(44, 16);
            this.WidthLabel.TabIndex = 17;
            this.WidthLabel.Text = "Width:";
            this.WidthLabel.Visible = false;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(8, 189);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(49, 16);
            this.HeightLabel.TabIndex = 18;
            this.HeightLabel.Text = "Height:";
            this.HeightLabel.Visible = false;
            // 
            // HeightNumericUpDown
            // 
            this.HeightNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightNumericUpDown.Location = new System.Drawing.Point(100, 187);
            this.HeightNumericUpDown.Name = "HeightNumericUpDown";
            this.HeightNumericUpDown.Size = new System.Drawing.Size(121, 21);
            this.HeightNumericUpDown.TabIndex = 19;
            this.HeightNumericUpDown.Visible = false;
            // 
            // TargetFPSLabel
            // 
            this.TargetFPSLabel.AutoSize = true;
            this.TargetFPSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetFPSLabel.Location = new System.Drawing.Point(8, 216);
            this.TargetFPSLabel.Name = "TargetFPSLabel";
            this.TargetFPSLabel.Size = new System.Drawing.Size(76, 16);
            this.TargetFPSLabel.TabIndex = 20;
            this.TargetFPSLabel.Text = "TargetFPS:";
            this.TargetFPSLabel.Visible = false;
            // 
            // TargetFPSNumericUpDown
            // 
            this.TargetFPSNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetFPSNumericUpDown.Location = new System.Drawing.Point(100, 214);
            this.TargetFPSNumericUpDown.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.TargetFPSNumericUpDown.Name = "TargetFPSNumericUpDown";
            this.TargetFPSNumericUpDown.Size = new System.Drawing.Size(121, 21);
            this.TargetFPSNumericUpDown.TabIndex = 21;
            this.TargetFPSNumericUpDown.Visible = false;
            // 
            // ResourcesLabel
            // 
            this.ResourcesLabel.AutoSize = true;
            this.ResourcesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResourcesLabel.Location = new System.Drawing.Point(8, 245);
            this.ResourcesLabel.Name = "ResourcesLabel";
            this.ResourcesLabel.Size = new System.Drawing.Size(76, 16);
            this.ResourcesLabel.TabIndex = 22;
            this.ResourcesLabel.Text = "Resources:";
            this.ResourcesLabel.Visible = false;
            // 
            // ResourcesFileSearchButton
            // 
            this.ResourcesFileSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResourcesFileSearchButton.Location = new System.Drawing.Point(100, 241);
            this.ResourcesFileSearchButton.Name = "ResourcesFileSearchButton";
            this.ResourcesFileSearchButton.Size = new System.Drawing.Size(122, 23);
            this.ResourcesFileSearchButton.TabIndex = 23;
            this.ResourcesFileSearchButton.Text = "Browse";
            this.ResourcesFileSearchButton.UseVisualStyleBackColor = true;
            this.ResourcesFileSearchButton.Visible = false;
            this.ResourcesFileSearchButton.Click += new System.EventHandler(this.ResourcesFileSearchButton_Click);
            // 
            // ResourceFileSearchTextBox
            // 
            this.ResourceFileSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResourceFileSearchTextBox.Location = new System.Drawing.Point(11, 270);
            this.ResourceFileSearchTextBox.Name = "ResourceFileSearchTextBox";
            this.ResourceFileSearchTextBox.Size = new System.Drawing.Size(210, 21);
            this.ResourceFileSearchTextBox.TabIndex = 24;
            this.ResourceFileSearchTextBox.Visible = false;
            // 
            // SaveSettingsButton
            // 
            this.SaveSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveSettingsButton.Location = new System.Drawing.Point(11, 297);
            this.SaveSettingsButton.Name = "SaveSettingsButton";
            this.SaveSettingsButton.Size = new System.Drawing.Size(210, 44);
            this.SaveSettingsButton.TabIndex = 25;
            this.SaveSettingsButton.Text = "Save Settings";
            this.SaveSettingsButton.UseVisualStyleBackColor = true;
            this.SaveSettingsButton.Visible = false;
            this.SaveSettingsButton.Click += new System.EventHandler(this.SaveSettingsButton_Click);
            // 
            // NoSettingsFileLabel
            // 
            this.NoSettingsFileLabel.AutoSize = true;
            this.NoSettingsFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoSettingsFileLabel.Location = new System.Drawing.Point(42, 200);
            this.NoSettingsFileLabel.Name = "NoSettingsFileLabel";
            this.NoSettingsFileLabel.Size = new System.Drawing.Size(151, 16);
            this.NoSettingsFileLabel.TabIndex = 26;
            this.NoSettingsFileLabel.Text = "No Settings file selected";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(470, 143);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 28;
            this.UsernameLabel.Text = "Username:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(474, 166);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(195, 21);
            this.UsernameTextBox.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "C:\\Users\\Daniel\\source\\repos\\GameLauncher\\GameLauncher\\map.ico";
            this.pictureBox1.Location = new System.Drawing.Point(506, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerSpriteLabel
            // 
            this.PlayerSpriteLabel.AutoSize = true;
            this.PlayerSpriteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSpriteLabel.Location = new System.Drawing.Point(470, 190);
            this.PlayerSpriteLabel.Name = "PlayerSpriteLabel";
            this.PlayerSpriteLabel.Size = new System.Drawing.Size(102, 20);
            this.PlayerSpriteLabel.TabIndex = 31;
            this.PlayerSpriteLabel.Text = "Player Sprite:";
            // 
            // PlayerSpriteFileSearchButton
            // 
            this.PlayerSpriteFileSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSpriteFileSearchButton.Location = new System.Drawing.Point(570, 190);
            this.PlayerSpriteFileSearchButton.Name = "PlayerSpriteFileSearchButton";
            this.PlayerSpriteFileSearchButton.Size = new System.Drawing.Size(99, 22);
            this.PlayerSpriteFileSearchButton.TabIndex = 32;
            this.PlayerSpriteFileSearchButton.Text = "Browse";
            this.PlayerSpriteFileSearchButton.UseVisualStyleBackColor = true;
            this.PlayerSpriteFileSearchButton.Click += new System.EventHandler(this.SpriteFileSearchButton_Click);
            // 
            // PlayerSpriteFileSearchTextBox
            // 
            this.PlayerSpriteFileSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSpriteFileSearchTextBox.Location = new System.Drawing.Point(474, 217);
            this.PlayerSpriteFileSearchTextBox.Name = "PlayerSpriteFileSearchTextBox";
            this.PlayerSpriteFileSearchTextBox.Size = new System.Drawing.Size(195, 21);
            this.PlayerSpriteFileSearchTextBox.TabIndex = 33;
            // 
            // PlayerSpriteFileSearchDialogueBox
            // 
            this.PlayerSpriteFileSearchDialogueBox.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            this.PlayerSpriteFileSearchDialogueBox.InitialDirectory = "C:\\Repositories\\NEAGame\\Game\\resources\\sprites";
            // 
            // MissionHeader
            // 
            this.MissionHeader.AutoSize = true;
            this.MissionHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MissionHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionHeader.Location = new System.Drawing.Point(236, 9);
            this.MissionHeader.Name = "MissionHeader";
            this.MissionHeader.Size = new System.Drawing.Size(127, 39);
            this.MissionHeader.TabIndex = 34;
            this.MissionHeader.Text = "Mission";
            // 
            // MissionFileSelectorLabel
            // 
            this.MissionFileSelectorLabel.AutoSize = true;
            this.MissionFileSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionFileSelectorLabel.Location = new System.Drawing.Point(236, 53);
            this.MissionFileSelectorLabel.Name = "MissionFileSelectorLabel";
            this.MissionFileSelectorLabel.Size = new System.Drawing.Size(95, 20);
            this.MissionFileSelectorLabel.TabIndex = 35;
            this.MissionFileSelectorLabel.Text = "Mission File:";
            // 
            // MissionFileSearchButton
            // 
            this.MissionFileSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionFileSearchButton.Location = new System.Drawing.Point(338, 53);
            this.MissionFileSearchButton.Name = "MissionFileSearchButton";
            this.MissionFileSearchButton.Size = new System.Drawing.Size(104, 23);
            this.MissionFileSearchButton.TabIndex = 36;
            this.MissionFileSearchButton.Text = "Browse";
            this.MissionFileSearchButton.UseVisualStyleBackColor = true;
            this.MissionFileSearchButton.Click += new System.EventHandler(this.MissionFileSearchButton_Click);
            // 
            // MissionFileSearchTextBox
            // 
            this.MissionFileSearchTextBox.Location = new System.Drawing.Point(236, 80);
            this.MissionFileSearchTextBox.Name = "MissionFileSearchTextBox";
            this.MissionFileSearchTextBox.Size = new System.Drawing.Size(206, 20);
            this.MissionFileSearchTextBox.TabIndex = 37;
            // 
            // MissionSelecterOpenButton
            // 
            this.MissionSelecterOpenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionSelecterOpenButton.Location = new System.Drawing.Point(236, 107);
            this.MissionSelecterOpenButton.Name = "MissionSelecterOpenButton";
            this.MissionSelecterOpenButton.Size = new System.Drawing.Size(206, 26);
            this.MissionSelecterOpenButton.TabIndex = 38;
            this.MissionSelecterOpenButton.Text = "Open Mission File";
            this.MissionSelecterOpenButton.UseVisualStyleBackColor = true;
            this.MissionSelecterOpenButton.Click += new System.EventHandler(this.MissionSelecterOpenButton_Click);
            // 
            // MissionNameLabel
            // 
            this.MissionNameLabel.AutoSize = true;
            this.MissionNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionNameLabel.Location = new System.Drawing.Point(233, 139);
            this.MissionNameLabel.Name = "MissionNameLabel";
            this.MissionNameLabel.Size = new System.Drawing.Size(47, 16);
            this.MissionNameLabel.TabIndex = 39;
            this.MissionNameLabel.Text = "Name:";
            this.MissionNameLabel.Visible = false;
            // 
            // MissionNameTextBox
            // 
            this.MissionNameTextBox.Location = new System.Drawing.Point(236, 160);
            this.MissionNameTextBox.Name = "MissionNameTextBox";
            this.MissionNameTextBox.Size = new System.Drawing.Size(206, 20);
            this.MissionNameTextBox.TabIndex = 40;
            this.MissionNameTextBox.Visible = false;
            // 
            // MissionMapLabel
            // 
            this.MissionMapLabel.AutoSize = true;
            this.MissionMapLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionMapLabel.Location = new System.Drawing.Point(233, 193);
            this.MissionMapLabel.Name = "MissionMapLabel";
            this.MissionMapLabel.Size = new System.Drawing.Size(37, 16);
            this.MissionMapLabel.TabIndex = 41;
            this.MissionMapLabel.Text = "Map:";
            this.MissionMapLabel.Visible = false;
            // 
            // MissionMapSearchButton
            // 
            this.MissionMapSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionMapSearchButton.Location = new System.Drawing.Point(338, 187);
            this.MissionMapSearchButton.Name = "MissionMapSearchButton";
            this.MissionMapSearchButton.Size = new System.Drawing.Size(104, 23);
            this.MissionMapSearchButton.TabIndex = 42;
            this.MissionMapSearchButton.Text = "Browse";
            this.MissionMapSearchButton.UseVisualStyleBackColor = true;
            this.MissionMapSearchButton.Visible = false;
            // 
            // MissionMapTextBox
            // 
            this.MissionMapTextBox.Location = new System.Drawing.Point(236, 216);
            this.MissionMapTextBox.Name = "MissionMapTextBox";
            this.MissionMapTextBox.Size = new System.Drawing.Size(206, 20);
            this.MissionMapTextBox.TabIndex = 43;
            this.MissionMapTextBox.Visible = false;
            // 
            // MissionLeaderboardURLLabel
            // 
            this.MissionLeaderboardURLLabel.AutoSize = true;
            this.MissionLeaderboardURLLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MissionLeaderboardURLLabel.Location = new System.Drawing.Point(233, 248);
            this.MissionLeaderboardURLLabel.Name = "MissionLeaderboardURLLabel";
            this.MissionLeaderboardURLLabel.Size = new System.Drawing.Size(119, 16);
            this.MissionLeaderboardURLLabel.TabIndex = 44;
            this.MissionLeaderboardURLLabel.Text = "Leaderboard URL:";
            this.MissionLeaderboardURLLabel.Visible = false;
            // 
            // MissionLeaderboardURLTextBox
            // 
            this.MissionLeaderboardURLTextBox.Location = new System.Drawing.Point(236, 270);
            this.MissionLeaderboardURLTextBox.Name = "MissionLeaderboardURLTextBox";
            this.MissionLeaderboardURLTextBox.Size = new System.Drawing.Size(206, 20);
            this.MissionLeaderboardURLTextBox.TabIndex = 45;
            this.MissionLeaderboardURLTextBox.Visible = false;
            // 
            // NoMissionFileLabel
            // 
            this.NoMissionFileLabel.AutoSize = true;
            this.NoMissionFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoMissionFileLabel.Location = new System.Drawing.Point(261, 200);
            this.NoMissionFileLabel.Name = "NoMissionFileLabel";
            this.NoMissionFileLabel.Size = new System.Drawing.Size(149, 16);
            this.NoMissionFileLabel.TabIndex = 47;
            this.NoMissionFileLabel.Text = "No Mission file selected";
            // 
            // MissionFileSearchOpenDialogueBox
            // 
            this.MissionFileSearchOpenDialogueBox.FileOk += new System.ComponentModel.CancelEventHandler(this.MissionFileSearchOpenDialogueBox_FileOk);
            // 
            // SaveMissionButton
            // 
            this.SaveMissionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveMissionButton.Location = new System.Drawing.Point(236, 296);
            this.SaveMissionButton.Name = "SaveMissionButton";
            this.SaveMissionButton.Size = new System.Drawing.Size(206, 45);
            this.SaveMissionButton.TabIndex = 46;
            this.SaveMissionButton.Text = "Save Mission";
            this.SaveMissionButton.UseVisualStyleBackColor = true;
            this.SaveMissionButton.Visible = false;
            this.SaveMissionButton.Click += new System.EventHandler(this.SaveMissionButton_Click);
            // 
            // MobSpriteLabel
            // 
            this.MobSpriteLabel.AutoSize = true;
            this.MobSpriteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobSpriteLabel.Location = new System.Drawing.Point(470, 244);
            this.MobSpriteLabel.Name = "MobSpriteLabel";
            this.MobSpriteLabel.Size = new System.Drawing.Size(90, 20);
            this.MobSpriteLabel.TabIndex = 48;
            this.MobSpriteLabel.Text = "Mob Sprite:";
            // 
            // MobSpriteFileSearchButton
            // 
            this.MobSpriteFileSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobSpriteFileSearchButton.Location = new System.Drawing.Point(570, 242);
            this.MobSpriteFileSearchButton.Name = "MobSpriteFileSearchButton";
            this.MobSpriteFileSearchButton.Size = new System.Drawing.Size(99, 23);
            this.MobSpriteFileSearchButton.TabIndex = 49;
            this.MobSpriteFileSearchButton.Text = "Browse";
            this.MobSpriteFileSearchButton.UseVisualStyleBackColor = true;
            this.MobSpriteFileSearchButton.Click += new System.EventHandler(this.MobSpriteFileSearchButton_Click);
            // 
            // MobSpriteFileSearchTextBox
            // 
            this.MobSpriteFileSearchTextBox.Location = new System.Drawing.Point(474, 270);
            this.MobSpriteFileSearchTextBox.Name = "MobSpriteFileSearchTextBox";
            this.MobSpriteFileSearchTextBox.Size = new System.Drawing.Size(195, 20);
            this.MobSpriteFileSearchTextBox.TabIndex = 50;
            // 
            // MobSpriteFileSearchDialogueBox
            // 
            this.MobSpriteFileSearchDialogueBox.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            this.MobSpriteFileSearchDialogueBox.InitialDirectory = "C:\\Repositories\\NEAGame\\Game\\resources\\sprites";
            // 
            // LeaderboardPersonalTimesLabel
            // 
            this.LeaderboardPersonalTimesLabel.AutoSize = true;
            this.LeaderboardPersonalTimesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardPersonalTimesLabel.Location = new System.Drawing.Point(678, 214);
            this.LeaderboardPersonalTimesLabel.Name = "LeaderboardPersonalTimesLabel";
            this.LeaderboardPersonalTimesLabel.Size = new System.Drawing.Size(121, 20);
            this.LeaderboardPersonalTimesLabel.TabIndex = 51;
            this.LeaderboardPersonalTimesLabel.Text = "Personal Times:";
            this.LeaderboardPersonalTimesLabel.Visible = false;
            // 
            // Time1Label
            // 
            this.Time1Label.AutoSize = true;
            this.Time1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time1Label.Location = new System.Drawing.Point(681, 238);
            this.Time1Label.Name = "Time1Label";
            this.Time1Label.Size = new System.Drawing.Size(54, 16);
            this.Time1Label.TabIndex = 52;
            this.Time1Label.Text = "Time 1: ";
            this.Time1Label.Visible = false;
            // 
            // Time2Label
            // 
            this.Time2Label.AutoSize = true;
            this.Time2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time2Label.Location = new System.Drawing.Point(681, 254);
            this.Time2Label.Name = "Time2Label";
            this.Time2Label.Size = new System.Drawing.Size(54, 16);
            this.Time2Label.TabIndex = 53;
            this.Time2Label.Text = "Time 2: ";
            this.Time2Label.Visible = false;
            // 
            // Time3Label
            // 
            this.Time3Label.AutoSize = true;
            this.Time3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time3Label.Location = new System.Drawing.Point(681, 270);
            this.Time3Label.Name = "Time3Label";
            this.Time3Label.Size = new System.Drawing.Size(54, 16);
            this.Time3Label.TabIndex = 54;
            this.Time3Label.Text = "Time 3: ";
            this.Time3Label.Visible = false;
            // 
            // PushToLeaderboardButton
            // 
            this.PushToLeaderboardButton.Location = new System.Drawing.Point(682, 289);
            this.PushToLeaderboardButton.Name = "PushToLeaderboardButton";
            this.PushToLeaderboardButton.Size = new System.Drawing.Size(198, 54);
            this.PushToLeaderboardButton.TabIndex = 55;
            this.PushToLeaderboardButton.Text = "Push to Leaderboard";
            this.PushToLeaderboardButton.UseVisualStyleBackColor = true;
            this.PushToLeaderboardButton.Visible = false;
            this.PushToLeaderboardButton.Click += new System.EventHandler(this.PushToLeaderboardButton_Click);
            // 
            // Time1ValueLabel
            // 
            this.Time1ValueLabel.AutoSize = true;
            this.Time1ValueLabel.Location = new System.Drawing.Point(735, 240);
            this.Time1ValueLabel.Name = "Time1ValueLabel";
            this.Time1ValueLabel.Size = new System.Drawing.Size(0, 13);
            this.Time1ValueLabel.TabIndex = 56;
            // 
            // Time2ValueLabel
            // 
            this.Time2ValueLabel.AutoSize = true;
            this.Time2ValueLabel.Location = new System.Drawing.Point(735, 256);
            this.Time2ValueLabel.Name = "Time2ValueLabel";
            this.Time2ValueLabel.Size = new System.Drawing.Size(0, 13);
            this.Time2ValueLabel.TabIndex = 57;
            // 
            // Time3ValueLabel
            // 
            this.Time3ValueLabel.AutoSize = true;
            this.Time3ValueLabel.Location = new System.Drawing.Point(735, 272);
            this.Time3ValueLabel.Name = "Time3ValueLabel";
            this.Time3ValueLabel.Size = new System.Drawing.Size(0, 13);
            this.Time3ValueLabel.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(682, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 39);
            this.label1.TabIndex = 59;
            this.label1.Text = "Difficulty Level";
            // 
            // DifficultyLevelSelector
            // 
            this.DifficultyLevelSelector.FormattingEnabled = true;
            this.DifficultyLevelSelector.Items.AddRange(new object[] {
            "Level 1",
            "Level 2",
            "Level 3",
            "Custom"});
            this.DifficultyLevelSelector.Location = new System.Drawing.Point(682, 82);
            this.DifficultyLevelSelector.Name = "DifficultyLevelSelector";
            this.DifficultyLevelSelector.Size = new System.Drawing.Size(121, 21);
            this.DifficultyLevelSelector.TabIndex = 60;
            this.DifficultyLevelSelector.SelectedIndexChanged += new System.EventHandler(this.DifficultyLevelSelector_SelectedIndexChanged);
            // 
            // DifficultyLevelSelectorLabel
            // 
            this.DifficultyLevelSelectorLabel.AutoSize = true;
            this.DifficultyLevelSelectorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DifficultyLevelSelectorLabel.Location = new System.Drawing.Point(678, 59);
            this.DifficultyLevelSelectorLabel.Name = "DifficultyLevelSelectorLabel";
            this.DifficultyLevelSelectorLabel.Size = new System.Drawing.Size(114, 20);
            this.DifficultyLevelSelectorLabel.TabIndex = 61;
            this.DifficultyLevelSelectorLabel.Text = "Difficulty Level:";
            // 
            // PlayerStatsLabel
            // 
            this.PlayerStatsLabel.AutoSize = true;
            this.PlayerStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStatsLabel.Location = new System.Drawing.Point(678, 109);
            this.PlayerStatsLabel.Name = "PlayerStatsLabel";
            this.PlayerStatsLabel.Size = new System.Drawing.Size(98, 20);
            this.PlayerStatsLabel.TabIndex = 62;
            this.PlayerStatsLabel.Text = "Player Stats:";
            this.PlayerStatsLabel.Visible = false;
            // 
            // PlayerStatsSearchTextBox
            // 
            this.PlayerStatsSearchTextBox.Location = new System.Drawing.Point(682, 133);
            this.PlayerStatsSearchTextBox.Name = "PlayerStatsSearchTextBox";
            this.PlayerStatsSearchTextBox.Size = new System.Drawing.Size(222, 20);
            this.PlayerStatsSearchTextBox.TabIndex = 63;
            this.PlayerStatsSearchTextBox.Visible = false;
            // 
            // PlayerStatsSearchButton
            // 
            this.PlayerStatsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerStatsSearchButton.Location = new System.Drawing.Point(783, 109);
            this.PlayerStatsSearchButton.Name = "PlayerStatsSearchButton";
            this.PlayerStatsSearchButton.Size = new System.Drawing.Size(121, 23);
            this.PlayerStatsSearchButton.TabIndex = 64;
            this.PlayerStatsSearchButton.Text = "Browse";
            this.PlayerStatsSearchButton.UseVisualStyleBackColor = true;
            this.PlayerStatsSearchButton.Visible = false;
            this.PlayerStatsSearchButton.Click += new System.EventHandler(this.PlayerStatsSearchButton_Click);
            // 
            // MobStatsLabel
            // 
            this.MobStatsLabel.AutoSize = true;
            this.MobStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobStatsLabel.Location = new System.Drawing.Point(678, 159);
            this.MobStatsLabel.Name = "MobStatsLabel";
            this.MobStatsLabel.Size = new System.Drawing.Size(86, 20);
            this.MobStatsLabel.TabIndex = 65;
            this.MobStatsLabel.Text = "Mob Stats:";
            this.MobStatsLabel.Visible = false;
            // 
            // MobStatsSearchButton
            // 
            this.MobStatsSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobStatsSearchButton.Location = new System.Drawing.Point(783, 158);
            this.MobStatsSearchButton.Name = "MobStatsSearchButton";
            this.MobStatsSearchButton.Size = new System.Drawing.Size(121, 23);
            this.MobStatsSearchButton.TabIndex = 66;
            this.MobStatsSearchButton.Text = "Browse";
            this.MobStatsSearchButton.UseVisualStyleBackColor = true;
            this.MobStatsSearchButton.Visible = false;
            this.MobStatsSearchButton.Click += new System.EventHandler(this.MobStatsSearchButton_Click);
            // 
            // MobStatsSearchTextBox
            // 
            this.MobStatsSearchTextBox.Location = new System.Drawing.Point(682, 183);
            this.MobStatsSearchTextBox.Name = "MobStatsSearchTextBox";
            this.MobStatsSearchTextBox.Size = new System.Drawing.Size(222, 20);
            this.MobStatsSearchTextBox.TabIndex = 67;
            this.MobStatsSearchTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1123, 438);
            this.Controls.Add(this.MobStatsSearchTextBox);
            this.Controls.Add(this.MobStatsSearchButton);
            this.Controls.Add(this.MobStatsLabel);
            this.Controls.Add(this.PlayerStatsSearchButton);
            this.Controls.Add(this.PlayerStatsSearchTextBox);
            this.Controls.Add(this.PlayerStatsLabel);
            this.Controls.Add(this.DifficultyLevelSelectorLabel);
            this.Controls.Add(this.DifficultyLevelSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time3ValueLabel);
            this.Controls.Add(this.Time2ValueLabel);
            this.Controls.Add(this.Time1ValueLabel);
            this.Controls.Add(this.PushToLeaderboardButton);
            this.Controls.Add(this.Time3Label);
            this.Controls.Add(this.Time2Label);
            this.Controls.Add(this.Time1Label);
            this.Controls.Add(this.LeaderboardPersonalTimesLabel);
            this.Controls.Add(this.MobSpriteFileSearchTextBox);
            this.Controls.Add(this.MobSpriteFileSearchButton);
            this.Controls.Add(this.MobSpriteLabel);
            this.Controls.Add(this.NoMissionFileLabel);
            this.Controls.Add(this.SaveMissionButton);
            this.Controls.Add(this.MissionLeaderboardURLTextBox);
            this.Controls.Add(this.MissionLeaderboardURLLabel);
            this.Controls.Add(this.MissionMapTextBox);
            this.Controls.Add(this.MissionMapSearchButton);
            this.Controls.Add(this.MissionMapLabel);
            this.Controls.Add(this.MissionNameTextBox);
            this.Controls.Add(this.MissionNameLabel);
            this.Controls.Add(this.MissionSelecterOpenButton);
            this.Controls.Add(this.MissionFileSearchTextBox);
            this.Controls.Add(this.MissionFileSearchButton);
            this.Controls.Add(this.MissionFileSelectorLabel);
            this.Controls.Add(this.MissionHeader);
            this.Controls.Add(this.PlayerSpriteFileSearchTextBox);
            this.Controls.Add(this.PlayerSpriteFileSearchButton);
            this.Controls.Add(this.PlayerSpriteLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.NoSettingsFileLabel);
            this.Controls.Add(this.SaveSettingsButton);
            this.Controls.Add(this.ResourceFileSearchTextBox);
            this.Controls.Add(this.ResourcesFileSearchButton);
            this.Controls.Add(this.ResourcesLabel);
            this.Controls.Add(this.TargetFPSNumericUpDown);
            this.Controls.Add(this.TargetFPSLabel);
            this.Controls.Add(this.HeightNumericUpDown);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.WidthNumericUpDown);
            this.Controls.Add(this.MusicCheckBox);
            this.Controls.Add(this.FullscreenCheckBox);
            this.Controls.Add(this.SettingsSelectorOpenButton);
            this.Controls.Add(this.SettingsFileSearchTextBox);
            this.Controls.Add(this.SettingsFileSearchButton);
            this.Controls.Add(this.SettingsFileSelectorLabel);
            this.Controls.Add(this.SettingsHeader);
            this.Controls.Add(this.LeaderboardDataLabel);
            this.Controls.Add(this.LeaderboardLastUpdatedLabel);
            this.Controls.Add(this.LeaderboardRefreshButton);
            this.Controls.Add(this.LeaderboardHeader);
            this.Controls.Add(this.PlayButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NEAGame Launcher";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetFPSNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.Label LeaderboardHeader;
        private System.Windows.Forms.Button LeaderboardRefreshButton;
        private System.Windows.Forms.Label LeaderboardLastUpdatedLabel;
        private System.Windows.Forms.Label LeaderboardDataLabel;
        private System.Windows.Forms.Label SettingsHeader;
        private System.Windows.Forms.Label SettingsFileSelectorLabel;
        private System.Windows.Forms.Button SettingsFileSearchButton;
        private System.Windows.Forms.TextBox SettingsFileSearchTextBox;
        private System.Windows.Forms.Button SettingsSelectorOpenButton;
        private System.Windows.Forms.OpenFileDialog SettingsFileSearchDialogueBox;
        private System.Windows.Forms.CheckBox FullscreenCheckBox;
        private System.Windows.Forms.CheckBox MusicCheckBox;
        private System.Windows.Forms.NumericUpDown WidthNumericUpDown;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.NumericUpDown HeightNumericUpDown;
        private System.Windows.Forms.Label TargetFPSLabel;
        private System.Windows.Forms.NumericUpDown TargetFPSNumericUpDown;
        private System.Windows.Forms.Label ResourcesLabel;
        private System.Windows.Forms.Button ResourcesFileSearchButton;
        private System.Windows.Forms.FolderBrowserDialog ResourceFolderSearchDialogueBox;
        private System.Windows.Forms.TextBox ResourceFileSearchTextBox;
        private System.Windows.Forms.Button SaveSettingsButton;
        private System.Windows.Forms.Label NoSettingsFileLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PlayerSpriteLabel;
        private System.Windows.Forms.Button PlayerSpriteFileSearchButton;
        private System.Windows.Forms.TextBox PlayerSpriteFileSearchTextBox;
        private System.Windows.Forms.OpenFileDialog PlayerSpriteFileSearchDialogueBox;
        private Label MissionHeader;
        private Label MissionFileSelectorLabel;
        private Button MissionFileSearchButton;
        private TextBox MissionFileSearchTextBox;
        private Button MissionSelecterOpenButton;
        private Label MissionNameLabel;
        private TextBox MissionNameTextBox;
        private Label MissionMapLabel;
        private Button MissionMapSearchButton;
        private TextBox MissionMapTextBox;
        private Label MissionLeaderboardURLLabel;
        private TextBox MissionLeaderboardURLTextBox;
        private Label NoMissionFileLabel;
        private OpenFileDialog MissionFileSearchOpenDialogueBox;
        private Button SaveMissionButton;
        private Label MobSpriteLabel;
        private Button MobSpriteFileSearchButton;
        private TextBox MobSpriteFileSearchTextBox;
        private OpenFileDialog MobSpriteFileSearchDialogueBox;
        private Label LeaderboardPersonalTimesLabel;
        private Label Time1Label;
        private Label Time2Label;
        private Label Time3Label;
        private Button PushToLeaderboardButton;
        private Label Time1ValueLabel;
        private Label Time2ValueLabel;
        private Label Time3ValueLabel;
        private Label label1;
        private ComboBox DifficultyLevelSelector;
        private Label DifficultyLevelSelectorLabel;
        private Label PlayerStatsLabel;
        private TextBox PlayerStatsSearchTextBox;
        private Button PlayerStatsSearchButton;
        private Label MobStatsLabel;
        private Button MobStatsSearchButton;
        private TextBox MobStatsSearchTextBox;
        private OpenFileDialog MobStatsFileSearchDialogueBox;
        private OpenFileDialog PlayerStatsFileSearchDialogueBox;
    }
}

