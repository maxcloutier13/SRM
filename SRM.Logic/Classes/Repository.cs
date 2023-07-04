using System.Collections.Generic;
using System.ComponentModel;
using Newtonsoft.Json;

namespace SRM.Logic.Classes
{
    public class Repository
    {
        public string Name { get; set; } = string.Empty;
        public string TargetPath { get; set; } = string.Empty;
        public string ImagePath { get; set; } = string.Empty;
        public string IconPath { get; set; } = string.Empty;
        public string ClientParams { get; set; } = "-noSplash -skipIntro -noPause";
        public ServerInfo ServerInfo { get; set; } = new ServerInfo();
        public BindingList<string> Mods { get; set; } = new BindingList<string>();
        public BindingList<string> OptionalMods { get; set; } = new BindingList<string>();

        [JsonIgnore]
        public string BasePath { get; set; } = string.Empty;

    }
}
