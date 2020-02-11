using System.Threading;
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
        private Semaphore Semaphore = new Semaphore(1, 1);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="outputPort">A port to output bytes to perform commands.param>
        public MacroRunner(IOutputPort outputPort) : base(outputPort)
        {
            this.OutputPort = outputPort;
        }


        //TODO: Use MultimediaTimer or something like that to achieve better timing accuracy
        /// <summary>
        /// Run a macro asynchronously.
        /// </summary>
        /// <param name="macro">A macro to run.</param>
        /// <param name="token">A CancellationToken to stop running macro.</param>
        /// <param name="loopCount">The numbre of loop. Infinitely loops if less than 1</param>
        /// <returns></returns>
        public override async Task RunAsync(Macro macro, CancellationToken token, int loopCount = 1)
        {
            Semaphore.WaitOne();

            try
            {
                bool runInfinitely = (loopCount < 1);
                var commands = macro.Flatten();
                int i = 0;
                do
                {
                    i++;

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
                        if (token.IsCancellationRequested) return;
                    }
                } while (i < loopCount || runInfinitely);
            }
            finally
            {
                Semaphore.Release();
            }
        }


        /// <summary>
        /// Run a macro asynchronously.
        /// This method cannot be cancelled from outside. use an overload with CancellationToken to do so.
        /// </summary>
        /// <param name="macro">A macro to run.</param>
        /// <param name="loopCount">The numbre of loop. Infinitely loops if less than 1</param>
        public override Task RunAsync(Macro macro, int loopCount = 1) { return this.RunAsync(macro, new CancellationToken(), loopCount); }
    }
}
