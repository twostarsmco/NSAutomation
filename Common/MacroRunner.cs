using System.Threading.Tasks;

using Command;

namespace Common
{
    public abstract class MacroRunner
    {
        protected IOutputPort OutputPort;
        public MacroRunner(IOutputPort outputPort) 
        {
            this.OutputPort = outputPort;
        }
        public abstract void Run(Macro macro);

        public abstract Task RunAsync(Macro macro);
    }
}
