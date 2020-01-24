using System;
using System.IO;
using Newtonsoft.Json;

namespace NSAutomationWin
{
    /// <summary>
    /// An object containing configurations for this application.
    /// </summary>
    public class Config
    {
        private readonly object Locker = new object();

        #region Parameters

        private string comPort = "";
        /// <summary>
        /// A string to identify COM port to be used, e.g. "COM1".
        /// </summary>
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
        /// <summary>
        /// Whether the connection to COM port was available.
        /// </summary>
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

        /// <summary>
        /// Deserialize an instance from JSON string.
        /// </summary>
        /// <param name="json">A JSON data.</param>
        /// <returns></returns>
        public static Config FromJson(string json)
        {
            return JsonConvert.DeserializeObject<Config>(json);
        }


        /// <summary>
        /// Deserialize an instance from specified JSON file.
        /// </summary>
        /// <param name="filePath">A path to JSON file.</param>
        /// <returns></returns>
        public static Config FromFile(string filePath)
        {
            Config config = Config.FromJson(File.ReadAllText(filePath));
            config.ConfigFilePath = filePath;
            return config;
        }


        /// <summary>
        /// Output a JSON string representing this instance.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Save content of this instance to a file specified in this.ConfigFilePath.
        /// </summary>
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
        /// <summary>
        /// Whether attempt to save content of this instance to a specified file,
        /// whenever certain properties are changed.
        /// </summary>
        [JsonIgnore]
        public bool AutoSave
        {
            get { lock (this.Locker) { return autoSave; } }
            set { lock (this.Locker) { autoSave = value; } }
        }


        [JsonIgnore]
        private string configFilePath;
        /// <summary>
        /// A path to JSON file this instance is saved to.
        /// </summary>
        [JsonIgnore]
        public string ConfigFilePath
        {
            get { lock (this.Locker) { return configFilePath; } }
            set { lock (this.Locker) { configFilePath = Path.GetFullPath(value); } }
        }

        #endregion
    }
}
