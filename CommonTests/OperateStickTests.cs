using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Collections.Generic;
//using System.Text.Json;
//using System.Text.Json.Serialization;

using Newtonsoft.Json;

using Command;

namespace CommonTests
{
    [TestClass]
    public class OperateStickTests
    {
        [TestMethod]
        public void JsonSerializationTest()
        {
            OperateStick os = new OperateStick(StickID.RSTICK, StickAngle.MAX, StickAngle.NEUTRAL);
            string obJson = JsonConvert.SerializeObject(os);
            var obFromJson = JsonConvert.DeserializeObject<OperateStick>(obJson);

            Assert.AreEqual(os.TargetControlID, obFromJson.TargetControlID);
            Assert.AreEqual(os.TargetXAngle, obFromJson.TargetXAngle);
            Assert.AreEqual(os.TargetYAngle, obFromJson.TargetYAngle);
        }


        [TestMethod()]
        public void ToStringTest()
        {
            var os = new OperateStick(StickID.LSTICK, 90, 180);
            Assert.AreEqual("LSTICK (90, 180)", os.ToString());
        }
    }
}
