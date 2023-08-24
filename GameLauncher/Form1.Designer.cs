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
            this.SpriteLabel = new System.Windows.Forms.Label();
            this.SpriteFileSearchButton = new System.Windows.Forms.Button();
            this.SpriteFileSearchTextBox = new System.Windows.Forms.TextBox();
            this.SpriteFileSearchDialogueBox = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetFPSNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayButton.Location = new System.Drawing.Point(297, 378);
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
            this.LeaderboardHeader.Location = new System.Drawing.Point(587, 9);
            this.LeaderboardHeader.Name = "LeaderboardHeader";
            this.LeaderboardHeader.Size = new System.Drawing.Size(201, 39);
            this.LeaderboardHeader.TabIndex = 2;
            this.LeaderboardHeader.Text = "Leaderboard";
            // 
            // LeaderboardRefreshButton
            // 
            this.LeaderboardRefreshButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardRefreshButton.Location = new System.Drawing.Point(587, 51);
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
            this.LeaderboardLastUpdatedLabel.Location = new System.Drawing.Point(668, 48);
            this.LeaderboardLastUpdatedLabel.Name = "LeaderboardLastUpdatedLabel";
            this.LeaderboardLastUpdatedLabel.Size = new System.Drawing.Size(0, 15);
            this.LeaderboardLastUpdatedLabel.TabIndex = 5;
            // 
            // LeaderboardDataLabel
            // 
            this.LeaderboardDataLabel.AutoSize = true;
            this.LeaderboardDataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LeaderboardDataLabel.Location = new System.Drawing.Point(584, 80);
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
            this.UsernameLabel.Location = new System.Drawing.Point(307, 143);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(87, 20);
            this.UsernameLabel.TabIndex = 28;
            this.UsernameLabel.Text = "Username:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTextBox.Location = new System.Drawing.Point(311, 166);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(195, 21);
            this.UsernameTextBox.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "C:\\Users\\Daniel\\source\\repos\\GameLauncher\\GameLauncher\\map.ico";
            this.pictureBox1.Location = new System.Drawing.Point(343, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // SpriteLabel
            // 
            this.SpriteLabel.AutoSize = true;
            this.SpriteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpriteLabel.Location = new System.Drawing.Point(307, 190);
            this.SpriteLabel.Name = "SpriteLabel";
            this.SpriteLabel.Size = new System.Drawing.Size(84, 20);
            this.SpriteLabel.TabIndex = 31;
            this.SpriteLabel.Text = "Sprite File:";
            // 
            // SpriteFileSearchButton
            // 
            this.SpriteFileSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpriteFileSearchButton.Location = new System.Drawing.Point(397, 190);
            this.SpriteFileSearchButton.Name = "SpriteFileSearchButton";
            this.SpriteFileSearchButton.Size = new System.Drawing.Size(109, 22);
            this.SpriteFileSearchButton.TabIndex = 32;
            this.SpriteFileSearchButton.Text = "Browse";
            this.SpriteFileSearchButton.UseVisualStyleBackColor = true;
            this.SpriteFileSearchButton.Click += new System.EventHandler(this.SpriteFileSearchButton_Click);
            // 
            // SpriteFileSearchTextBox
            // 
            this.SpriteFileSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpriteFileSearchTextBox.Location = new System.Drawing.Point(311, 213);
            this.SpriteFileSearchTextBox.Name = "SpriteFileSearchTextBox";
            this.SpriteFileSearchTextBox.Size = new System.Drawing.Size(195, 21);
            this.SpriteFileSearchTextBox.TabIndex = 33;
            // 
            // SpriteFileSearchDialogueBox
            // 
            this.SpriteFileSearchDialogueBox.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
            this.SpriteFileSearchDialogueBox.InitialDirectory = "C:\\Repositories\\NEAGame\\Game\\resources\\sprites";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SpriteFileSearchTextBox);
            this.Controls.Add(this.SpriteFileSearchButton);
            this.Controls.Add(this.SpriteLabel);
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private System.Windows.Forms.Label SpriteLabel;
        private System.Windows.Forms.Button SpriteFileSearchButton;
        private System.Windows.Forms.TextBox SpriteFileSearchTextBox;
        private System.Windows.Forms.OpenFileDialog SpriteFileSearchDialogueBox;
    }
}

