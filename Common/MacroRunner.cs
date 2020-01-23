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
        /// Run a macro synchronously.
        /// </summary>
        /// <param name="macro">A macro to run.</param>
        public abstract void Run(Macro macro);


        /// <summary>
        /// Run a macro (hopefully) asynchronously.
        /// </summary>
        /// <param name="macro">A macro to run.</param>
        /// <returns></returns>
        public abstract Task RunAsync(Macro macro);
    }
}
