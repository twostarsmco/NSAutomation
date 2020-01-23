using System.Threading.Tasks;

using Common;
using Command;

namespace WindowsBackend
{
    /// <summary>
    /// A concrete implementation of a class that runs Macro.
    /// </summary>
    public class MacroRunner : Common.MacroRunner
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="outputPort">A port to output bytes to perform commands.param>
        public MacroRunner(IOutputPort outputPort) : base(outputPort)
        {
            this.OutputPort = outputPort;
        }

        public override void Run(Macro macro)
        {
            this.RunAsync(macro).Wait();
        }

        //TODO: Use MultimediaTimer or something like that to achieve better timing accuracy
        /// <summary>
        /// Run a macro asynchronously.
        /// </summary>
        /// <param name="macro">A macro to run.</param>
        /// <returns></returns>
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
