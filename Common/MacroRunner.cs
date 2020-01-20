using System;
using System.Collections.Generic;

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
        public abstract void Run(ICommand command);

    }
}
