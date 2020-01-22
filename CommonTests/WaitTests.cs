using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
//using System.Text.Json;
//using System.Text.Json.Serialization;

using Newtonsoft.Json;

using Command;

namespace CommonTests
{
    [TestClass]
    public class WaitTests
    {
        [TestMethod]
        public void JsonSerializationTest()
        {
            var waitCommand = new Wait(151);
            string waitJson = JsonConvert.SerializeObject(waitCommand);
            var waitFromJson = JsonConvert.DeserializeObject<Wait>(waitJson);

            Assert.AreEqual(waitCommand.WaitTime, waitFromJson.WaitTime);
        }


        [TestMethod()]
        public void ToStringTest()
        {
            var wait = new Wait(365);
            Assert.AreEqual("Wait 365", wait.ToString());
        }
    }


}
