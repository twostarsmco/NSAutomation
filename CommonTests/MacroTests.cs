using Microsoft.VisualStudio.TestTools.UnitTesting;

using Newtonsoft.Json;

using Command;

namespace CommonTests
{
    [TestClass]
    public class MacroTests
    {
        [TestMethod]
        public void JsonSerializationTest()
        {
            var jss = new JsonSerializerSettings() { Formatting = Formatting.Indented };
            var macro = GetKONAMICommand();
            string macroJson = macro.ToJSON(jss);
            var macroFromJson = Macro.FromJSON(macroJson);

            Assert.AreEqual(macro.Commands.Count, macroFromJson.Commands.Count);
            for (int i = 0; i < macro.Commands.Count; i++)
            {
                var before = macro.Commands[i];
                var after = macroFromJson.Commands[i];
                Assert.IsInstanceOfType(after, before.GetType());
                if (before is Wait)
                {
                    Assert.AreEqual(((Wait)before).WaitTime, ((Wait)after).WaitTime);
                }
                else
                {
                    CollectionAssert.AreEqual(
                        ((OperateCommandBase)before).CommandBytes, 
                        ((OperateCommandBase)after).CommandBytes);
                }
            }
        }

        [TestMethod()]
        public void ToStringTest()
        {
            var pressA = new Macro(new CommandBase[] {
                new OperateButton(ButtonID.A, ButtonState.PRESS),
                new OperateButton(ButtonID.A, ButtonState.RELEASE)
            });
            Assert.AreEqual("PRESS A\r\nRELEASE A", pressA.ToString());
        }
        /// <summary>
        /// A sample code to generate KONAMI command sequence.
        /// Note that, as of now, this is not likely to work
        /// on actual game without appropriate waits.
        /// </summary>
        /// <returns></returns>
        private static Macro GetKONAMICommand()
        {
            var konami = new CommandBase[] {
                new OperateButton(ButtonID.UP,      ButtonState.PRESS),
                new OperateButton(ButtonID.UP,      ButtonState.RELEASE),
                new OperateButton(ButtonID.UP,      ButtonState.PRESS),
                new OperateButton(ButtonID.UP,      ButtonState.RELEASE),
                new OperateButton(ButtonID.DOWN,    ButtonState.PRESS),
                new OperateButton(ButtonID.DOWN,    ButtonState.RELEASE),
                new OperateButton(ButtonID.DOWN,    ButtonState.PRESS),
                new OperateButton(ButtonID.DOWN,    ButtonState.RELEASE),
                new OperateButton(ButtonID.LEFT,    ButtonState.PRESS),
                new OperateButton(ButtonID.LEFT,    ButtonState.RELEASE),
                new OperateButton(ButtonID.RIGHT,   ButtonState.PRESS),
                new OperateButton(ButtonID.RIGHT,   ButtonState.RELEASE),
                new OperateButton(ButtonID.LEFT,    ButtonState.PRESS),
                new OperateButton(ButtonID.LEFT,    ButtonState.RELEASE),
                new OperateButton(ButtonID.RIGHT,   ButtonState.PRESS),
                new OperateButton(ButtonID.RIGHT,   ButtonState.RELEASE),
                new OperateButton(ButtonID.B,    ButtonState.PRESS),
                new OperateButton(ButtonID.B,    ButtonState.RELEASE),
                new OperateButton(ButtonID.A,   ButtonState.PRESS),
                new OperateButton(ButtonID.A,   ButtonState.RELEASE),
            };
            return new Macro(konami);
        }
    }
}
