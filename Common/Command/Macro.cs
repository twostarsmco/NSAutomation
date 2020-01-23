using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Command
{
    /// <summary>
    /// Represents a sequence of ICommand instances to execute sequentially,
    /// decorated with additional informations.
    /// </summary>
    public class Macro //: ICommand
    {
        /// <summary>
        /// A sequence of ICommand this instance represents.
        /// </summary>
        public IReadOnlyList<ICommand> Commands;


        /// <summary>
        /// 
        /// </summary>
        /// <param name="commands">A sequence of ICommand to execute.</param>
        public Macro(IList<ICommand> commands)//, string location)
        {
            this.Commands = commands.ToArray() ?? new ICommand[] { };
        }


        /// <summary>
        /// The description of this macro.
        /// Write usage, prerequisite, cautions etc. here.
        /// </summary>
        public string Description { get; set; }

        //TODO: implement macro that calls another macro
        public IList<ICommand> Flatten()
        {
            List<ICommand> commandsFlat = new List<ICommand>();
            foreach (var command in this.Commands)
            {
                commandsFlat.Add(command);
            }
            return commandsFlat;
        }


        public override string ToString()
        {
            return string.Join("\r\n", this.Commands.Select(command => command.ToString()));
        }
    }
}
