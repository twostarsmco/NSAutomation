using System.Threading.Tasks;

using Common;
using Command;

namespace WindowsBackend
{
    public class MacroRunner : Common.MacroRunner
    {
        public MacroRunner(IOutputPort outputPort) : base(outputPort)
        {
            this.OutputPort = outputPort;
        }

        public override void Run(Macro macro)
        {
            this.RunAsync(macro).Wait();
        }

        //TODO: Use MultimediaTimer or something like that to achieve better timing accuracy

        public override async Task RunAsync(Macro macro)
        {
            var commands = macro.Flatten();
            foreach (var command in commands)
            {
                switch (command)
                {
                    case Wait w:
                        await Task.Delay(w.WaitTime);
                        break;
                    case OperateCommandBase c:
                        this.OutputPort.Send(c);
                        break;
                }
            }
        }
    }
}
