using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLauncher
{
    public class Settings
    {
        public bool fullscreen;
        public bool music;
        public int height;
        public int width;
        public int targetFPS;
        public string resources;
    }

    public class LauncherSettings
    {
        public string settingsfile;
        public string username;
        public string spritefile;
    }
}
