using System.Threading;
using System.Threading.Tasks;

using Command;

namespace Common
{
    /// <summary>
    /// An abstract class that runs Macro.
    /// The concrete implementations are to be optimized for each OS.
    /// </summary>
    public abstract class MacroRunner
    {
        /// <summary>
        /// A port to output bytes to perform commands.
        /// </summary>
        protected IOutputPort OutputPort;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="outputPort">A port to output bytes to perform commands.param>
        public MacroRunner(IOutputPort outputPort) 
        {
            this.OutputPort = outputPort;
        }


        /// <summary>
        /// Run a macro (hopefully) asynchronously.
        /// </summary>
        /// <param name="macro">A macro to run.</param>
        /// <param name="token">A CancellationToken to stop running macro.</param>
        /// <param name="loopCount">The numbre of loop. Infinitely loops if less than 1</param>
        /// <returns></returns>
        public abstract Task RunAsync(Macro macro, CancellationToken token, int loopCount = 1);


        /// <summary>
        /// Run a macro (hopefully) asynchronously.
        /// This method cannot be cancelled from outside. use an overload with CancellationToken to do so.
        /// </summary>
        /// <param name="macro">A macro to run.</param>
        /// <param name="token">A CancellationToken to stop running macro.</param>
        /// <param name="loopCount">The numbre of loop. Infinitely loops if less than 1</param>
        /// <returns></returns>
        public abstract Task RunAsync(Macro macro, int loopCount = 1);
    }
}
