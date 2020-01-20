using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Command
{
    public class Macro //: ICommand
    {
        public IReadOnlyList<ICommand> Commands;


        public Macro(IList<ICommand> commands)//, string location)
        {
            this.Commands = commands.ToArray() ?? new ICommand[] { };
        }

        //TODO: implement macro that calls another macro
        public IList<ICommand> Flatten()
        {
            List<ICommand> commandsFlat = new List<ICommand>();
            foreach (var command in this.Commands)
            {
                if (command is Macro)
                {
                    commandsFlat.AddRange(((Macro)command).Flatten());
                }
                else
                {
                    commandsFlat.Add(command);
                }
            }
            return commandsFlat;
        }

    }
}
