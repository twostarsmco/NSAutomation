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
    public class CommandWrapper
    {
        /// <summary>
        /// An instance of ICommand that this instance holds.
        /// </summary>
        public CommandBase Command;


        /// <summary>
        /// Initializes a new instance by opening a CommandEditDialog, holding the instance that it returns.
        /// </summary>
        public CommandWrapper() : this(CommandEditDialog.CreateNewCommandFromDialog()) { }


        /// <summary>
        /// Initializes a new instance, holding specified ICommand object.
        /// </summary>
        /// <param name="command"></param>
        public CommandWrapper(CommandBase command)
        { this.Command = command; }


        /// <summary>
        /// Initializes a new instance by parsing a string, that is a return value of ICommand.ToString() method.
        /// If commandString is not parsable, throws ArgumentException.
        /// This constructor is for enabling copy / paste functionality on MacroDesigner.
        /// </summary>
        /// <param name="commandString">A return value of ICommand.ToString() method</param>
        public CommandWrapper(string commandString)
        {
            string CleanCommaAndParenthesis(string s) => s.Replace(",", "").Replace("(", "").Replace(")", "");

            ArgumentException ae = new ArgumentException("Failed to parse parameter.", "commandToString");
            CommandBase command;
            try
            {
                string[] elements = commandString.Split(' ');
                string head = elements[0];
                if (head == "Wait")
                {
                    command = new Wait(int.Parse(elements[1]));
                }
                else if (head == "PRESS" || head == "RELEASE")
                {
                    command = new OperateButton(
                        (ButtonID)Enum.Parse(typeof(ButtonID), elements[1]),
                        head == "PRESS" ? ButtonState.PRESS : ButtonState.RELEASE);
                }
                else if (head == "LSTICK" || head == "RSTICK")
                {
                    command = new OperateStick(
                        head == "LSTICK" ? StickID.LSTICK : StickID.RSTICK,
                        byte.Parse(CleanCommaAndParenthesis(elements[1])),
                        byte.Parse(CleanCommaAndParenthesis(elements[2]))
                        );
                }
                else
                {
                    throw ae;
                }
            }
            catch (Exception)
            {
                throw ae;
            }

            this.Command = command;
        }


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
    public enum ExecutionState
    {
        // More detailed states may be added in future.
        Waiting, Finished
        }
    }
