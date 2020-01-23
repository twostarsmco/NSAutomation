using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Command;

namespace WindowsBackend.Tests
{
    [TestClass()]
    public class MacroRunnerTests
    {
        [TestMethod()]
        public async Task RunAsyncTest()
        {
            var m = new Macro(new ICommand[] {
                new OperateButton(ButtonID.A, ButtonState.PRESS),
                new Wait(100),
                new OperateButton(ButtonID.A, ButtonState.RELEASE),
            });

            MacroRunner runner = new MacroRunner(new Common.MockPort());

            await runner.RunAsync(m, new System.Threading.CancellationToken());

        }
    }
}