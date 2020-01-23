using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Command;

namespace NSAutomationWin
{
    /// <summary>
    /// A class to wrap instances that implement ICommand interface,
    /// in order to bind BindingList of commands data to DataGridView.
    /// </summary>
    class CommandWrapper
    {
        public ICommand Command;
        public CommandWrapper() : this(CommandEditDialog.CreateNewCommandFromDialog()) { }
        public CommandWrapper(ICommand command)
        { this.Command = command; }


        /// <summary>
        /// A state indicating whether this instance is waiting to be executed, or finished.
        /// This information is to be used on GUI to visualize progress.
        /// </summary>
        public ExecutionState State { get; set; }

        /// <summary>
        /// A property that returns this.Command.ToString() method.
        /// This can be used in BindingList.
        /// </summary>
        public string Text { get { return this.Command.ToString() ?? ""; } }

        public override string ToString() { return this.Text; }
    }

    /// <summary>
    /// A state indicating whether a command is waiting to be executed, or finished.
    /// </summary>
    enum ExecutionState
    {
        // More detailed states may be added in future.
        Waiting, Finished
        }
    }
