using System;
using System.IO;
using Newtonsoft.Json;

namespace NSAutomationWin
{
    public class Config
    {
        private readonly object Locker = new object();

        #region Parameters
        private string comPort = "";

        public string COMPort
        {
            get { lock (this.Locker) { return comPort; } }
            set 
            { 
                lock (this.Locker) 
                { 
                    comPort = value;
                    if (this.AutoSave) { this.Save(); }
                } 
            }
        }

        private bool online = false;

        public bool Online
        {
            get {lock (this.Locker) { return online; } }
            set {
                lock (this.Locker) 
                { 
                    online = value;
                    if (this.AutoSave) { this.Save(); }
                }
            }
        }

        #endregion

        #region JSON serialization and deserialization
        public Config() { }

        public static Config FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Config>(json);
        }

        public static Config FromFile(string filePath)
        {
            Config config = Config.FromJson(File.ReadAllText(filePath));
            config.ConfigFilePath = filePath;
            return config;
        }


        public string ToJson()
        {
            lock (this.Locker)
            {
                return JsonConvert.SerializeObject(this,
                    new JsonSerializerSettings() { Formatting = Formatting.Indented });
            }
        }

        #endregion

        #region AutoSave
        public void Save()
        {
            lock (this.Locker)
            {
                string json = this.ToJson();
                try
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(this.ConfigFilePath));
                    File.WriteAllText(this.ConfigFilePath, json);
                }
                catch (Exception)
                {
                    throw new InvalidOperationException("Please set valid ConfigFilePath property before saving.");
                }
            }
        }
        [JsonIgnore]
        private bool autoSave;

        [JsonIgnore]
        public bool AutoSave
        {
            get { lock (this.Locker) { return autoSave; } }
            set { lock (this.Locker) { autoSave = value; } }
        }


        [JsonIgnore]
        private string configFilePath;

        [JsonIgnore]
        public string ConfigFilePath
        {
            get { lock (this.Locker) { return configFilePath; } }
            set { lock (this.Locker) { configFilePath = Path.GetFullPath(value); } }
        }

        #endregion
    }
}
