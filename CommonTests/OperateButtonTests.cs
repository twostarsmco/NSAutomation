using Microsoft.VisualStudio.TestTools.UnitTesting;

using Newtonsoft.Json;

using Command;

namespace CommonTests
{
    [TestClass]
    public class OperateButtonTests
    {
        [TestMethod]
        public void JsonSerializationTest()
        {
            OperateButton ob = new OperateButton(ButtonID.A, ButtonState.RELEASE);
            string obJson = JsonConvert.SerializeObject(ob);
            var obFromJson = (OperateButton)JsonConvert.DeserializeObject<CommandBase>(obJson);
            Assert.AreEqual(ob.TargetControlID, obFromJson.TargetControlID);
            Assert.AreEqual(ob.TargetState, obFromJson.TargetState);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var ob = new OperateButton(ButtonID.A, ButtonState.PRESS);
            Assert.AreEqual("PRESS A", ob.ToString());
        }
    }
}
