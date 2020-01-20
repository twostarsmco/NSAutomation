using System;
using System.Collections.Generic;

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

        public override void Run(ICommand command)
        {
            throw new NotImplementedException();
        }

    }
}
