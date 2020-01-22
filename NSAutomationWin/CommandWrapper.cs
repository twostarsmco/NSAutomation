using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Command;

namespace NSAutomationWin
{
    class CommandWrapper
    {
        public ICommand Command;
        public CommandWrapper() : this(CommandEditDialog.CreateNewCommandFromDialog()) { }
        public CommandWrapper(ICommand command)
        { this.Command = command; }

        public ExecutionState State { get; set; }

        public string Text { get { return this.Command.ToString() ?? ""; } }

        public override string ToString() { return this.Text; }
    }

    enum ExecutionState
    {
        Waiting, Finished
        }
    }
