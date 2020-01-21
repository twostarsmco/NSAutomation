using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSAutomationWin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NSAutomationWin.Tests
{
    [TestClass()]
    public class ConfigTests
    {
        [TestMethod()]
        public void JsonTest()
        {
            var config = SampleConfig;
            string jsonConfig = SampleConfig.ToJson();
            var configFromJson = Config.FromJson(jsonConfig);

            Assert.IsTrue(config.COMPort == configFromJson.COMPort);
        }

        [TestMethod]
        public void SaveTest()
        {
            var config = SampleConfig;
            config.ConfigFilePath = Path.GetTempFileName();
            try
            {
                config.Save();

                var configFromFile = Config.FromFile(config.ConfigFilePath);
                Assert.IsTrue(config.COMPort == configFromFile.COMPort);
            }
            finally
            {
                File.Delete(config.ConfigFilePath);
            }
        }


        private Config SampleConfig { get { return new Config() { COMPort = "COM1" }; } }
    }
}