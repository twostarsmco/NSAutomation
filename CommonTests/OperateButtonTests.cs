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
            var obFromJson = JsonConvert.DeserializeObject<OperateButton>(obJson);
            Assert.AreEqual(ob.TargetControlID, obFromJson.TargetControlID);
            Assert.AreEqual(ob.TargetState, obFromJson.TargetState);
        }
    }
}